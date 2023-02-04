namespace _02_Common_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowBtnClick(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show($"Enter a valid email!");
            }
            else
            {
                MessageBox.Show($"Your email is {email}!");
            }

            MessageBox.Show($"Your Bio: {bioTxtBox.Text}");

            MessageBox.Show($"Your phone: {maskedTextBox1.Text}");

            MessageBox.Show($"Your date: {dateTimePicker1.Value}");

            MessageBox.Show($"Your number: {numericUpDown1.Value}");

            if (economRadioBtn.Checked)
                MessageBox.Show("Selected type is ecomon!");
            else if (standartRadioBtn.Checked)
                MessageBox.Show("Selected type is standart!");
            else if (comfortRadioBtn.Checked)
                MessageBox.Show("Selected type is comfort!");

            if (checkBox1.Checked)
                MessageBox.Show("Policy is accepted!");
            else
                MessageBox.Show("Policy is not accepted!");
        }
    }
}