﻿namespace QPerfMon
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c2DPushGraphControl = new HenIT.Windows.Controls.C2DPushGraph.Graphing.C2DPushGraph();
            this.lvwCounters = new ListViewR();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderScale = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStripLvw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStripGraph = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripLvw.SuspendLayout();
            this.contextMenuStripGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c2DPushGraphControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwCounters);
            this.splitContainer1.Size = new System.Drawing.Size(586, 444);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 1;
            // 
            // c2DPushGraphControl
            // 
            this.c2DPushGraphControl.AutoAdjustPeek = true;
            this.c2DPushGraphControl.AutoGridSize = true;
            this.c2DPushGraphControl.BackColor = System.Drawing.Color.Black;
            this.c2DPushGraphControl.ContextMenuStrip = this.contextMenuStripGraph;
            this.c2DPushGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c2DPushGraphControl.GridColor = System.Drawing.Color.DarkGreen;
            this.c2DPushGraphControl.GridSize = ((ushort)(20));
            this.c2DPushGraphControl.HighQuality = true;
            this.c2DPushGraphControl.LineInterval = ((ushort)(5));
            this.c2DPushGraphControl.Location = new System.Drawing.Point(0, 0);
            this.c2DPushGraphControl.MaxLabel = "100";
            this.c2DPushGraphControl.MaxPeekMagnitude = 100;
            this.c2DPushGraphControl.MinLabel = "0";
            this.c2DPushGraphControl.MinPeekMagnitude = 0;
            this.c2DPushGraphControl.Name = "c2DPushGraphControl";
            this.c2DPushGraphControl.ShowGrid = true;
            this.c2DPushGraphControl.ShowLabels = true;
            this.c2DPushGraphControl.Size = new System.Drawing.Size(586, 329);
            this.c2DPushGraphControl.TabIndex = 0;
            this.c2DPushGraphControl.Text = "c2DPushGraph1";
            this.c2DPushGraphControl.TextColor = System.Drawing.Color.Yellow;
            // 
            // lvwCounters
            // 
            this.lvwCounters.CheckBoxes = true;
            this.lvwCounters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeaderScale,
            this.columnHeader3});
            this.lvwCounters.ContextMenuStrip = this.contextMenuStripLvw;
            this.lvwCounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCounters.HideSelection = false;
            this.lvwCounters.Location = new System.Drawing.Point(0, 0);
            this.lvwCounters.Name = "lvwCounters";
            this.lvwCounters.Size = new System.Drawing.Size(586, 111);
            this.lvwCounters.TabIndex = 0;
            this.lvwCounters.UseCompatibleStateImageBehavior = false;
            this.lvwCounters.View = System.Windows.Forms.View.Details;
            this.lvwCounters.Resize += new System.EventHandler(this.lvwCounters_Resize);
            this.lvwCounters.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwCounters_ItemChecked);
            this.lvwCounters.SelectedIndexChanged += new System.EventHandler(this.lvwCounters_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Performance counter";
            this.columnHeader1.Width = 368;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color";
            // 
            // columnHeaderScale
            // 
            this.columnHeaderScale.Text = "Scale";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last value";
            this.columnHeader3.Width = 65;
            // 
            // contextMenuStripLvw
            // 
            this.contextMenuStripLvw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visibleToolStripMenuItem,
            this.toolStripSeparator1,
            this.formattingToolStripMenuItem});
            this.contextMenuStripLvw.Name = "contextMenuStrip1";
            this.contextMenuStripLvw.Size = new System.Drawing.Size(140, 54);
            // 
            // visibleToolStripMenuItem
            // 
            this.visibleToolStripMenuItem.Checked = true;
            this.visibleToolStripMenuItem.CheckOnClick = true;
            this.visibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.visibleToolStripMenuItem.Name = "visibleToolStripMenuItem";
            this.visibleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.visibleToolStripMenuItem.Text = "Visible";
            this.visibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.visibleToolStripMenuItem_CheckedChanged);
            // 
            // formattingToolStripMenuItem
            // 
            this.formattingToolStripMenuItem.Name = "formattingToolStripMenuItem";
            this.formattingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.formattingToolStripMenuItem.Text = "Formatting";
            this.formattingToolStripMenuItem.Click += new System.EventHandler(this.formattingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // contextMenuStripGraph
            // 
            this.contextMenuStripGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem});
            this.contextMenuStripGraph.Name = "contextMenuStripGraph";
            this.contextMenuStripGraph.Size = new System.Drawing.Size(111, 26);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.CheckOnClick = true;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pauseToolStripMenuItem_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 444);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Text = "Quick performance counter viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripLvw.ResumeLayout(false);
            this.contextMenuStripGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HenIT.Windows.Controls.C2DPushGraph.Graphing.C2DPushGraph c2DPushGraphControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvwCounters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeaderScale;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLvw;
        private System.Windows.Forms.ToolStripMenuItem visibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGraph;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
    }
}

