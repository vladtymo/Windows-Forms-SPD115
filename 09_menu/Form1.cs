namespace _09_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OpenFileDialog().ShowDialog();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkModeToolStripMenuItem.Checked)
            {
                // set dark mode
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                // set light mode
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("Searching value of " + toolStripTextBox1.Text);
        }
    }
}