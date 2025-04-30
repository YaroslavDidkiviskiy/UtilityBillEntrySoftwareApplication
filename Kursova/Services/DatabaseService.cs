using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Kursova.Models;

namespace Kursova.Services
{
    public static class DatabaseService
    {
        private static readonly string UsersPath = "users.xml";
        private static readonly string PaymentsPath = "payments.xml";

        // Завантажити користувачів
        public static List<User> LoadUsers()
        {
            if (File.Exists(UsersPath))
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                using var reader = new StreamReader(UsersPath);
                return (List<User>)serializer.Deserialize(reader);
            }
            return new List<User>();
        }

        // Зберегти користувачів
        public static void SaveUsers(List<User> users)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using var writer = new StreamWriter(UsersPath);
            serializer.Serialize(writer, users);
        }

        // Завантажити платежі
        public static List<Payment> LoadPayments()
        {
            if (File.Exists(PaymentsPath))
            {
                var serializer = new XmlSerializer(typeof(List<Payment>));
                using var reader = new StreamReader(PaymentsPath);
                return (List<Payment>)serializer.Deserialize(reader);
            }
            return new List<Payment>();
        }

        // Зберегти один платіж
        public static void SavePayment(Payment payment)
        {
            var payments = LoadPayments();
            payments.Add(payment);
            SavePayments(payments); // Викликаємо метод для збереження всього списку
        }

        // Зберегти список платежів
        public static void SavePayments(List<Payment> payments)
        {
            var serializer = new XmlSerializer(typeof(List<Payment>));
            using var writer = new StreamWriter(PaymentsPath);
            serializer.Serialize(writer, payments);
        }
    }
}