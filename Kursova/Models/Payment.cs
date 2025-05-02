namespace Kursova.Models
{
    [Serializable]
    // Сутність Payment ( для розрахунку вартості послуги )
    public class Payment
    {
        public required string ServiceType { get; set; }
        public decimal PreviousReading { get; set; }
        public decimal CurrentReading { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Tariff { get; set; }
    }
}
