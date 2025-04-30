using System;
using System.Windows.Forms;
using Kursova.Forms;
using Kursova.Models;
using Kursova.Services;

namespace Kursova
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var users = DatabaseService.LoadUsers();
            if (!users.Exists(u => u.IsAdmin))
            {
                users.Add(new User
                {
                    Login = "admin",
                    Password = "admin",
                    FullName = "Адміністратор",
                    Address = "-",
                    Balance = 0,
                    IsAdmin = true
                });
                DatabaseService.SaveUsers(users);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}