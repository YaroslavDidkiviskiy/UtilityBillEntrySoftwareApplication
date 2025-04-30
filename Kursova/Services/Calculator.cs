namespace Kursova.Services
{
    public static class Calculator
    {
        // Метод для отримання тарифу
        public static decimal GetTariff(string serviceType)
        {
            return serviceType switch
            {
                "Електроенергія" => 4.32m,
                "Газ" => 7.96m,
                "Вода" => 30.38m,
                _ => throw new System.ArgumentException("Невідомий тип послуги")
            };
        }

        // Метод для розрахунку платежу
        public static decimal CalculatePayment(string serviceType, decimal current, decimal previous)
        {
            decimal tariff = GetTariff(serviceType); // Використовуємо GetTariff

            if (current < previous)
                throw new System.ArgumentException("Поточні показники не можуть бути меншими за попередні!");

            return (current - previous) * tariff;
        }
    }
}