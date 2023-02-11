namespace _04_List_box
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
            this.colorList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorList
            // 
            this.colorList.FormattingEnabled = true;
            this.colorList.ItemHeight = 32;
            this.colorList.Items.AddRange(new object[] {
            "Brown",
            "Grey",
            "Green",
            "Yellow",
            "Cyan",
            "Magenta",
            "Pink",
            "Red",
            "Black"});
            this.colorList.Location = new System.Drawing.Point(72, 149);
            this.colorList.Name = "colorList";
            this.colorList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.colorList.Size = new System.Drawing.Size(803, 548);
            this.colorList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(369, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 78);
            this.label2.TabIndex = 5;
            this.label2.Text = "List Box";
            // 
            // colorTxtBox
            // 
            this.colorTxtBox.Location = new System.Drawing.Point(161, 782);
            this.colorTxtBox.Name = "colorTxtBox";
            this.colorTxtBox.Size = new System.Drawing.Size(440, 39);
            this.colorTxtBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 782);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Color:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 771);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 61);
            this.button3.TabIndex = 18;
            this.button3.Text = "Add New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 890);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(803, 61);
            this.button2.TabIndex = 21;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 1138);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.colorTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox colorList;
        private Label label2;
        private TextBox colorTxtBox;
        private Label label8;
        private Button button3;
        private Button button2;
    }
}