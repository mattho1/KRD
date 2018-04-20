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
            if(user != null)
            {
                users.Add(user);
            }else
            {
                new Exception();
            }
            
        }
        public void Add(List<User> uss)
        {
            if (uss != null)
            {
                foreach (User user in uss)
                {
                    users.Add(user);
                }
            }else
            {
                new Exception();
            }
        }
        internal void Remove(User user)
        {
            var item = users.SingleOrDefault(r => r.name == user.name && r.surname == user.surname);
            users.Remove(item);
        }
    }
}
