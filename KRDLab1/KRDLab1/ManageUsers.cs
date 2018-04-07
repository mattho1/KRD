using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace KRDLab1
{
    public class ManageUsers
    {
        public static bool AddUser(User user, string path)
        {
            return Write(user, path);
        }
        public static bool AddUsers(List<User> users, string path)
        {
            return WriteListUsers(users, path);
        }
        public static bool RemoveUser(User user, string path)
        {
            return AddOrRemoveUser(user, null, path);
        }
        public static bool ModifyUser(User oldUser, User newUser, string path)
        {
            return AddOrRemoveUser(oldUser, newUser, path);
        }
        private static bool AddOrRemoveUser(User userToRemove, User userToAdd, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    Users users;
                    users = ReadListUsers(path);
                    users.Remove(userToRemove);
                    if(userToAdd != null)
                    {
                        users.Add(userToAdd);
                    }
                    XmlSerializer x = new XmlSerializer(typeof(Users));
                    StreamWriter writer = new StreamWriter(path);
                    x.Serialize(writer, users);
                    writer.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
        private static bool Write(User user, string path)
        {
            try
            {
                Users users;
                if (File.Exists(path))
                {
                    users = ReadListUsers(path);
                }
                else
                {
                    users = new Users();
                }               
                users.Add(user);
                XmlSerializer x = new XmlSerializer(typeof(Users));
                StreamWriter writer = new StreamWriter(path);
                x.Serialize(writer, users);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
        private static bool WriteListUsers(List<User> uss, string path)
        {
            try
            {
                Users users;
                if (File.Exists(path))
                {
                    users = ReadListUsers(path);
                    users.Add(uss);
                }
                else
                {
                    users = new Users(uss);
                }
                XmlSerializer x = new XmlSerializer(typeof(Users));
                StreamWriter writer = new StreamWriter(path);
                x.Serialize(writer, users);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public static Users ReadListUsers(string path)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(Users));
                StreamReader reader = new StreamReader(path);
                Users users = (Users)x.Deserialize(reader);
                reader.Close();
                return users;
            }
            catch
            {
                return null;
            }
        }
    }
}
