using Kursova.Models;
using Kursova.Services;

namespace Kursova.Services
{
    public static class PaymentService
    {
        public static void ProcessPayment(User user, Payment payment)
        {
            if (user.Balance < payment.Amount)
                throw new System.Exception("Недостатньо коштів на рахунку!");

            user.Balance -= payment.Amount;
            var payments = DatabaseService.LoadPayments();
            payments.Add(payment);
            DatabaseService.SavePayments(payments); // Використовуємо SavePayments
        }
    }
}