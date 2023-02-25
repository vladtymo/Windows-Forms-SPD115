namespace _07_forms
{
    partial class ChildForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.congratLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(209, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close Itself";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 114);
            this.label1.TabIndex = 2;
            this.label1.Text = "Child Form";
            // 
            // congratLb
            // 
            this.congratLb.AutoSize = true;
            this.congratLb.Location = new System.Drawing.Point(261, 206);
            this.congratLb.Name = "congratLb";
            this.congratLb.Size = new System.Drawing.Size(82, 32);
            this.congratLb.TabIndex = 4;
            this.congratLb.Text = "Hello, ";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.congratLb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label congratLb;
    }
}