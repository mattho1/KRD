using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationKRDWebApi.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string street { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public UserRole role { get; set; }
        public User() { }
        public User(int _id, string _name, string _surname, string _street, string _login, string _password, UserRole _role)
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
