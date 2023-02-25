using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_forms
{
    public partial class UserForm : Form
    {
        public User User { get; set; }
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User = new User()
            {
                Name = nameTb.Text,
                Login = loginTb.Text,
                Password = passTb.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
