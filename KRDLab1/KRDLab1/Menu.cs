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
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            windowShowData = new ShowData();
            windowShowData.ShowDialog();
        }
    }
}
