using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace KRDLab1
{
    public partial class ShowData : Form
    {
        AddModify windowAddOrModify;
        List<User> userList;
        public ShowData()
        {
            InitializeComponent();
            userList = new List<User>();
            loadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            windowAddOrModify = new AddModify(userList, null);
            windowAddOrModify.ShowDialog();
            refreshDataGridView();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                windowAddOrModify = new AddModify(userList, findPosition(dataGridViewData.SelectedRows));
                windowAddOrModify.ShowDialog();
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Najpierw musisz wybrać użytkownika którego chcesz modyfikować.");
            }
        }

        private int? findPosition(DataGridViewSelectedRowCollection selectedRows)
        {
            return userList.FindIndex(x => ((x.name == selectedRows[0].Cells[0].Value.ToString())
                                            &&(x.surname == selectedRows[0].Cells[1].Value.ToString()) 
                                            &&(x.street == selectedRows[0].Cells[4].Value.ToString())));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                ManageUsers.RemoveUser(getSelectedUser(), GlobalVar.pathUsersFile);
                userList.Remove(getSelectedUser());
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Najpierw musisz wybrać użytkownika którego chcesz usunąć.");
            }
        }
        private User getSelectedUser()
        {
            return userList[(int)findPosition(dataGridViewData.SelectedRows)];
        }
        private void loadData()
        {
            Users uss = ManageUsers.ReadListUsers(GlobalVar.pathUsersFile);
            if(uss != null)
            {
                userList = uss.users;
            }
            refreshDataGridView();
        }
        private void refreshDataGridView()
        {
            dataGridViewData.Rows.Clear();
            foreach (var user in userList)
            {
                addRowTodataGridView(user);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            String[] nameAndSurname = textBoxSearch.Text.ToLower().Split(' ');
            foreach (var user in userList)
            {
                if (nameAndSurname.Count() == 1)
                {
                    if (user.name.ToLower().Contains(nameAndSurname[0]) || user.surname.ToLower().Contains(nameAndSurname[0]))
                    {
                        addRowTodataGridView(user);
                    }
                }
                else
                {
                    if (user.name.ToLower().Contains(nameAndSurname[0]) && user.surname.ToLower().Contains(nameAndSurname[1])||
                    (user.name.ToLower().Contains(nameAndSurname[1]) && user.surname.ToLower().Contains(nameAndSurname[0])))
                    {
                        addRowTodataGridView(user);
                    }
                }
            }
        }
        private void addRowTodataGridView(User user)
        {
            dataGridViewData.Rows.Add(user.name, user.surname, user.role, user.login, user.street);
        }
    }
}
