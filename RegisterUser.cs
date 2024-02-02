using MusicLibrary.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class RegisterUser : Form
    {
        private UserManager userManager;
        public RegisterUser(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            userManager.AddUser("admin", "admin");
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            
            userManager.AddUser(username, password);
            MessageBox.Show("Registration successful!");
            Close();
        }
    }
}
