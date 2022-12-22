using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork10
{
    internal class Authorization
    {
        public static void Authoriz()
        {
            List<User> users = new List<User>();
            Admin admin = new Admin();
            while (true)
            {
                int pos, passwordPos = 10;
                string login = "", password = "";
                ConsoleKeyInfo key;
                Console.SetCursorPosition(45, 0);
                Console.WriteLine("Добро пожаловать в магазин");
                for (int i = 0; i < 120; i++)
                    Console.Write("-");
                Console.WriteLine("  Логин:");
                Console.WriteLine("  Пароль:");
                Console.WriteLine("  Авторизоваться");
                while (true)
                {
                    pos = Arrow.CheckPos(2, 4);
                    if (pos == 2)
                    {
                        Console.SetCursorPosition(9, 2);
                        Console.Write("                                                                                ");
                        Console.SetCursorPosition(9, 2);
                        login = Console.ReadLine();

                    }
                    if (pos == 3)
                    {
                        password = "";
                        passwordPos = 10;
                        Console.SetCursorPosition(10, 3);
                        Console.Write("                                                                                ");
                        Console.SetCursorPosition(10, 3);
                        key = Console.ReadKey();
                        password += key.KeyChar;
                        Console.SetCursorPosition(10, 3);
                        Console.Write("*");
                        while (key.Key != ConsoleKey.Enter)
                        {
                            key = Console.ReadKey();
                            if (key.Key != ConsoleKey.Enter)
                            {
                                password += key.KeyChar;
                                passwordPos++;
                                Console.SetCursorPosition(passwordPos, 3);
                                Console.Write("*");
                            }
                        }
                    }
                    if (pos == 4 && login != "" && password != "")
                    {
                        users = Json.Load();
                        foreach (User user in users)
                        {
                            if (user.login == login && user.password == password && user.role == Roles.Admin)
                                admin.AdminPanal(login);
                        }
                    }
                }
            }
        }
    }
}
