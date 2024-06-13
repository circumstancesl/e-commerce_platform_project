using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            // Реализация интеграции с PayPal
        }
    }

    public class CreditCardGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            // Реализация интеграции с кредитной картой
        }
    }

    public class OrderProcessor
    {
        private IPaymentGateway paymentGateway;

        public OrderProcessor(IPaymentGateway paymentGateway)
        {
            this.paymentGateway = paymentGateway;
        }

        public void ProcessOrder(decimal amount)
        {
            // Обработка платежа через выбранный шлюз
            paymentGateway.ProcessPayment(amount);
        }
    }

}
