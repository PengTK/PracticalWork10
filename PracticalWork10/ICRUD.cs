using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork10
{
    internal interface ICRUD
    {
        void Create(List<User> users);
        void Read(List<User> users, User user, int posit);
        void Update();
        void Delete(List<User> users, int posit);
    }
}
