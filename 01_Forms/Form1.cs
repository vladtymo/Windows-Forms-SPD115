using System.Windows.Forms;

namespace _01_Forms
{
    public partial class Form1 : Form
    {
        // properties
        public bool IsDarkMode { get; set; } = false;

        public Form1()
        {
            InitializeComponent();

            //Text = "My BlaBla Form";
            //BackColor = Color.LightCoral;
            //ForeColor = Color.Black;

            //Button button1 = new Button()
            //{
            //    Width = 300,
            //    Height = 120,
            //    Text = "Push Me!",
            //    BackColor = Color.White
            //};

            //button1.Click += PushMeBtnClick;

            //this.Controls.Add(button1);
        }

        // methods

        private void PushMeBtnClick(object? sender, EventArgs e)
        {
            this.Text = "Button clicked!";

            MessageBox.Show("Hello from Message Box!");

            var result = MessageBox.Show("Do you want to change color theme?", 
                                         "Color Theme",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                IsDarkMode = !IsDarkMode;

                this.BackColor = IsDarkMode ? Color.Black : Color.White;
                this.ForeColor = IsDarkMode ? Color.White : Color.Black;
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}