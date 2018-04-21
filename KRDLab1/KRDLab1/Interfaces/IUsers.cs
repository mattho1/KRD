using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public interface IUsers
    {
        List<User> users { get; set; }
        void Add(User user);
        void Add(List<User> uss);
        void Remove(User user);
    }
}
