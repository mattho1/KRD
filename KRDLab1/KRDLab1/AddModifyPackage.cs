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
    public partial class AddModifyPackage : Form
    {
        List<Package> packageList;
        List<User> usersList;
        Package package;
        bool isModifyWindow;
        public AddModifyPackage(List<Package> _packageList, Package pack)
        {
            InitializeComponent();
            packageList = _packageList;
            package = pack;
            decideWhetherToAddOrModify();
            loadClients();
        }
        private void decideWhetherToAddOrModify()
        {
            if (package != null)
            {
                fillFields();
                buttonAddOrModify.Text = "Modyfikuj";
                isModifyWindow = true;
            }
            else
            {
                buttonAddOrModify.Text = "Dodaj";
                isModifyWindow = false;
            }
        }

        private void fillFields()
        {
            numericUpDownNumberPackage.Value = package.number;
            comboBoxStatus.Text = package.status;
            numericUpDownHour.Value = package.hour.Hour;
            numericUpDownMinute.Value = package.hour.Minute;
            comboBoxClient.Text = preprocessDataAboutClient(package.owner);
        }

        private void buttonAddOrModify_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (isModifyWindow)
                {
                    if (dataWasChanged())
                    {
                        Package newPackage = new Package((int)numericUpDownNumberPackage.Value, comboBoxStatus.Text, createHour(), getClient());
                        ManagePackage.ModifyPackage(package, newPackage, GlobalVar.pathPackagesFile);
                        packageList[packageList.FindIndex(x => ((x.number == package.number)))] = newPackage;
                        MessageBox.Show("Zmieniono dane paczki");
                    }
                    Close();
                }
                else
                {
                    Package newPackage = new Package((int)numericUpDownNumberPackage.Value, comboBoxStatus.Text, createHour(), getClient());
                    ManagePackage.AddPackage(newPackage, GlobalVar.pathPackagesFile);
                    packageList.Add(newPackage);
                    MessageBox.Show("Dodano paczkę");
                    Close();
                }
            }
            else
            {
                if (isNumberAvailable())
                {
                    MessageBox.Show("Wprowadź wszystkie dane.");                    
                }
                else
                {
                    MessageBox.Show("Podany numer paczki jest już zajęty.");
                }
            }
        }
        private DateTime createHour()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numericUpDownHour.Value, (int)numericUpDownMinute.Value, 0);
        }
        private User getClient()
        {
            foreach(User user in usersList)
            {
                String[] clientData = comboBoxClient.Text.Split(' ');
                if(user.id == Int32.Parse(clientData[0]))
                {
                    return user;
                }
            }
            return null;
        }
        private bool dataWasChanged()
        {
            if ((int)numericUpDownNumberPackage.Value == package.number && comboBoxStatus.Text.Equals(package.status) && createHour().Equals(package.hour) && getClient().id == package.owner.id)
            {
                return false;
            }
            return true;
        }
        private bool validation()
        {
            if (!numericUpDownNumberPackage.Text.Equals("") && isNumberAvailable() && !comboBoxStatus.Text.Equals("") && !comboBoxClient.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private bool isNumberAvailable()
        {
            if(isModifyWindow && ((int)numericUpDownNumberPackage.Value != package.number))
            {
                foreach (Package pack in packageList)
                {
                    if (pack.number == (int)numericUpDownNumberPackage.Value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void loadClients()
        {
            usersList = (ManageUsers.ReadListUsers(GlobalVar.pathUsersFile)).users;
            foreach(var user in usersList)
            {
                comboBoxClient.Items.Add(preprocessDataAboutClient(user));
            }
        }
        private string preprocessDataAboutClient(User client)
        {
            return client.id + " " + client.name + " " + client.surname;
        }
        private void buttonActualTime_Click(object sender, EventArgs e)
        {
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;
        }

        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            AddModify windowAddOrModify = new AddModify(usersList, null, true);
            this.Visible = false;
            windowAddOrModify.ShowDialog();
            this.Visible = true;
            refreshComboBoxClient();
        }
        private void refreshComboBoxClient()
        {
            comboBoxClient.Items.Clear();
            loadClients();
        }
    }
}
