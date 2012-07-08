namespace HeidersBalancer {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.Windows.Forms.ToolStripLabel toolStripLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboBoxLayout = new System.Windows.Forms.ToolStripComboBox();
            this.PositiveButton = new System.Windows.Forms.ToolStripButton();
            this.NegativeButton = new System.Windows.Forms.ToolStripButton();
            this.NeutralButton = new System.Windows.Forms.ToolStripButton();
            this.NoneButton = new System.Windows.Forms.ToolStripButton();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.GenerateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateWithGifOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRender = new System.Windows.Forms.ToolStripButton();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(56, 25);
            toolStripLabel1.Text = "Layout:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picGraph);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1045, 692);
            this.splitContainer1.SplitterDistance = 506;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 55);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Panel2.Controls.Add(this.listView2);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(506, 637);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(249, 637);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Value";
            this.columnHeader1.Width = 190;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PositiveButton,
            this.NegativeButton,
            this.NeutralButton,
            this.NoneButton});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(253, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(253, 637);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 190;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.OpenButton,
            this.SaveButton,
            this.toolStripSeparator1,
            this.AddButton,
            this.AddTextBox,
            this.toolStripSeparator2,
            this.DeleteButton,
            this.GenerateButton,
            this.toolStripSplitButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(506, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripLabel1,
            this.comboBoxLayout,
            this.btnRender});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(506, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboBoxLayout
            // 
            this.comboBoxLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLayout.Items.AddRange(new object[] {
            "dot",
            "neato",
            "fdp",
            "twopi",
            "circo"});
            this.comboBoxLayout.Name = "comboBoxLayout";
            this.comboBoxLayout.Size = new System.Drawing.Size(160, 28);
            // 
            // PositiveButton
            // 
            this.PositiveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PositiveButton.Image = global::HeidersBalancer.Properties.Resources.positive;
            this.PositiveButton.ImageTransparentColor = System.Drawing.Color.White;
            this.PositiveButton.Name = "PositiveButton";
            this.PositiveButton.Size = new System.Drawing.Size(23, 22);
            this.PositiveButton.Text = "Positive";
            this.PositiveButton.Click += new System.EventHandler(this.PositiveButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NegativeButton.Image = global::HeidersBalancer.Properties.Resources.negative;
            this.NegativeButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(23, 22);
            this.NegativeButton.Text = "Negative";
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // NeutralButton
            // 
            this.NeutralButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NeutralButton.Image = global::HeidersBalancer.Properties.Resources.neutral;
            this.NeutralButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NeutralButton.Name = "NeutralButton";
            this.NeutralButton.Size = new System.Drawing.Size(23, 22);
            this.NeutralButton.Text = "Neutral";
            this.NeutralButton.Click += new System.EventHandler(this.NeutralButton_Click);
            // 
            // NoneButton
            // 
            this.NoneButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NoneButton.Image = global::HeidersBalancer.Properties.Resources.None;
            this.NoneButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(23, 22);
            this.NoneButton.Text = "None";
            this.NoneButton.Click += new System.EventHandler(this.NoneButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = global::HeidersBalancer.Properties.Resources._new;
            this.NewButton.ImageTransparentColor = System.Drawing.Color.White;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(23, 24);
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = global::HeidersBalancer.Properties.Resources.open;
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.White;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(23, 24);
            this.OpenButton.Text = "Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = global::HeidersBalancer.Properties.Resources.save;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.White;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 24);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Image = global::HeidersBalancer.Properties.Resources.plus;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.White;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 24);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::HeidersBalancer.Properties.Resources.minus;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 24);
            this.DeleteButton.Text = "Remove";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Image = global::HeidersBalancer.Properties.Resources.rightarrow;
            this.GenerateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(89, 24);
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.calculateWithGifOutputToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::HeidersBalancer.Properties.Resources.calculate;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(102, 24);
            this.toolStripSplitButton1.Text = "Calculate";
            this.toolStripSplitButton1.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Image = global::HeidersBalancer.Properties.Resources.calculate;
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // calculateWithGifOutputToolStripMenuItem
            // 
            this.calculateWithGifOutputToolStripMenuItem.Image = global::HeidersBalancer.Properties.Resources.calculateimg;
            this.calculateWithGifOutputToolStripMenuItem.Name = "calculateWithGifOutputToolStripMenuItem";
            this.calculateWithGifOutputToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.calculateWithGifOutputToolStripMenuItem.Text = "Calculate with gif output";
            this.calculateWithGifOutputToolStripMenuItem.Click += new System.EventHandler(this.calculateWithGifOutputToolStripMenuItem_Click);
            // 
            // btnRender
            // 
            this.btnRender.Image = global::HeidersBalancer.Properties.Resources.render;
            this.btnRender.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(76, 25);
            this.btnRender.Text = "Render";
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // picGraph
            // 
            this.picGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGraph.Location = new System.Drawing.Point(0, 0);
            this.picGraph.Margin = new System.Windows.Forms.Padding(4);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(534, 692);
            this.picGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGraph.TabIndex = 0;
            this.picGraph.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Heiders Balancer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripComboBox comboBoxLayout;
        private System.Windows.Forms.ToolStripButton btnRender;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox AddTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton PositiveButton;
        private System.Windows.Forms.ToolStripButton NegativeButton;
        private System.Windows.Forms.ToolStripButton NeutralButton;
        private System.Windows.Forms.ToolStripButton GenerateButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateWithGifOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton NoneButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}

