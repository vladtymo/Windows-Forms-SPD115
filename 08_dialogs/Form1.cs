namespace _08_dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextColorBtnClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = dialog.Color;
            }
        }

        private void TextFontBtnClick(object sender, EventArgs e)
        {
            FontDialog dialog = new();

            dialog.Font = textBox1.Font;

            if(dialog.ShowDialog() == DialogResult.OK)
                textBox1.Font = dialog.Font;
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            string content = textBox1.Text;

            SaveFileDialog dialog = new();

            // set dialog properties
            dialog.CreatePrompt = true;
            dialog.DefaultExt = ".txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // FileName - selected file path
                File.WriteAllText(dialog.FileName, content);
            }
        }

        private void OpenBtnClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "All Files|*.*|Text Files|*.txt",
                FilterIndex = 2
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(dialog.FileName);
                textBox1.Text = content;
            }
        }

        private void PrintBtnClick(object sender, EventArgs e)
        {
            PrintDialog dialog = new();
            dialog.ShowDialog();
        }

        private void OpenFolderBtnClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // get selected folder path
                string path = dialog.SelectedPath;

                DirectoryInfo directory = new(path);

                checkedListBox1.Items.Clear();
                foreach (var file in directory.GetFiles())
                {
                    checkedListBox1.Items.Add(file.Name);
                } 
            }
        }
    }
}