using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using Gif.Components;

namespace HeidersBalancer {
	public partial class MainWindow : Form {
		public MainWindow() {
			InitializeComponent();
		}
        int m_iCount = 25;
        double m_R = 1;
        bool m_bDeleteing;
        Dictionary<ListViewItem, int> m_items1;
        Dictionary<ListViewItem, int> m_items2;
        InnerStructure m_Inner;
		private void MainWindow_Load(object sender, EventArgs e) {
			comboBoxLayout.SelectedIndex = 0;
            m_Inner = new InnerStructure();
            m_items1 = new Dictionary<ListViewItem, int>();
            m_items2 = new Dictionary<ListViewItem, int>();
            m_bDeleteing = false;
		}
        public void Render()
        {
            string str = GenerateText();
            if (str != "")
                picGraph.Image = Graphviz.RenderImage(str, (string)comboBoxLayout.SelectedItem, "png");
        }
		private void btnRender_Click(object sender, EventArgs e) {
			//try {
            Render();
//			} catch (Exception ex) {
//				MessageBox.Show(this, ex.Message, "Error!");
//			}
		}
        private string GenerateText()
        {
            return m_Inner.GenerateDorString();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            m_Inner = new InnerStructure();
            m_items1.Clear();
            m_items2.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_Inner.LoadFromFile(openFileDialog1.FileName);
            }
            FillList1();
            FillList2();
            btnRender_Click(null, null);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_Inner.SaveToFile(saveFileDialog1.FileName);
            }
        }
        private void FillList1()
        {
            m_items1.Clear();
            foreach (var el in m_Inner.m_Vertexes)
            {
                ListViewItem item = listView1.Items.Add(el.Key.ToString(), el.Value, -1);
                m_items1.Add(item, el.Key);
            }
        }
        private void FillList2()
        {
            if (m_bDeleteing)
                return;
            m_items2.Clear();
            listView2.Items.Clear();
            int i;
            for (i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem selitem = listView1.Items[i];
                if (!selitem.Selected)
                    continue;
                int iPos = m_items1[selitem];
                foreach (var el in m_Inner.m_Vertexes)
                {
                    if (iPos == el.Key)
                        continue;
                    Color col = Color.FromArgb(0, 0, 0);
                    ListViewItem item = listView2.Items.Add(el.Key.ToString(), el.Value, -1);
                    double dVal = m_Inner.GetEdgeVal(iPos, el.Key);
                    if (dVal < 0)
                        col = Color.FromArgb((int)(255 * (-dVal)), 0, 0);
                    else
                        col = Color.FromArgb(0, (int)(255 * dVal), 0);
                    item.ForeColor = col;
                    m_items2.Add(item, el.Key);
                }
                break;
            } 
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddTextBox.Text == "")
                return;
            AddTextBox.Text = AddTextBox.Text.Trim();
            int iPos = m_Inner.AddVertex(AddTextBox.Text);
            ListViewItem item = listView1.Items.Add(iPos.ToString(), AddTextBox.Text, -1);
            m_items1.Add(item, iPos);
            AddTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            m_bDeleteing = true;
            int i;
            for (i = 0; i < listView1.Items.Count;i++ )
            {
                ListViewItem item = listView1.Items[i];
                if (!item.Selected)
                    continue;
                int iPos = m_items1[item];
                m_Inner.DeleteVertex(iPos);
                m_items1.Remove(item);
                listView1.Items.RemoveAt(i);
                break;
            }
            m_bDeleteing = false;
            FillList2();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillList2();
        }

        private void PositiveButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1 || listView2.SelectedItems.Count != 1)
                return;
            m_Inner.SetEdgeVal(m_items1[listView1.SelectedItems[0]], m_items2[listView2.SelectedItems[0]], 1);
            listView2.SelectedItems[0].ForeColor = Color.FromArgb(0, 255, 0);
            btnRender_Click(null, null);
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1 || listView2.SelectedItems.Count != 1)
                return;
            m_Inner.SetEdgeVal(m_items1[listView1.SelectedItems[0]], m_items2[listView2.SelectedItems[0]], -1);
            listView2.SelectedItems[0].ForeColor = Color.FromArgb(255, 0, 0);
            btnRender_Click(null, null);
        }

        private void NeutralButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1 || listView2.SelectedItems.Count != 1)
                return;
            m_Inner.SetEdgeVal(m_items1[listView1.SelectedItems[0]], m_items2[listView2.SelectedItems[0]], 0);
            listView2.SelectedItems[0].ForeColor = Color.FromArgb(0, 0, 0);
            btnRender_Click(null, null);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            
            m_Inner.Clear();
            int i = 0, j = 0;
            for (i = 0; i < m_iCount; i++)
                m_Inner.AddVertex((i + 1).ToString());
            System.Random r = new Random();

            for (i = 0; i < m_iCount - 1; i++)
            {
                for (j = i + 1; j < m_iCount; j++)
                {
                    double dVal = r.NextDouble() * 2.0*m_R - m_R;
                    m_Inner.SetEdgeVal(i, j, dVal);
                    m_Inner.SetEdgeStringVal(i, j, dVal.ToString("0.#"));
                }
            }
            Render();
        }
        int m_iVal = 0;
        void Calculate(bool bWithGif)
        {
            m_iVal++;
            bool bFlag = true;
            
            Image image;

            AnimatedGifEncoder gifEncoder = new AnimatedGifEncoder();
            String outputFilePath = "outputtest" + m_iVal.ToString() + "-" + m_iCount + ".gif";
            if (bWithGif)
            {
                gifEncoder.Start(outputFilePath);
                gifEncoder.SetDelay(500);
                gifEncoder.SetRepeat(0);
            }
            int iSteps = 0;
            m_iCount = m_Inner.m_Vertexes.Count;
            while (bFlag&&iSteps<20)
            {
                iSteps++;
                Dictionary<KeyValuePair<int, int>, double> bufEdges = new Dictionary<KeyValuePair<int, int>, double>();
                int i = 0, j = 0, k = 0;
                bFlag = false;
                double dSum = 0;
                for (i = 0; i < m_iCount; i++)
                {
                    for (j = 0; j < m_iCount; j++)
                    {
                        KeyValuePair<int, int> pp = new KeyValuePair<int, int>(i, j);
                        if (!m_Inner.m_Edges.ContainsKey(pp))
                            continue;
                        dSum = 0;
                        for (k = 0; k < m_iCount; k++)
                        {
                            KeyValuePair<int, int> pp1 = new KeyValuePair<int, int>(i, k);
                            if (!m_Inner.m_Edges.ContainsKey(pp1))
                                pp1 = new KeyValuePair<int, int>(k, i);
                            if (!m_Inner.m_Edges.ContainsKey(pp1))
                                continue;
                            KeyValuePair<int, int> pp2 = new KeyValuePair<int, int>(k, j);
                            if (!m_Inner.m_Edges.ContainsKey(pp2))
                                pp2 = new KeyValuePair<int, int>(j, k);
                            if (!m_Inner.m_Edges.ContainsKey(pp2))
                                continue;
                            if (m_Inner.m_Edges[pp1]==0)
                            {
                                m_Inner.m_Edges[pp1] = 0.001;
                            }
                            if (m_Inner.m_Edges[pp2] == 0)
                            {
                                m_Inner.m_Edges[pp2] = 0.001;
                            }
                            dSum += m_Inner.m_Edges[pp1] * m_Inner.m_Edges[pp2];
                        }
                        if (m_Inner.m_Edges[pp] == 0)
                        {
                            m_Inner.m_Edges[pp] = 0.001;
                        }
                        dSum *= (1 - Math.Pow(m_Inner.m_Edges[pp] / m_R, 2.0));
                        bufEdges.Add(pp, dSum);
                    }
                    Console.WriteLine(i.ToString()+" - ");
                }
                foreach (var el in bufEdges)
                {
                    m_Inner.m_Edges[el.Key] += el.Value;
                    if (m_Inner.m_Edges[el.Key] > 1)
                        m_Inner.m_Edges[el.Key] = 1;
                    if (m_Inner.m_Edges[el.Key] < -1)
                        m_Inner.m_Edges[el.Key] = -1;
                    if (m_Inner.m_Edges[el.Key] != -1 && m_Inner.m_Edges[el.Key] != 1)
                        bFlag = true;
                    m_Inner.SetEdgeStringVal(el.Key.Key, el.Key.Value, m_Inner.m_Edges[el.Key].ToString("0.#"));
                }
                dSum = 0;
                for (i = 0; i < m_iCount; i++)
                {
                    for (j = 0; j < m_iCount; j++)
                    {
                        KeyValuePair<int, int> pp = new KeyValuePair<int, int>(i, j);
                        if (!m_Inner.m_Edges.ContainsKey(pp))
                            continue;
                        for (k = 0; k < m_iCount; k++)
                        {
                            KeyValuePair<int, int> pp1 = new KeyValuePair<int, int>(i, k);
//                            if (!m_Inner.m_Edges.ContainsKey(pp1))
//                                pp1 = new KeyValuePair<int, int>(k, i);
                            if (!m_Inner.m_Edges.ContainsKey(pp1))
                                continue;
                            KeyValuePair<int, int> pp2 = new KeyValuePair<int, int>(k, j);
//                            if (!m_Inner.m_Edges.ContainsKey(pp2))
//                                pp2 = new KeyValuePair<int, int>(j, k);
                            if (!m_Inner.m_Edges.ContainsKey(pp2))
                                continue;
                            if ((m_Inner.m_Edges[pp1] * m_Inner.m_Edges[pp2] * m_Inner.m_Edges[pp]) > 0)
                                dSum++;
                        }
                    }
                    Console.WriteLine(i.ToString() + " + ");
                }
                m_Inner.SetBalanced(dSum);
                Console.WriteLine(dSum.ToString());
                
                picGraph.Image = image = Graphviz.RenderImage(GenerateText(), (string)comboBoxLayout.SelectedItem, "png");
                if (bWithGif)
                {
                    gifEncoder.AddFrame(image);
                }
                
                Application.DoEvents();
            }
            if (bWithGif)
            {
                gifEncoder.Finish();
            }
            
        }

        private void calculateWithGifOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }

        private void NoneButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1 || listView2.SelectedItems.Count != 1)
                return;
            m_Inner.RemoveEdgeVal(m_items1[listView1.SelectedItems[0]], m_items2[listView2.SelectedItems[0]]);
            listView2.SelectedItems[0].ForeColor = Color.FromArgb(0, 0, 0);
            btnRender_Click(null, null);
        }
	}
}
