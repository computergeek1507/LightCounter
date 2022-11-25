
namespace LightCounter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownPixel = new System.Windows.Forms.NumericUpDown();
            this.buttonMinusFifty = new System.Windows.Forms.Button();
            this.buttonMinusTen = new System.Windows.Forms.Button();
            this.buttonMinusOne = new System.Windows.Forms.Button();
            this.buttonPlusFifty = new System.Windows.Forms.Button();
            this.buttonPlusTen = new System.Windows.Forms.Button();
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.videoPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.xModelSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1168, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 20;
            this.logListBox.Location = new System.Drawing.Point(14, 841);
            this.logListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(1140, 124);
            this.logListBox.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(14, 36);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownPixel);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMinusFifty);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMinusTen);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMinusOne);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlusFifty);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlusTen);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlusOne);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.videoPropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1141, 797);
            this.splitContainer1.SplitterDistance = 911;
            this.splitContainer1.SplitterWidth = 11;
            this.splitContainer1.TabIndex = 7;
            // 
            // numericUpDownPixel
            // 
            this.numericUpDownPixel.Location = new System.Drawing.Point(3, 26);
            this.numericUpDownPixel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPixel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPixel.Name = "numericUpDownPixel";
            this.numericUpDownPixel.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPixel.TabIndex = 6;
            this.numericUpDownPixel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPixel.ValueChanged += new System.EventHandler(this.numericUpDownPixel_ValueChanged);
            // 
            // buttonMinusFifty
            // 
            this.buttonMinusFifty.Location = new System.Drawing.Point(359, 59);
            this.buttonMinusFifty.Name = "buttonMinusFifty";
            this.buttonMinusFifty.Size = new System.Drawing.Size(94, 29);
            this.buttonMinusFifty.TabIndex = 5;
            this.buttonMinusFifty.Text = "-50";
            this.buttonMinusFifty.UseVisualStyleBackColor = true;
            this.buttonMinusFifty.Click += new System.EventHandler(this.buttonMinusFifty_Click);
            // 
            // buttonMinusTen
            // 
            this.buttonMinusTen.Location = new System.Drawing.Point(259, 59);
            this.buttonMinusTen.Name = "buttonMinusTen";
            this.buttonMinusTen.Size = new System.Drawing.Size(94, 29);
            this.buttonMinusTen.TabIndex = 4;
            this.buttonMinusTen.Text = "-10";
            this.buttonMinusTen.UseVisualStyleBackColor = true;
            this.buttonMinusTen.Click += new System.EventHandler(this.buttonMinusTen_Click);
            // 
            // buttonMinusOne
            // 
            this.buttonMinusOne.Location = new System.Drawing.Point(159, 59);
            this.buttonMinusOne.Name = "buttonMinusOne";
            this.buttonMinusOne.Size = new System.Drawing.Size(94, 29);
            this.buttonMinusOne.TabIndex = 3;
            this.buttonMinusOne.Text = "-1";
            this.buttonMinusOne.UseVisualStyleBackColor = true;
            this.buttonMinusOne.Click += new System.EventHandler(this.buttonMinusOne_Click);
            // 
            // buttonPlusFifty
            // 
            this.buttonPlusFifty.Location = new System.Drawing.Point(359, 24);
            this.buttonPlusFifty.Name = "buttonPlusFifty";
            this.buttonPlusFifty.Size = new System.Drawing.Size(94, 29);
            this.buttonPlusFifty.TabIndex = 2;
            this.buttonPlusFifty.Text = "+50";
            this.buttonPlusFifty.UseVisualStyleBackColor = true;
            this.buttonPlusFifty.Click += new System.EventHandler(this.buttonPlusFifty_Click);
            // 
            // buttonPlusTen
            // 
            this.buttonPlusTen.Location = new System.Drawing.Point(259, 24);
            this.buttonPlusTen.Name = "buttonPlusTen";
            this.buttonPlusTen.Size = new System.Drawing.Size(94, 29);
            this.buttonPlusTen.TabIndex = 1;
            this.buttonPlusTen.Text = "+10";
            this.buttonPlusTen.UseVisualStyleBackColor = true;
            this.buttonPlusTen.Click += new System.EventHandler(this.buttonPlusTen_Click);
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Location = new System.Drawing.Point(159, 24);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(94, 29);
            this.buttonPlusOne.TabIndex = 0;
            this.buttonPlusOne.Text = "+1";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Click += new System.EventHandler(this.buttonPlusOne_Click);
            // 
            // videoPropertyGrid
            // 
            this.videoPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.videoPropertyGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.videoPropertyGrid.Name = "videoPropertyGrid";
            this.videoPropertyGrid.Size = new System.Drawing.Size(217, 795);
            this.videoPropertyGrid.TabIndex = 4;
            this.videoPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.videoPropertyGrid_PropertyValueChanged);
            // 
            // xModelSaveFileDialog
            // 
            this.xModelSaveFileDialog.DefaultExt = "xmodel";
            this.xModelSaveFileDialog.Filter = "xmodel files (*.xmodel)|*.xmodel|All files (*.*)|*.*";
            this.xModelSaveFileDialog.RestoreDirectory = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 983);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LightCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ListBox logListBox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SaveFileDialog xModelSaveFileDialog;
        private System.Windows.Forms.PropertyGrid videoPropertyGrid;
        private System.Windows.Forms.NumericUpDown numericUpDownPixel;
        private System.Windows.Forms.Button buttonMinusFifty;
        private System.Windows.Forms.Button buttonMinusTen;
        private System.Windows.Forms.Button buttonMinusOne;
        private System.Windows.Forms.Button buttonPlusFifty;
        private System.Windows.Forms.Button buttonPlusTen;
        private System.Windows.Forms.Button buttonPlusOne;
    }
}

