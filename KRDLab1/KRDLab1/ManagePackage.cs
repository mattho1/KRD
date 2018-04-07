using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KRDLab1
{
    public class ManagePackage
    {
        public static bool Write(Package package, string path)
        {
            try
            {
                Packages packs;
                if (File.Exists(path))
                {
                    packs = ReadListPackages(path);
                }
                else
                {
                    packs = new Packages();
                }
                packs.Add(package);
                XmlSerializer x = new XmlSerializer(typeof(Packages));
                StreamWriter writer = new StreamWriter(path);
                x.Serialize(writer, packs);
                writer.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public static bool WriteListPackages(List<Package> packages, string path)
        {
            try
            {
                Packages packs;
                if (File.Exists(path))
                {
                    packs = ReadListPackages(path);
                    packs.Add(packages);
                }
                else
                {
                    packs = new Packages(packages);
                }
                XmlSerializer x = new XmlSerializer(typeof(Packages));
                StreamWriter writer = new StreamWriter(path);
                x.Serialize(writer, packs);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public static Packages ReadListPackages(string path)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(Packages));
                StreamReader reader = new StreamReader(path);
                Packages packages = (Packages)x.Deserialize(reader);
                reader.Close();
                return packages;
            }
            catch
            {
                return null;
            }
        }
        public static Packages ReadListPackages(int customerId, string path)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(Packages));
                StreamReader reader = new StreamReader(path);
                Packages packages = ((Packages)x.Deserialize(reader));
                packages.packages = packages.packages.Where(p => p.owner.id == customerId).ToList();
                reader.Close();
                return packages;
            }
            catch
            {
                return null;
            }
        }
    }
}
