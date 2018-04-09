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
    public partial class Menu : Form
    {
        ShowData windowShowData;
        ManagePackagesWindow windowManagePackages;
        UserRole userRole;
        public Menu()
        {
            InitializeComponent();
            userRole = UserRole.Courier;
            buttonManageUsers.Enabled = false;
            login();
        }
        public void setUserRole(UserRole role)
        {
            userRole = role;
            if(role.Equals(UserRole.Administrator))
            {
                buttonManageUsers.Enabled = true;
            }else
            {
                buttonManageUsers.Enabled = false;
            }
        }
        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            windowShowData = new ShowData();
            this.Visible = false;
            windowShowData.ShowDialog();
            this.Visible = true;
        }
        private void login()
        {
            this.Enabled = false;
            this.Visible = false;
            LoginWindow window = new LoginWindow(this);
            window.ShowDialog();
            this.Visible = true;
        }
        private void buttonManagePackages_Click(object sender, EventArgs e)
        {
            windowManagePackages = new ManagePackagesWindow();
            this.Visible = false;
            windowManagePackages.ShowDialog();
            this.Visible = true;
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
