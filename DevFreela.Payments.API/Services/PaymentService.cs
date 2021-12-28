using System.Threading.Tasks;
using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            // Processa o pagamento

            return Task.FromResult(true);
        }
    }
}