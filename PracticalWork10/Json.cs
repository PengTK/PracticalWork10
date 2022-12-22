using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork10
{
    internal class Json
    {
        public static List<User> Load()
        {
            List<User> users;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Users.json"))
            {
                string Text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Users.json");
                users = JsonConvert.DeserializeObject<List<User>>(Text);
                return users;
            }
            else
            {
                string json;
                List<User> user = new List<User>();
                User admin = new User(0, "admin", "admin", 0);
                user.Add(admin);
                json = JsonConvert.SerializeObject(user);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Users.json", json);
                return user;
            }
        }
        public static void Save(List<User> users)
        {
            string json;
            json = JsonConvert.SerializeObject(users);
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Users.json", json);
        }
    }
}
