namespace _07_forms
{
    partial class UserForm
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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(139, 199);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(577, 39);
            this.nameTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 114);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Form";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(139, 271);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(577, 39);
            this.loginTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login:";
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(139, 354);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '•';
            this.passTb.Size = new System.Drawing.Size(577, 39);
            this.passTb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 65);
            this.button2.TabIndex = 12;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(783, 580);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTb;
        private Label label2;
        private Label label1;
        private TextBox loginTb;
        private Label label3;
        private TextBox passTb;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}