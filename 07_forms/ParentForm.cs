using Microsoft.VisualBasic.ApplicationServices;

namespace _07_forms
{
    public partial class ParentForm : Form
    {
        private List<User> users = new List<User>();
        public ParentForm()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginTb.Text;

            // -------- create form instance
            //ChildForm form = new ChildForm();

            // -------- transfering data from parent to child
            // 1 - using constructor
            ChildForm form = new ChildForm(login);
            // 2 - using property
            form.Text = $"Your login is {login}";
            // 3 - using method
            form.SetDarkTheme();

            // -------- show form window
            // show using nonmodal mode
            form.Show();
            // show using modal mode
            //form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();

            var result = form.ShowDialog();

            // -------- transfering data from child to parent
            // 1 - using property
            if (result == DialogResult.OK)
            {
                users.Add(form.User);
                UpdateList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Clear();
            UpdateList();
        }
    }
}