namespace Kursova.Models
{
    [Serializable]
    public class Payment
    {
        public string ServiceType { get; set; }
        public decimal PreviousReading { get; set; }
        public decimal CurrentReading { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Tariff { get; set; }
    }
}