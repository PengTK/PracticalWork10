using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork10
{
    internal class User
    {
        public int id;
        public string login;
        public string password;
        public Roles role;

        public User(int Id, string Login, string Password, Roles Role)
        {
            id = Id;
            login = Login;
            password = Password;
            role = Role;
        }
    }
}
