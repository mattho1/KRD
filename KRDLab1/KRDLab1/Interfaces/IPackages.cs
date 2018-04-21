using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRDLab1
{
    public interface IPackages
    {
        List<Package> packages { get; set; }
        void Add(Package pack);
        void Add(List<Package> packs);
        void Remove(Package packageToRemove);
    }
}
