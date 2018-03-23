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
        String nameFileWithData = "users.xml";
        public ShowData()
        {
            InitializeComponent();
            userList = new List<User>();
            loadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //windowAddOrModify = new AddModify(null);
            // windowAddOrModify.ShowDialog();
            addDataToXML();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            windowAddOrModify = new AddModify(dataGridViewData.SelectedRows);
            windowAddOrModify.ShowDialog();
        }
        private User convert(DataGridViewRow row)
        {

            return user;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //createExampleData();
            parseXML();
            loadData();
        }

        private void parseXML()
        {
            var xml = XDocument.Load(nameFileWithData);
            var query = (from c in xml.Root.Descendants("user")
                        select new User(c.Element("Name").Value.ToString(),
                        c.Element("Surname").Value.ToString(),
                        c.Element("Street").Value.ToString())).ToList();
            foreach (User user in query)
            {
                userList.Add(user);
            }
        }
        private void addDataToXML()
        {
            XDocument doc = XDocument.Load(nameFileWithData);
            XElement root = new XElement("user");
            root.Add(new XElement("Name", "Jan"));
            root.Add(new XElement("Surname", "Nowak"));
            root.Add(new XElement("Street", "Solna"));
            doc.Element("user").Add(root);
            doc.Save(nameFileWithData);
        }
        private void createExampleData()
        {
            XElement users =
            new XElement("Users",
                new XElement("user",
                    new XElement("Name", "Mateusz"),
                    new XElement("Surname", "Thomas"),
                    new XElement("Street", "Reja")
                ),
                new XElement("user",
                    new XElement("Name", "Maciej"),
                    new XElement("Surname", "Kowalski"),
                    new XElement("Street", "Długa")
                )
            );
            users.Save(nameFileWithData);         
        }
        private void loadData()
        {
            parseXML();
            foreach (var user in userList)
            {
                dataGridViewData.DataSource = null;
                dataGridViewData.Rows.Add(user.name, user.surname, user.street);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();
            foreach (var user in userList)
            {
                if (user.name.Contains(textBoxSearch.Text))
                {
                    dataGridViewData.Rows.Add(user.name, user.surname, user.street);
                }
            }
        }
    }
}
