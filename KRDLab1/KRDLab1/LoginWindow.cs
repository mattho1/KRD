using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRDLab1
{
    public partial class LoginWindow : Form
    {
        Menu callingWindow;
        int counterLoginAttempts = 0;
        List<User> userList;
        User user;
        string path = "users.xml";
        public LoginWindow(Menu _callingWindow)
        {
            callingWindow = _callingWindow;
            InitializeComponent();
            userList = new List<User>();
            loadUsers();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (validation()){
                callingWindow.Enabled = true;
                callingWindow.setUserRole(user.role);
                this.Close();
            }
            else
            {
                counterLoginAttempts++;
                string text = "Niepoprawne dane logowania. Pozostało " + (3 - counterLoginAttempts) + " prób logowania.";
                MessageBox.Show(text);
                if (counterLoginAttempts==3)
                {
                    Environment.Exit(0);
                }
            }
        }
        private bool validation()
        {
            foreach (var user in userList)
            {
                if (textBoxLogin.Text.Equals(user.login) && textBoxPassword.Text.Equals(user.password))
                {
                    this.user = user;
                    return true;
                }
            }
            return false;
        }
        private bool validationClient()
        {
            foreach (var client in userList)
            {
                if (textBoxLogin.Text.Equals(client.surname) && textBoxPassword.Text.Equals(client.password))
                {
                    return true;
                }
            }
            return false;
        }
        private void buttonSearchStatusPackage_Click(object sender, EventArgs e)
        {
            if(!textBoxLogin.Text.Equals("") && !textBoxPassword.Text.Equals(""))
            {
                if (validationClient())
                {
                    ShowPackages windowShowPackages = new ShowPackages(getCustomerId());
                    this.Visible = false;                    
                    windowShowPackages.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Niepoprawne dane logowania.");
                }
            }else
            {
                MessageBox.Show("Podaj Login (swoje nazwisko) i Hasło.");
            }
        }

        private int getCustomerId()
        {
            return userList.Where(u => u.password == textBoxPassword.Text && u.surname == textBoxLogin.Text).First().id;
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!validation())
            {
                Environment.Exit(0);
            }
        }

        private void loadUsers()
        {
            Users uss = ManageUsers.ReadListUsers(path);
            if (uss != null)
            {
                userList = uss.users;
            }
        }
    }
}
