using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public class Packages: IPackages
    {
        public List<Package> packages { get; set; }
        public Packages()
        {
            packages = new List<Package>();
        }
        public Packages(List<Package> packs)
        {
            if (packs != null)
            {
                packages = packs;
            }
            else
            {
                throw new ArgumentException($"List packages can't be empty.");
            }
        }
        public void Add(Package pack)
        {
            if (pack != null)
            {
                packages.Add(pack);
            }
            else
            {
                throw new ArgumentException($"Package must exist.");
            }
        }
        public void Add(List<Package> packs)
        {
            if(packs != null)
            {
                foreach (Package pack in packs)
                {
                    packages.Add(pack);
                }
            }
            else
            {
                throw new ArgumentException($"Packages list must exist.");
            }
        }

        public void Remove(Package packageToRemove)
        {
            if(packageToRemove != null)
            {
                var item = packages.SingleOrDefault(r => r.number == packageToRemove.number);
                if (item != null)
                {
                    packages.Remove(item);
                }
                else
                {
                    throw new ArgumentException($"There isn't package on the list.");
                }
            }
            else
            {
                throw new ArgumentException($"Package can't not exist.");
            }
        }
    }
}
