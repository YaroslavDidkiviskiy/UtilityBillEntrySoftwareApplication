namespace Kursova.Models
{
    // Сутність класу User ( для роботи з даними користувача )
    [Serializable]
    public class User
    {
        public required string FullName { get; set; }
        public required string Address { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public decimal Balance { get; set; }
        public bool IsAdmin { get; set; }
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
