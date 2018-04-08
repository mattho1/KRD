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
    public partial class ManagePackagesWindow : Form
    {
        List<Package> listPackages;
        public ManagePackagesWindow()
        {
            InitializeComponent();
            listPackages = new List<Package>();
            loadData();
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewPackages.SelectedRows.Count > 0)
            {
                ChangeStatus windowChangeStatus = new ChangeStatus(listPackages, listPackages[(int)findPosition(dataGridViewPackages.SelectedRows)]);
                this.Enabled = false;
                windowChangeStatus.ShowDialog();
                refreshDataGridView();
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show("Najpierw musisz wybrać paczkę której chcesz zmienić status.");
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddModifyPackage windowAdd = new AddModifyPackage(listPackages, null);
            windowAdd.ShowDialog();
            refreshDataGridView();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPackages.SelectedRows.Count > 0)
            {
                AddModifyPackage windowModify = new AddModifyPackage(listPackages, listPackages[(int)findPosition(dataGridViewPackages.SelectedRows)]);
                windowModify.ShowDialog();
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Najpierw musisz wybrać paczkę którą chcesz modyfikować.");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPackages.SelectedRows.Count > 0)
            {
                ManagePackage.RemovePackage(getSelectedPackage(), GlobalVar.pathPackagesFile);
                listPackages.Remove(getSelectedPackage());
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Najpierw musisz wybrać użytkownika którego chcesz usunąć.");
            }
        }       
        private Package getSelectedPackage()
        {
            return listPackages[(int)findPosition(dataGridViewPackages.SelectedRows)];
        }
        private int? findPosition(DataGridViewSelectedRowCollection selectedRows)
        {
            return listPackages.FindIndex(x => ((x.number == Int32.Parse(selectedRows[0].Cells[0].Value.ToString()))));
        }
        private void loadData()
        {
            Packages packs = ManagePackage.ReadListPackages(GlobalVar.pathPackagesFile);
            if (packs != null)
            {
                listPackages = packs.packages;
            }
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            dataGridViewPackages.Rows.Clear();
            foreach (var package in listPackages)
            {
                addRowTodataGridView(package);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPackages.Rows.Clear();
            String[] nameAndSurname = textBoxSearch.Text.ToLower().Split(' ');
            foreach (var package in listPackages)
            {
                if (nameAndSurname.Count() == 1)
                {
                    if (package.owner.name.ToLower().Contains(nameAndSurname[0]) || package.owner.surname.ToLower().Contains(nameAndSurname[0]))
                    {
                        addRowTodataGridView(package);
                    }
                }
                else
                {
                    if (package.owner.name.ToLower().Contains(nameAndSurname[0]) && package.owner.surname.ToLower().Contains(nameAndSurname[1]) ||
                    (package.owner.name.ToLower().Contains(nameAndSurname[1]) && package.owner.surname.ToLower().Contains(nameAndSurname[0])))
                    {
                        addRowTodataGridView(package);
                    }
                }
            }
        }
        private void addRowTodataGridView(Package package)
        {
            dataGridViewPackages.Rows.Add(package.number, package.status, package.hour, package.owner.name, package.owner.surname);
        }
    }
}
