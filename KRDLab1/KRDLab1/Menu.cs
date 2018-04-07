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
        ManagePackagesWindow windowManagePackages;
        public Menu()
        {
            InitializeComponent();
            login();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            windowShowData = new ShowData();
            this.Visible = false;
            windowShowData.ShowDialog();
            this.Visible = true;
        }
        private void login()
        {
            this.Enabled = false;
            LoginWindow window = new LoginWindow(this);
            window.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testAddPackage();
            windowManagePackages = new ManagePackagesWindow();
            this.Visible = false;
            windowManagePackages.ShowDialog();
            this.Visible = true;
        }
        //private void testAddPackage()
        ////{
        ////    List<Package> listPackages = new List<Package>();
        ////    listPackages.Add(new Package(1, "dostarczona", new DateTime(2018, 10, 10, 10, 0, 0), new KRDLab1.User("Mateusz", "Kowalski", "Długa")));
        ////    listPackages.Add(new Package(2, "oczekujaca", new DateTime(2018, 10, 20, 10, 0, 0), new KRDLab1.User("Mateusz1", "Kowalski1", "Długa1")));
        ////    listPackages.Add(new Package(3, "spakowana", new DateTime(2018, 10, 30, 10, 0, 0), new KRDLab1.User("Mateusz2", "Kowalski2", "Długa2")));
        ////    //Package pac = new Package(1, "dostarczona", "test", 1);
        ////    ManagePackage.WriteListPackages(listPackages, "Packages.xml");
        ////    ManagePackage.Write(listPackages[0],"Packages.xml");
        ////    Packages listPackages2 = ManagePackage.ReadListPackages("Packages.xml");
        ////    Console.WriteLine(listPackages2.packages[0].number.ToString());
        ////    //ManagePackage.Write(pac, "Packages.xml");
        ////    //List<Package> pacs = ManagePackage.Read("Packages.xml");

        //}
    }
}
