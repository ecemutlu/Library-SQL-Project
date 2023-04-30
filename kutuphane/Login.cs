using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphane.Helpers;
using kutuphane.Models;

namespace kutuphane
{
    public partial class Login : Form
    {
        internal User? User { get; } = new User();
         

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (User == null)
                return;
            {
                User.username = textBox1.Text;
                User.password = textBox2.Text;
            }

        }
        private User? ReadUserCode(string username,string password) {
            var user = Author_Publisher_UserHelper.ReadUser(username);
            if (user == null)
                return null;
            if (user.password == textBox2.Text)
            {
                return user;
            }
            return null;
        } 

        private void bt_login_Click(object sender, EventArgs e)
        {
            var success = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("THE USERNAME FIELD CANNOT BE EMPTY");
                success = false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("THE PASSWORD FIELD CANNOT BE EMPTY");
                success = false;
            }

            if (success)
            {
                var user = ReadUserCode(textBox1.Text, textBox2.Text);
                Global.User = user;
                success = user != null;
            }

            if (success)
            {               
                this.Hide();
                var main = new MainForm
                {
                    Owner = this
                };
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("THE USERNAME OR PASSWORD NOT VALID");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
