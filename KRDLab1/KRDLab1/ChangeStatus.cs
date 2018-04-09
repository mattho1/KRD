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
        PakageStatus status;
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
                case PakageStatus.Delivered:
                    radioButtonDelivered.Checked = true;
                    break;
                case PakageStatus.OnTheWay:
                    radioButtonOnTheWay.Checked = true;
                    break;
                case PakageStatus.InWarehouse:
                    radioButtonInWarehouse.Checked = true;
                    break;
                case PakageStatus.InSystem:
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
            status = PakageStatus.Delivered;
        }

        private void radioButtonOnTheWay_CheckedChanged(object sender, EventArgs e)
        {
            status = PakageStatus.OnTheWay;
        }

        private void radioButtonInWarehouse_CheckedChanged(object sender, EventArgs e)
        {
            status = PakageStatus.InWarehouse;
        }

        private void radioButtonInSystem_CheckedChanged(object sender, EventArgs e)
        {
            status = PakageStatus.InSystem;
        }
    }
}
