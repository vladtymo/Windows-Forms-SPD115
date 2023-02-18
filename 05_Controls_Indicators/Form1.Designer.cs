namespace _05_Controls_Indicators
{
    partial class Form1
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
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.maxLenNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fontSizeSlider = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lenLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTextBox.Location = new System.Drawing.Point(12, 188);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(1435, 578);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.MainTextChanged);
            // 
            // maxLenNumeric
            // 
            this.maxLenNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxLenNumeric.Location = new System.Drawing.Point(17, 38);
            this.maxLenNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxLenNumeric.Name = "maxLenNumeric";
            this.maxLenNumeric.Size = new System.Drawing.Size(278, 39);
            this.maxLenNumeric.TabIndex = 1;
            this.maxLenNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxLenNumeric.ValueChanged += new System.EventHandler(this.MaxLenNumericChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 2;
            // 
            // fontSizeSlider
            // 
            this.fontSizeSlider.Location = new System.Drawing.Point(6, 51);
            this.fontSizeSlider.Maximum = 120;
            this.fontSizeSlider.Minimum = 1;
            this.fontSizeSlider.Name = "fontSizeSlider";
            this.fontSizeSlider.Size = new System.Drawing.Size(388, 90);
            this.fontSizeSlider.TabIndex = 3;
            this.fontSizeSlider.TickFrequency = 10;
            this.fontSizeSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.fontSizeSlider.Value = 11;
            this.fontSizeSlider.ValueChanged += new System.EventHandler(this.FontSizeSliderChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 46);
            this.progressBar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontSizeSlider);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxLenNumeric);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(1047, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lenght";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lenLabel,
            this.toolStripStatusLabel2,
            this.linesLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 764);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1459, 42);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 32);
            this.toolStripStatusLabel1.Text = "Symbols:";
            // 
            // lenLabel
            // 
            this.lenLabel.Name = "lenLabel";
            this.lenLabel.Size = new System.Drawing.Size(27, 32);
            this.lenLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(602, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 72);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text Editor";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 32);
            this.toolStripStatusLabel2.Text = "| Lines:";
            // 
            // linesLabel
            // 
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(27, 32);
            this.linesLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 806);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.maxLenNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox mainTextBox;
        private NumericUpDown maxLenNumeric;
        private Label label1;
        private TrackBar fontSizeSlider;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lenLabel;
        private Label label2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel linesLabel;
    }
}