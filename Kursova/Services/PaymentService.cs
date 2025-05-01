using System.Linq;
using Kursova.Models;

namespace Kursova.Services
{
    public static class PaymentService
    {
        public static void ProcessPayment(User user, Payment payment)
        {
            if (user.Balance < payment.Amount)
                throw new System.Exception("Недостатньо коштів!");
            
            user.Balance -= payment.Amount;
            user.Payments.Add(payment);
            DatabaseService.UpdateUser(user);
        }

        public static Payment GetLastPayment(User user, string serviceType)
        {
            return user.Payments
                .Where(p => p.ServiceType == serviceType)
                .OrderByDescending(p => p.Date)
                .FirstOrDefault();
        }
    }
}