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
    public partial class ChangeStatus : Form
    {
        string status;
        List<Package> packageList;
        Package package;
        public ChangeStatus(List<Package> _packageList, Package _package)
        {
            InitializeComponent();
            packageList = _packageList;
            package = _package;
            checkStatus();
        }

        private void checkStatus()
        {
            switch(package.status)
            {
                case "dostarczono":
                    radioButtonDelivered.Checked = true;
                    break;
                case "w drodze":
                    radioButtonOnTheWay.Checked = true;
                    break;
                case "w magazynie":
                    radioButtonInWarehouse.Checked = true;
                    break;
                case "w systemie":
                    radioButtonInSystem.Checked = true;
                    break;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(status != package.status)
            {
                Package newPackage = new Package(package.number, status, DateTime.Now, package.owner);
                ManagePackage.ModifyPackage(package, newPackage, GlobalVar.pathPackagesFile);
                packageList[(int)findPosition(package)] = newPackage;
            }
            Close();
        }
        private int? findPosition(Package pack)
        {
            return packageList.FindIndex(x => ((x.number == pack.number)));
        }
        private void radioButtonDelivered_CheckedChanged(object sender, EventArgs e)
        {
            status = radioButtonDelivered.Text;
        }

        private void radioButtonOnTheWay_CheckedChanged(object sender, EventArgs e)
        {
            status = radioButtonOnTheWay.Text;
        }

        private void radioButtonInWarehouse_CheckedChanged(object sender, EventArgs e)
        {
            status = radioButtonInWarehouse.Text;
        }

        private void radioButtonInSystem_CheckedChanged(object sender, EventArgs e)
        {
            status = radioButtonInSystem.Text;
        }
    }
}
