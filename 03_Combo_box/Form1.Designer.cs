namespace _03_Combo_box
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 78);
            this.label2.TabIndex = 4;
            this.label2.Text = "Combo Box";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(928, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddressBtnClick);
            // 
            // countryComboBox
            // 
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Ukraine",
            "Poland",
            "Italy",
            "Germany",
            "Spain",
            "USA"});
            this.countryComboBox.Location = new System.Drawing.Point(257, 168);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(378, 40);
            this.countryComboBox.TabIndex = 6;
            // 
            // cityComboBox
            // 
            this.cityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Kyiv",
            "Lviv",
            "Rivne",
            "Lutsk",
            "Kharkiv",
            "Odessa"});
            this.cityComboBox.Location = new System.Drawing.Point(257, 251);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(378, 40);
            this.cityComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter your city:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "(append mode)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "(suggest and append mode)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(366, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 59);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Binding";
            // 
            // productsComboBox
            // 
            this.productsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(327, 614);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(603, 40);
            this.productsComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Choose product:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 724);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(928, 61);
            this.button2.TabIndex = 14;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 840);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 61);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddProductBtnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 854);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(180, 851);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(455, 39);
            this.nameTxtBox.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 933);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 61);
            this.button4.TabIndex = 18;
            this.button4.Text = "Remove Selected";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveProductBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 1065);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.productsComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox countryComboBox;
        private ComboBox cityComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox productsComboBox;
        private Label label7;
        private Button button2;
        private Button button3;
        private Label label8;
        private TextBox nameTxtBox;
        private Button button4;
    }
}