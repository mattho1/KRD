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
        String nameFileWithData = "users.xml";
        public AddModify(List<User> _userList, int? _number)
        {
            InitializeComponent();
            userList = _userList;
            decideWhetherToAddOrModify(_number);
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
            if (isModifyWindow)
            {
                User user = new User(textBoxName.Text, textBoxSurname.Text, textBoxStreet.Text);
                ManageUsers.ModifyUser(userList[position], user, nameFileWithData);
                userList[position] = user;
                MessageBox.Show("Zmieniono dane użytkownika");
                Close();
            }
            else
            {
                User user = new User(textBoxName.Text, textBoxSurname.Text, textBoxStreet.Text);
                ManageUsers.AddUser(user, nameFileWithData);
                userList.Add(user);
                MessageBox.Show("Dodano użytkownika");
                Close();
            }
        }
        private void fillFields()
        {
            textBoxName.Text = userList[position].name;
            textBoxSurname.Text = userList[position].surname;
            textBoxStreet.Text = userList[position].street;
        }
    }
}
