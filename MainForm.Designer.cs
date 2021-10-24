namespace Magic.Samples.DisplaySettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modesListView = new System.Windows.Forms.ListView();
            this.idxColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.widthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heightColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orientColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.freqColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.freqLabel = new System.Windows.Forms.Label();
            this.bitsLabel = new System.Windows.Forms.Label();
            this.orientationLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.rotateAntiClockwiseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rotateClockwiseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.modesListView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supported Display Settings";
            // 
            // modesListView
            // 
            this.modesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idxColumnHeader,
            this.widthColumnHeader,
            this.heightColumnHeader,
            this.orientColumnHeader,
            this.bitsColumnHeader,
            this.freqColumnHeader});
            this.modesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modesListView.FullRowSelect = true;
            this.modesListView.GridLines = true;
            this.modesListView.HideSelection = false;
            this.modesListView.Location = new System.Drawing.Point(3, 16);
            this.modesListView.Name = "modesListView";
            this.modesListView.ShowItemToolTips = true;
            this.modesListView.Size = new System.Drawing.Size(381, 244);
            this.modesListView.TabIndex = 2;
            this.modesListView.UseCompatibleStateImageBehavior = false;
            this.modesListView.View = System.Windows.Forms.View.Details;
            this.modesListView.DoubleClick += new System.EventHandler(this.modesListView_DoubleClick);
            // 
            // idxColumnHeader
            // 
            this.idxColumnHeader.Text = "Idx";
            this.idxColumnHeader.Width = 30;
            // 
            // widthColumnHeader
            // 
            this.widthColumnHeader.Text = "Width";
            // 
            // heightColumnHeader
            // 
            this.heightColumnHeader.Text = "Height";
            // 
            // orientColumnHeader
            // 
            this.orientColumnHeader.Text = "Orientation";
            this.orientColumnHeader.Width = 70;
            // 
            // bitsColumnHeader
            // 
            this.bitsColumnHeader.Text = "Bits Count";
            this.bitsColumnHeader.Width = 70;
            // 
            // freqColumnHeader
            // 
            this.freqColumnHeader.Text = "Frequency";
            this.freqColumnHeader.Width = 70;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double-click the mode to switch to its settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(405, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Display Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.freqLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bitsLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.orientationLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.widthLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotateAntiClockwiseButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotateClockwiseButton, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resetButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.resetButton, 2);
            this.resetButton.Location = new System.Drawing.Point(2, 233);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(165, 21);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset Settings";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqLabel.Location = new System.Drawing.Point(70, 132);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(96, 33);
            this.freqLabel.TabIndex = 12;
            this.freqLabel.Text = "xxx";
            this.freqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bitsLabel
            // 
            this.bitsLabel.AutoSize = true;
            this.bitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bitsLabel.Location = new System.Drawing.Point(70, 99);
            this.bitsLabel.Name = "bitsLabel";
            this.bitsLabel.Size = new System.Drawing.Size(96, 33);
            this.bitsLabel.TabIndex = 11;
            this.bitsLabel.Text = "xxx";
            this.bitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orientationLabel
            // 
            this.orientationLabel.AutoSize = true;
            this.orientationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orientationLabel.Location = new System.Drawing.Point(70, 66);
            this.orientationLabel.Name = "orientationLabel";
            this.orientationLabel.Size = new System.Drawing.Size(96, 33);
            this.orientationLabel.TabIndex = 10;
            this.orientationLabel.Text = "xxx";
            this.orientationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightLabel.Location = new System.Drawing.Point(70, 33);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(96, 33);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "xxx";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthLabel.Location = new System.Drawing.Point(70, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(96, 33);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "xxx";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rotateAntiClockwiseButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rotateAntiClockwiseButton, 2);
            this.rotateAntiClockwiseButton.Location = new System.Drawing.Point(2, 200);
            this.rotateAntiClockwiseButton.Margin = new System.Windows.Forms.Padding(2);
            this.rotateAntiClockwiseButton.Name = "rotateAntiClockwiseButton";
            this.rotateAntiClockwiseButton.Size = new System.Drawing.Size(165, 21);
            this.rotateAntiClockwiseButton.TabIndex = 7;
            this.rotateAntiClockwiseButton.Text = "Rotate anti-clockwise";
            this.rotateAntiClockwiseButton.UseVisualStyleBackColor = true;
            this.rotateAntiClockwiseButton.Click += new System.EventHandler(this.rotateAntiClockwiseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Frequency:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Orientation:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bits Count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rotateClockwiseButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rotateClockwiseButton, 2);
            this.rotateClockwiseButton.Location = new System.Drawing.Point(2, 167);
            this.rotateClockwiseButton.Margin = new System.Windows.Forms.Padding(2);
            this.rotateClockwiseButton.Name = "rotateClockwiseButton";
            this.rotateClockwiseButton.Size = new System.Drawing.Size(165, 21);
            this.rotateClockwiseButton.TabIndex = 6;
            this.rotateClockwiseButton.Text = "Rotate clockwise";
            this.rotateClockwiseButton.UseVisualStyleBackColor = true;
            this.rotateClockwiseButton.Click += new System.EventHandler(this.rotateClockwiseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView modesListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rotateClockwiseButton;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.Label bitsLabel;
        private System.Windows.Forms.Label orientationLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.ColumnHeader idxColumnHeader;
        private System.Windows.Forms.ColumnHeader widthColumnHeader;
        private System.Windows.Forms.ColumnHeader heightColumnHeader;
        private System.Windows.Forms.ColumnHeader orientColumnHeader;
        private System.Windows.Forms.ColumnHeader bitsColumnHeader;
        private System.Windows.Forms.ColumnHeader freqColumnHeader;
        private System.Windows.Forms.Button rotateAntiClockwiseButton;
        private System.Windows.Forms.Button resetButton;
    }
}

