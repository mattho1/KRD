using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string street { get; set; }
        public User(){}
        public User(string _name, string _surname, string _street)
        {
            name = _name;
            surname = _surname;
            street = _street;
        }
    }
}
