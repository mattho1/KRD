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
        User user;
        public AddModify(User _user)
        {
            InitializeComponent();
            user = _user;
            if(_user != null)
            {
                fillFields();
            }
        }

        private void buttonAddOrModify_Click(object sender, EventArgs e)
        {

        }
        private void fillFields()
        {
            textBoxName.Text = user.name;
            textBoxSurname.Text = user.surname;
            textBoxStreet.Text = user.street;
        }
    }
}
