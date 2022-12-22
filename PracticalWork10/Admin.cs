using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork10
{
    internal class Admin : ICRUD
    {
        int i, pos;
        List<User> users = new List<User>();
        public void AdminPanal(string login)
        {
            while (true)
            {
                i = 3;
                users = Json.Load();
                Console.Clear();
                Console.SetCursorPosition(10, 0);
                Console.Write("Добро пожаловать, " + login);
                Console.SetCursorPosition(80, 0);
                Console.WriteLine("Роль: Администратор");
                for (int i = 0; i < 120; i++)
                    Console.Write("-");
                for (int i = 2; i < 10; i++)
                {
                    Console.SetCursorPosition(90, i);
                    Console.Write("|");
                }
                Console.SetCursorPosition(95, 2);
                Console.Write("F1 - добавить запись");
                Console.SetCursorPosition(95, 3);
                Console.Write("F2 - найти запись");
                Console.SetCursorPosition(10, 2);
                Console.Write("ID");
                Console.SetCursorPosition(30, 2);
                Console.Write("Логин");
                Console.SetCursorPosition(50, 2);
                Console.Write("Пароль");
                Console.SetCursorPosition(70, 2);
                Console.Write("Роль");
                foreach (User user in users)
                {
                    Console.SetCursorPosition(10, i);
                    Console.Write(user.id);
                    Console.SetCursorPosition(30, i);
                    Console.Write(user.login);
                    Console.SetCursorPosition(50, i);
                    Console.Write(user.password);
                    Console.SetCursorPosition(70, i);
                    Console.Write(user.role);
                    i++;
                }
                pos = Arrow.CheckPos(3, i - 1);
                if (pos == -1)
                    Create(users);
                if (pos >= 2)
                    Read(users, users[pos-3], pos-3);
            }
        }

        public void Create(List<User> users)
        {
            int id = 0, role = 0;
            string login = "", password = "";
            Roles Role = new Roles();
            Console.Clear();
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.Write("Добро пожаловать, admin");
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: Администратор");
            for (int i = 0; i < 120; i++)
                Console.Write("-");
            for (int i = 2; i < 10; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(95, 2);
            Console.Write("0 - Администратор");
            Console.SetCursorPosition(95, 3);
            Console.Write("1 - Кассир");
            Console.SetCursorPosition(95, 4);
            Console.Write("2 - Кадровик");
            Console.SetCursorPosition(95, 5);
            Console.Write("3 - Склад-менеджер");
            Console.SetCursorPosition(95, 6);
            Console.Write("4 - Бухгалтер");
            Console.SetCursorPosition(95, 8);
            Console.Write("S - Сохранить изменения");
            Console.SetCursorPosition(95, 9);
            Console.Write("Escape - Вернуться в меню");
            Console.SetCursorPosition(3, 2);
            Console.Write("ID:");
            Console.SetCursorPosition(3, 3);
            Console.Write("Логин:");
            Console.SetCursorPosition(3, 4);
            Console.Write("Пароль:");
            Console.SetCursorPosition(3, 5);
            Console.Write("Роль:");
            do
            {
                pos = Arrow.CheckPos(2, 5);
                if (pos == 2)
                {
                    Console.SetCursorPosition(7, 2);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(7, 2);
                    id = Convert.ToInt32(Console.ReadLine());
                }
                if (pos == 3)
                {
                    Console.SetCursorPosition(10, 3);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(10, 3);
                    login = Console.ReadLine();
                }
                if (pos == 4)
                {
                    Console.SetCursorPosition(11, 4);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(11, 4);
                    password = Console.ReadLine();
                }
                if (pos == 5)
                {
                    Console.SetCursorPosition(9, 5);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(9, 5);
                    role = Convert.ToInt32(Console.ReadLine());
                    switch (role)
                    {
                        case 0:
                            Role = Roles.Admin;
                            break;
                        case 1:
                            Role = Roles.Kassir;
                            break;
                        case 2:
                            Role = Roles.Kadrovik;
                            break;
                        case 3:
                            Role = Roles.ScladManager;
                            break;
                        case 4:
                            Role = Roles.Bugalter;
                            break;
                    }
                }
            } while (pos >= 2);
            if (pos == -5)
            {
                User user = new User(id, login, password, Role);
                users.Add(user);
                Json.Save(users);
            }

        }
        public void Read(List<User> users, User user, int posit)
        {

            int id = 0, role = 0;
            string login = "", password = "";
            Roles Role = new Roles();
            Console.Clear();
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.Write("Добро пожаловать, admin");
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: Администратор");
            for (int i = 0; i < 120; i++)
                Console.Write("-");
            for (int i = 2; i < 10; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(95, 2);
            Console.SetCursorPosition(95, 2);
            Console.Write("0 - Администратор");
            Console.SetCursorPosition(95, 3);
            Console.Write("1 - Кассир");
            Console.SetCursorPosition(95, 4);
            Console.Write("2 - Кадровик");
            Console.SetCursorPosition(95, 5);
            Console.Write("3 - Склад-менеджер");
            Console.SetCursorPosition(95, 6);
            Console.Write("4 - Бухгалтер");
            Console.SetCursorPosition(95, 8);
            Console.Write("S - Сохранить изменения");
            Console.SetCursorPosition(95, 9);
            Console.Write("Delete - Удалить элемент");
            Console.SetCursorPosition(95, 10);
            Console.Write("Escape - Вернуться в меню");

            Console.SetCursorPosition(3, 2);
            Console.Write("ID: " + user.id);
            Console.SetCursorPosition(3, 3);
            Console.Write("Логин: " + user.login);
            Console.SetCursorPosition(3, 4);
            Console.Write("Пароль: " + user.password);
            Console.SetCursorPosition(3, 5);
            Console.Write("Роль: " + user.role);
            do
            {
                pos = Arrow.CheckPos(2, 5);
                if (pos == 2)
                {
                    Console.SetCursorPosition(7, 2);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(7, 2);
                    user.id = Convert.ToInt32(Console.ReadLine());
                }
                if (pos == 3)
                {
                    Console.SetCursorPosition(10, 3);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(10, 3);
                    user.login = Console.ReadLine();
                }
                if (pos == 4)
                {
                    Console.SetCursorPosition(11, 4);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(11, 4);
                    user.password = Console.ReadLine();
                }
                if (pos == 5)
                {
                    Console.SetCursorPosition(9, 5);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(9, 5);
                    role = Convert.ToInt32(Console.ReadLine());
                    switch (role)
                    {
                        case 0:
                            user.role = Roles.Admin;
                            break;
                        case 1:
                            user.role = Roles.Kassir;
                            break;
                        case 2:
                            user.role = Roles.Kadrovik;
                            break;
                        case 3:
                            user.role = Roles.ScladManager;
                            break;
                        case 4:
                            user.role = Roles.Bugalter;
                            break;
                    }
                }
            } while (pos >= 2);
            if (pos == -5)
            {
                users[posit] = user;
                Json.Save(users);
            }
            if (pos == -15)
            {
                Delete(users, posit);
            }
        }

        public void Update()
        {

        }
        public void Delete(List<User> users, int posit)
        {
            users.RemoveAt(posit);
            Json.Save(users);
        }
    }
}
