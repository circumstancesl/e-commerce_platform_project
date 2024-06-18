using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string DeliveryMethod { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderStatus { get; set; }
    }

    // Интерфейс обработчика запросов на отмену/возврат заказа
    public interface IOrderHandler
    {
        void HandleRequest(Order order);
        IOrderHandler SetNextHandler(IOrderHandler handler);
    }

    // Конкретные обработчики запросов на отмену/возврат заказа
    public class CancelOrderHandler : IOrderHandler
    {
        private IOrderHandler _nextHandler;

        public void HandleRequest(Order order)
        {
            if (order.OrderStatus == "Pending")
            {
                Console.WriteLine($"Заказ {order.OrderId} отменен.");
                order.OrderStatus = "Canceled";
            }
            else
            {
                _nextHandler?.HandleRequest(order);
            }
        }

        public IOrderHandler SetNextHandler(IOrderHandler handler)
        {
            _nextHandler = handler;
            return this;
        }
    }

    public class ReturnOrderHandler : IOrderHandler
    {
        private IOrderHandler _nextHandler;

        public void HandleRequest(Order order)
        {
            if (order.OrderStatus == "Delivered")
            {
                Console.WriteLine($"Заказ {order.OrderId} возвращен.");
                order.OrderStatus = "Returned";
            }
            else
            {
                _nextHandler?.HandleRequest(order);
            }
        }

        public IOrderHandler SetNextHandler(IOrderHandler handler)
        {
            _nextHandler = handler;
            return this;
        }
    }

    // Класс, отвечающий за оформление заказа, выбор доставки и оплаты, отслеживание статуса
    public class OrderManager
    {
        private List<Order> _orders = new List<Order>();
        private IOrderHandler _cancelHandler;
        private IOrderHandler _returnHandler;

        public void PlaceOrder(int orderId, string customerName, decimal totalAmount, string deliveryMethod, string paymentMethod)
        {
            Order order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                TotalAmount = totalAmount,
                DeliveryMethod = deliveryMethod,
                PaymentMethod = paymentMethod,
                OrderStatus = "Pending"
            };

            _orders.Add(order);
            Console.WriteLine($"Заказ {order.OrderId} оформлен.");
        }

        public void SetOrderStatus(int orderId, string status)
        {
            var order = _orders.Find(o => o.OrderId == orderId);
            if (order != null)
            {
                order.OrderStatus = status;
                Console.WriteLine($"Статус заказа {order.OrderId} обновлен: {status}");
            }
        }

        public void CancelOrder(int orderId)
        {
            var order = _orders.Find(o => o.OrderId == orderId);
            if (order != null)
            {
                _cancelHandler.HandleRequest(order);
            }
        }

        public void ReturnOrder(int orderId)
        {
            var order = _orders.Find(o => o.OrderId == orderId);
            if (order != null)
            {
                _returnHandler.HandleRequest(order);
            }
        }

        public void SetCancelAndReturnHandlers()
        {
            _cancelHandler = new CancelOrderHandler();
            _returnHandler = new ReturnOrderHandler();
            _cancelHandler.SetNextHandler(_returnHandler);
        }
    }

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void forFullName_Click(object sender, EventArgs e)
        {

        }

        private void forFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void forEmail_Click(object sender, EventArgs e)
        {

        }

        private void forCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void forCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void forEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void forPhone_Click(object sender, EventArgs e)
        {

        }

        private void forPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void forCardTerm_Click(object sender, EventArgs e)
        {

        }

        private void forCVC_TextChanged(object sender, EventArgs e)
        {

        }

        private void forCVC_Click(object sender, EventArgs e)
        {

        }

        private void forCardTerm_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
