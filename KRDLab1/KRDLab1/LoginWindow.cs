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
        public LoginWindow(Menu _callingWindow)
        {
            callingWindow = _callingWindow;
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (validation()){
                callingWindow.Enabled = true;
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
            if (textBoxLogin.Text.Equals("")&&textBoxPassword.Text.Equals(""))  // zmienic na czytanie z pliku a nie hardcode 
            {
                return true;
            }
            return false;
        }

        private void buttonSearchStatusPackage_Click(object sender, EventArgs e)
        {
            //if(!textBoxLogin.Text.Equals("") && !textBoxPassword.Text.Equals(""))
            if (textBoxLogin.Text.Equals("") && textBoxPassword.Text.Equals(""))
            {
                if (validation())
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
            return 1;
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!validation())
            {
                Environment.Exit(0);
            }
        }
    }
}
