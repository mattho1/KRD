using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public class Packages
    {
        public List<Package> packages { get; set; }
        public Packages()
        {
            packages = new List<Package>();
        }
        public Packages(List<Package> packs)
        {
            packages = packs;
        }
        public void Add(Package pack)
        {
            packages.Add(pack);
        }
        public void Add(List<Package> packs)
        {
            foreach(Package pack in packs)
            {
                packages.Add(pack);
            }
        }
    }
}
