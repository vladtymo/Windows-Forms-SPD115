namespace _07_forms
{
    partial class ParentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parent Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(858, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Child Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(329, 245);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(345, 39);
            this.loginTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(389, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "Users";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(36, 519);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(856, 260);
            this.listBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 810);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add New User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 810);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(353, 61);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(925, 903);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ParentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox loginTb;
        private Label label3;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}