namespace _05_Controls_Indicators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaxLenNumericChanged(object sender, EventArgs e)
        {
            mainTextBox.MaxLength = (int)maxLenNumeric.Value;
            progressBar1.Maximum = (int)maxLenNumeric.Value;
        }

        private void FontSizeSliderChanged(object sender, EventArgs e)
        {
            mainTextBox.Font = new Font(mainTextBox.Font.FontFamily, fontSizeSlider.Value);
        }

        private void MainTextChanged(object sender, EventArgs e)
        {
            if (mainTextBox.TextLength <= progressBar1.Maximum)
                progressBar1.Value = mainTextBox.TextLength;

            lenLabel.Text = mainTextBox.TextLength.ToString();

            linesLabel.Text = mainTextBox.Lines.Length.ToString();
        }
    }
}