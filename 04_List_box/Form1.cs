using System.Text;

namespace _04_List_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInputs()
        {
            colorTxtBox.Clear();
        }

        private void AddBtnClick(object sender, EventArgs e)
        {
            string color = colorTxtBox.Text;

            if (string.IsNullOrWhiteSpace(color))
            {
                MessageBox.Show("Enter a valid color!"); return;
            }

            // check dublicate
            if (colorList.Items.Contains(color))
            {
                MessageBox.Show($"Color {color} is already exists!"); return;
            }

            colorList.Items.Add(color);

            ClearInputs();
        }

        private void ShowBtnClick(object sender, EventArgs e)
        {
            if (colorList.SelectedItem == null)
            {
                MessageBox.Show("Select at least one item!"); return;
            }

            StringBuilder result = new("Selected colors:\n");

            foreach (var item in colorList.SelectedItems)
            {
                result.AppendLine(item.ToString());
            }

            MessageBox.Show(result.ToString());
        }
    }
}