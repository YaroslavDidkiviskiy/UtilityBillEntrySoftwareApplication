using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Kursova.Models;

namespace Kursova.Services
{
    public static class DatabaseService
    {
        private static readonly string UsersPath = "users.xml";

        // Завантажити всіх користувачів
        public static List<User> LoadUsers()
        {
            if (!File.Exists(UsersPath)) return new List<User>();
            
            var serializer = new XmlSerializer(typeof(List<User>));
            using var reader = new StreamReader(UsersPath);
            return (List<User>)serializer.Deserialize(reader);
        }

        // Зберегти всіх користувачів
        public static void SaveUsers(List<User> users)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using var writer = new StreamWriter(UsersPath);
            serializer.Serialize(writer, users);
        }

        // Оновити конкретного користувача
        public static void UpdateUser(User user)
        {
            var users = LoadUsers();
            var index = users.FindIndex(u => u.Login == user.Login);
            if (index != -1) users[index] = user;
            SaveUsers(users);
        }
    }
}