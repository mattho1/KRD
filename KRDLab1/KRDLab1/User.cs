using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace KRDLab1
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string street { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public User(){}
        public User(int _id, string _name, string _surname, string _street, string _login, string _password, string _role)
        {
            id = _id;
            name = _name;
            surname = _surname;
            street = _street;
            login = _login;
            password = _password;
            role = _role;
        }
    }
}
