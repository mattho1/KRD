using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public class Package
    {
        public int number { get; set; }
        public string status { get; set; }
        public DateTime hour { get; set; }
        public User owner { get; set; }
        public Package()
        {

        }
        public Package(int _number, string _status, DateTime _hour, User _owner)
        {
            number = _number;
            status = _status;
            hour = _hour;
            owner = _owner;
        }
    }
}
