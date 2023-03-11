namespace _10_rich_text
{
    public partial class Form1 : Form
    {
        TimeSpan currentTimer = new TimeSpan();
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.LightCyan;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new();

            dialog.Font = richTextBox1.SelectionFont;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dialog.Font;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // TODO: use SaveFileDialog
            richTextBox1.SaveFile("text.rtf");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // TODO: use OpenFileDialog
            richTextBox1.LoadFile("text.rtf");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimer = currentTimer.Add(new TimeSpan(0, 0, 1));
            statusTimer.Text = currentTimer.ToString("mm\\:ss");
        }
    }
}