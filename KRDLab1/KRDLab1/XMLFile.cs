using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KRDLab1
{
    abstract class XMLFile
    {
        static public void UpdateUserInXMLFile(string fileName, User lastUser, User newUser)
        {
            RemoveValueFromXMLFile(fileName, lastUser);
            AddUserToXMLFile(fileName, newUser);
        }
        static public void RemoveValueFromXMLFile(string fileName, User user)
        {
            XDocument xmlFile = XDocument.Load(fileName);
            xmlFile.Root.Elements("user").Where(x => (((string)x.Element("Name") == user.name)
                                            && ((string)x.Element("Surname") == user.surname)
                                            && ((string)x.Element("Street") == user.street))).Remove();
            xmlFile.Save(fileName);
        }
        static public void AddUserToXMLFile(string fileName, User user)
        {
            XDocument doc = XDocument.Load(fileName);
            XElement root = new XElement("user");
            root.Add(new XElement("Name", user.name));
            root.Add(new XElement("Surname", user.surname));
            root.Add(new XElement("Street", user.street));
            doc.Element("Users").Add(root);
            doc.Save(fileName);
        }
        static public void createExampleData(string fileName)
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
            users.Save(fileName);
        }
        static public List<User> parseXML(string fileName)
        {
            List<User> userList = new List<User>();
            var xml = XDocument.Load(fileName);
            var query = (from c in xml.Root.Descendants("user")
                         select new User(c.Element("Name").Value.ToString(),
                         c.Element("Surname").Value.ToString(),
                         c.Element("Street").Value.ToString())).ToList();
            foreach (User user in query)
            {
                userList.Add(user);
            }
            return userList;
        }
        static public void addExampleDataToXML(string fileName)
        {
            XDocument doc = XDocument.Load(fileName);
            XElement root = new XElement("user");
            root.Add(new XElement("Name", "Jan"));
            root.Add(new XElement("Surname", "Nowak"));
            root.Add(new XElement("Street", "Solna"));
            doc.Element("Users").Add(root);
            doc.Save(fileName);
        }
    }
}
