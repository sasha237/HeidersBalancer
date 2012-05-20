using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeidersBalancer
{
    public class InnerStructure
    {
        public Dictionary<int, string> m_Vertexes;
        public Dictionary<KeyValuePair<int, int>, double> m_Edges;
        public Dictionary<KeyValuePair<int, int>, string> m_EdgesStrings;
        int m_iMaxIndex = 0;
        double m_dBal = 0;
        public InnerStructure()
        {
            m_Vertexes = new Dictionary<int, string>();
            m_Edges = new Dictionary<KeyValuePair<int, int>, double>();
            m_EdgesStrings = new Dictionary<KeyValuePair<int, int>, string>();
            m_iMaxIndex = 0;
            m_dBal = 0;
        }
        public int AddVertex(string sVal)
        {
            int iCount = m_iMaxIndex++;
            m_Vertexes.Add(iCount, sVal);
            return iCount;
        }
        public void DeleteVertex(int iPos)
        {
            if (m_Vertexes.ContainsKey(iPos))
                m_Vertexes.Remove(iPos);
            KeyValuePair<int, int>[] pp = new KeyValuePair<int, int>[m_Edges.Count];
            m_Edges.Keys.CopyTo(pp, 0);
            foreach (var el in pp)
            {
                if (el.Key == iPos || el.Value == iPos)
                    m_Edges.Remove(el);
            }
            pp = new KeyValuePair<int, int>[m_EdgesStrings.Count];
            m_EdgesStrings.Keys.CopyTo(pp, 0);
            foreach (var el in pp)
            {
                if (el.Key == iPos || el.Value == iPos)
                    m_EdgesStrings.Remove(el);
            }
        }
        public void SetEdgeVal(int i1, int i2, double dVal)
        {
            KeyValuePair<int, int> pp = new KeyValuePair<int, int>(i1, i2);
            if(m_Edges.ContainsKey(pp))
            {
                m_Edges[pp] = dVal;
            }
            else
            {
                m_Edges[pp] = dVal;
            }
        }
        public void SetEdgeStringVal(int i1, int i2, string sVal)
        {
            KeyValuePair<int, int> pp = new KeyValuePair<int, int>(i1, i2);
            if (m_Edges.ContainsKey(pp))
            {
                m_EdgesStrings[pp] = sVal;
            }
            else
            {
                m_EdgesStrings[pp] = sVal;
            }
        }
        public string GetVertexText(int iKey)
        {
            if (m_Vertexes.ContainsKey(iKey))
                return m_Vertexes[iKey];
            return "";
        }
        public double GetEdgeVal(KeyValuePair<int, int> pp)
        {
            if (m_Edges.ContainsKey(pp))
                return m_Edges[pp];
            return 0;
        }
        public void SaveToFile(string sPath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(m_Vertexes.Count.ToString());
            foreach (var el in m_Vertexes)
            {
                sb.AppendLine(el.Key.ToString());
                sb.AppendLine(el.Value.ToString());
            }
            sb.AppendLine(m_Edges.Count.ToString());
            foreach (var el in m_Edges)
            {
                sb.AppendLine(el.Key.Key.ToString());
                sb.AppendLine(el.Key.Value.ToString());
                sb.AppendLine(el.Value.ToString());
            }
            foreach (var el in m_EdgesStrings)
            {
                sb.AppendLine(el.Key.Key.ToString());
                sb.AppendLine(el.Key.Value.ToString());
                sb.AppendLine(el.Value.ToString());
            }
            System.IO.File.WriteAllText(sPath, sb.ToString());
        }
        public void Clear()
        {
            m_Vertexes = new Dictionary<int, string>();
            m_Edges = new Dictionary<KeyValuePair<int, int>, double>();
            m_EdgesStrings = new Dictionary<KeyValuePair<int, int>, string>();
            m_iMaxIndex = 0;
        }
        public void LoadFromFile(string sPath)
        {
            Clear();
            try
            {
                int ipos = 0;
                int iVal;
                int iVal2;
                double dVal3;
                string sVal;
                string[] sLines = System.IO.File.ReadAllLines(sPath);
                int iCount = int.Parse(sLines[ipos++]);
                while (iCount-- != 0)
                {
                    iVal = int.Parse(sLines[ipos++]);
                    sVal = sLines[ipos++];
                    m_Vertexes.Add(iVal, sVal);
                }
                iCount = int.Parse(sLines[ipos++]);
                while (iCount-- != 0)
                {
                    iVal = int.Parse(sLines[ipos++]);
                    iVal2 = int.Parse(sLines[ipos++]);
                    dVal3 = double.Parse(sLines[ipos++]);
                    m_Edges.Add(new KeyValuePair<int, int>(iVal, iVal2), dVal3);
                }
                iCount = int.Parse(sLines[ipos++]);
                while (iCount-- != 0)
                {
                    iVal = int.Parse(sLines[ipos++]);
                    iVal2 = int.Parse(sLines[ipos++]);
                    sVal = sLines[ipos++];
                    m_EdgesStrings.Add(new KeyValuePair<int, int>(iVal, iVal2), sVal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GenerateDorString()
        {
            if (m_Vertexes.Count > 25)
                return "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("graph \"\" {");
            foreach (var el in m_Vertexes)
            {
                sb.AppendFormat("n{0} [label=\"{1}\"];\n",el.Key,el.Value);
            }
            foreach (var el1 in m_Edges)
            {
                //sb.AppendFormat("n{0} -- n{1} [color = \"{2}\" label=\"{3}\"]", el1.Key.Key, el1.Key.Value, (el1.Value > 0) ? "#00ff00" : "#ff0000", (el1.Value > 0) ? "+" : "-");
                
                int iVal = (int)(255 * Math.Abs(el1.Value));
                string sColor;
                if (el1.Value > 0)
                {
                    sColor = "#00" + iVal.ToString("X") + "00";
                }
                else
                {
                    sColor = "#"+iVal.ToString("X") + "0000";
                }
                sb.AppendFormat("n{0} -- n{1} [color = \"{2}\" label=\"{3}\"]", el1.Key.Key, el1.Key.Value, sColor, /*m_EdgesStrings[el1.Key]*/"");
                
            }
            sb.AppendFormat("label = \"{0}\"", m_dBal);
            sb.AppendLine("}");
            return sb.ToString();
        }
        public void SetBalanced(double dSum)
        {
            double dCount = m_Vertexes.Count;
            m_dBal = dSum * 6.0 / ((dCount) * (dCount - 1.0) * (dCount - 2.0));
        }

    }
}
