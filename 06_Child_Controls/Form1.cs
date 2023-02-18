namespace _06_Child_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtnClick(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.Text = counter++.ToString();
            } 
        }
    }
}