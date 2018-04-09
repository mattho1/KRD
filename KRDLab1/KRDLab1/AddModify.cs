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
        bool isClient;
        public AddModify(List<User> _userList, int? _number, bool _isClient)
        {
            InitializeComponent();
            userList = _userList;
            isClient = _isClient;
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
                    modifyUser();
                }
                else
                {
                    addUser();
                }
            }else
            {
                MessageBox.Show("Wprowadź wszystkie dane");
            }
        }
        private void addUser()
        {
            User user = new User(generateIdNumber(), textBoxName.Text, textBoxSurname.Text, textBoxStreet.Text, textBoxLogin.Text, textBoxPassword.Text, (UserRole)comboBoxRole.SelectedItem);
            ManageUsers.AddUser(user, GlobalVar.pathUsersFile);
            userList.Add(user);
            if (isClient)
            {
                MessageBox.Show("Dodano klienta");
            }
            else
            {
                MessageBox.Show("Dodano użytkownika");
            }
            Close();
        }
        private void modifyUser()
        {
            if (dataWasChanged())
            {
                User user = new User(userList[position].id, textBoxName.Text, textBoxSurname.Text, textBoxStreet.Text, textBoxLogin.Text, textBoxPassword.Text, (UserRole)comboBoxRole.SelectedItem);
                ManageUsers.ModifyUser(userList[position], user, GlobalVar.pathUsersFile);
                userList[position] = user;
                MessageBox.Show("Zmieniono dane użytkownika");
            }
            Close();
        }

        private bool dataWasChanged()
        {
            if (userList[position].login.Equals(textBoxLogin.Text) && textBoxName.Text.Equals(userList[position].name)
                && textBoxPassword.Text.Equals(userList[position].password) && textBoxSurname.Text.Equals(userList[position].surname)
                && textBoxStreet.Text.Equals(userList[position].street) && comboBoxRole.Text.Equals(userList[position].role.ToString()) )
            {
                return false;
            }
            return true;
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
            comboBoxRole.Text = userList[position].role.ToString();
            comboBoxRole.SelectedItem = userList[position].role;
        }
        private void loadRoles()
        {
            if (!isClient)
            {
                comboBoxRole.Items.Add(UserRole.Administrator);
                comboBoxRole.Items.Add(UserRole.Courier);
                comboBoxRole.Items.Add(UserRole.Client);
            }else
            {
                comboBoxRole.Items.Add(UserRole.Client);
                comboBoxRole.Enabled = false;
            }
            if (isModifyWindow)
            {
                comboBoxRole.SelectedItem = userList[position].role;
            }else
            {
                comboBoxRole.SelectedItem = UserRole.Client;
            }
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
