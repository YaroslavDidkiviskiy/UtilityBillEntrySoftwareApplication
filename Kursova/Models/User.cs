using System;

namespace Kursova.Models
{
    [Serializable]
    public class User
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public bool IsAdmin { get; set; }
        
    }
}