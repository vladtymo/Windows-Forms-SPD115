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
    public partial class ChildForm : Form
    {
        public ChildForm() : this("-") { }
        public ChildForm(string login)
        {
            InitializeComponent();

            congratLb.Text += login;
        }

        public void SetDarkTheme()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
