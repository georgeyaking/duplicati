namespace Duplicati.GUI.HelperControls
{
    partial class FilterEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterEditor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddFilterButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveFilterButton = new System.Windows.Forms.ToolStripButton();
            this.EditFilterButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveFilterUpButton = new System.Windows.Forms.ToolStripButton();
            this.MoveFilterDownButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveFilterTopButton = new System.Windows.Forms.ToolStripButton();
            this.MoveFilterBottomButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FilenameTester = new System.Windows.Forms.TextBox();
            this.TestResults = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.Location = new System.Drawing.Point(3, 41);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(498, 164);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 420;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Inclusion.ico");
            this.imageList1.Images.SetKeyName(1, "Exclusion.ico");
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFilterButton,
            this.RemoveFilterButton,
            this.EditFilterButton,
            this.toolStripSeparator1,
            this.MoveFilterUpButton,
            this.MoveFilterDownButton,
            this.toolStripSeparator2,
            this.MoveFilterTopButton,
            this.MoveFilterBottomButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddFilterButton
            // 
            this.AddFilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFilterButton.Image")));
            this.AddFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFilterButton.Name = "AddFilterButton";
            this.AddFilterButton.Size = new System.Drawing.Size(23, 22);
            this.AddFilterButton.Text = "toolStripButton1";
            this.AddFilterButton.ToolTipText = "Add a new filter";
            this.AddFilterButton.Click += new System.EventHandler(this.AddFilterButton_Click);
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveFilterButton.Enabled = false;
            this.RemoveFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveFilterButton.Image")));
            this.RemoveFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveFilterButton.Text = "toolStripButton2";
            this.RemoveFilterButton.ToolTipText = "Remove the selected filter";
            this.RemoveFilterButton.Click += new System.EventHandler(this.RemoveFilterButton_Click);
            // 
            // EditFilterButton
            // 
            this.EditFilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditFilterButton.Enabled = false;
            this.EditFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("EditFilterButton.Image")));
            this.EditFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditFilterButton.Name = "EditFilterButton";
            this.EditFilterButton.Size = new System.Drawing.Size(23, 22);
            this.EditFilterButton.Text = "toolStripButton1";
            this.EditFilterButton.ToolTipText = "Edit the selected filter";
            this.EditFilterButton.Click += new System.EventHandler(this.EditFilterButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveFilterUpButton
            // 
            this.MoveFilterUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFilterUpButton.Enabled = false;
            this.MoveFilterUpButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveFilterUpButton.Image")));
            this.MoveFilterUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveFilterUpButton.Name = "MoveFilterUpButton";
            this.MoveFilterUpButton.Size = new System.Drawing.Size(23, 22);
            this.MoveFilterUpButton.Text = "toolStripButton3";
            this.MoveFilterUpButton.ToolTipText = "Move the selected filter up";
            this.MoveFilterUpButton.Click += new System.EventHandler(this.MoveFilterUpButton_Click);
            // 
            // MoveFilterDownButton
            // 
            this.MoveFilterDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFilterDownButton.Enabled = false;
            this.MoveFilterDownButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveFilterDownButton.Image")));
            this.MoveFilterDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveFilterDownButton.Name = "MoveFilterDownButton";
            this.MoveFilterDownButton.Size = new System.Drawing.Size(23, 22);
            this.MoveFilterDownButton.Text = "toolStripButton4";
            this.MoveFilterDownButton.ToolTipText = "Move the selected filter down";
            this.MoveFilterDownButton.Click += new System.EventHandler(this.MoveFilterDownButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveFilterTopButton
            // 
            this.MoveFilterTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFilterTopButton.Enabled = false;
            this.MoveFilterTopButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveFilterTopButton.Image")));
            this.MoveFilterTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveFilterTopButton.Name = "MoveFilterTopButton";
            this.MoveFilterTopButton.Size = new System.Drawing.Size(23, 22);
            this.MoveFilterTopButton.Text = "toolStripButton5";
            this.MoveFilterTopButton.ToolTipText = "Move the selected filter to the top";
            this.MoveFilterTopButton.Click += new System.EventHandler(this.MoveFilterTopButton_Click);
            // 
            // MoveFilterBottomButton
            // 
            this.MoveFilterBottomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFilterBottomButton.Enabled = false;
            this.MoveFilterBottomButton.Image = ((System.Drawing.Image)(resources.GetObject("MoveFilterBottomButton.Image")));
            this.MoveFilterBottomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveFilterBottomButton.Name = "MoveFilterBottomButton";
            this.MoveFilterBottomButton.Size = new System.Drawing.Size(23, 22);
            this.MoveFilterBottomButton.Text = "toolStripButton6";
            this.MoveFilterBottomButton.ToolTipText = "Move the selected filter to the bottom";
            this.MoveFilterBottomButton.Click += new System.EventHandler(this.MoveFilterBottomButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test a filename";
            // 
            // FilenameTester
            // 
            this.FilenameTester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FilenameTester.Location = new System.Drawing.Point(96, 216);
            this.FilenameTester.Name = "FilenameTester";
            this.FilenameTester.Size = new System.Drawing.Size(376, 20);
            this.FilenameTester.TabIndex = 3;
            this.FilenameTester.TextChanged += new System.EventHandler(this.FilenameTester_TextChanged);
            // 
            // TestResults
            // 
            this.TestResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TestResults.Location = new System.Drawing.Point(480, 216);
            this.TestResults.Name = "TestResults";
            this.TestResults.Size = new System.Drawing.Size(16, 16);
            this.TestResults.TabIndex = 4;
            this.TestResults.TabStop = false;
            // 
            // FilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TestResults);
            this.Controls.Add(this.FilenameTester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilterEditor";
            this.Size = new System.Drawing.Size(506, 242);
            this.Load += new System.EventHandler(this.FilterEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddFilterButton;
        private System.Windows.Forms.ToolStripButton RemoveFilterButton;
        private System.Windows.Forms.ToolStripButton EditFilterButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton MoveFilterUpButton;
        private System.Windows.Forms.ToolStripButton MoveFilterDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton MoveFilterTopButton;
        private System.Windows.Forms.ToolStripButton MoveFilterBottomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilenameTester;
        private System.Windows.Forms.PictureBox TestResults;
    }
}