using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public class Users: IUsers
    {
        public List<User> users { get; set; }
        public Users()
        {
            users = new List<User>();
        }
        public Users(List<User> us)
        {
            if(us != null)
            {
                users = us;
            }
            else
            {
                throw new ArgumentException($"List users can't be empty.");
            }
        }
        public void Add(User user)
        {
            if(user != null)
            {
                users.Add(user);
            }else
            {
                throw new ArgumentException($"User must exist.");
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
                throw new ArgumentException($"Users list must exist.");
            }
        }
        public void Remove(User user)
        {
            if (user != null)
            {
                var item = users.SingleOrDefault(r => r.name == user.name && r.surname == user.surname);
                if (item != null)
                {
                    users.Remove(item);
                }
                else
                {
                    throw new ArgumentException($"There isn't user on the list.");
                }
            }
            else
            {
                throw new ArgumentException($"User can't not exist.");
            }            
        }
    }
}
