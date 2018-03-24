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
            setHints();
        }
        private void setHints()
        {
            System.Windows.Forms.ToolTip yourToolTip = new ToolTip();
            //The below are optional, of course,

            yourToolTip.ToolTipIcon = ToolTipIcon.Info;
            yourToolTip.IsBalloon = true;
            yourToolTip.ShowAlways = true;

            yourToolTip.SetToolTip(textBoxLogin, "Oooh, you put your mouse over me.");
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
            if (textBoxLogin.Text.Equals("")&&textBoxPassword.Text.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
