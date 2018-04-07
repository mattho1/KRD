using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public class Users
    {
        public List<User> users { get; set; }
        public Users()
        {
            users = new List<User>();
        }
        public Users(List<User> us)
        {
            users = us;
        }
        public void Add(User user)
        {
            users.Add(user);
        }
        public void Add(List<User> uss)
        {
            foreach (User user in uss)
            {
                users.Add(user);
            }
        }
        internal void Remove(User user)
        {
            var item = users.SingleOrDefault(r => r.name == user.name && r.surname == user.surname);
            users.Remove(item);
        }
    }
}
