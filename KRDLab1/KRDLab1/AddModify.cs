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
    public partial class AddModify : Form
    {
        List<User> userList;
        int position;
        bool isModifyWindow;
        public AddModify(List<User> _userList, int? _number)
        {
            InitializeComponent();
            userList = _userList;
            decideWhetherToAddOrModify(_number);
            loadRoles();
        }
        private void decideWhetherToAddOrModify(int? _number)
        {
            if (_number != null)
            {
                position = (int)_number;
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
        private void buttonAddOrModify_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (isModifyWindow)
                {
                    User user = new User(userList[position].id, textBoxName.Text, textBoxSurname.Text, textBoxStreet.Text, textBoxLogin.Text, textBoxPassword.Text, comboBoxRole.Text);
                    ManageUsers.ModifyUser(userList[position], user, GlobalVar.pathUsersFile);
                    userList[position] = user;
                    MessageBox.Show("Zmieniono dane użytkownika");
                    Close();
                }
                else
                {
                    User user = new User(generateIdNumber(), textBoxName.Text, textBoxSurname.Text, textBoxStreet.Text, textBoxLogin.Text, textBoxPassword.Text, comboBoxRole.Text);
                    ManageUsers.AddUser(user, GlobalVar.pathUsersFile);
                    userList.Add(user);
                    MessageBox.Show("Dodano użytkownika");
                    Close();
                }
            }else
            {
                MessageBox.Show("Wprowadź wszystkie dane");
            }
        }
        private bool validation()
        {
            if (textBoxName.Text.Equals("") || textBoxName.Text.Equals("") || textBoxSurname.Text.Equals("") || textBoxStreet.Text.Equals("") || textBoxLogin.Text.Equals("") || textBoxPassword.Text.Equals("") || comboBoxRole.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
        private void fillFields()
        {
            textBoxName.Text = userList[position].name;
            textBoxSurname.Text = userList[position].surname;
            textBoxStreet.Text = userList[position].street;
            textBoxLogin.Text = userList[position].login;
            textBoxPassword.Text = userList[position].password;
            comboBoxRole.Text = userList[position].role;
        }
        private void loadRoles()
        {
            comboBoxRole.Items.Add("Administrator");
            comboBoxRole.Items.Add("Kurier");
            comboBoxRole.Items.Add("Klient");
            comboBoxRole.Text = "Klient";
        }
        private int generateIdNumber()
        {
            int idNumber = 0;
            foreach(User us in userList)
            {
                if(us.id > idNumber)
                {
                    idNumber = us.id;
                }
            }
            return ++idNumber;
        }
    }
}
