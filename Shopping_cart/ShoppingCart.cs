using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class ShoppingCart : IView
    {
        private List<string> cartItems = new List<string>();
        private ListBox cartListBox; // Ссылка на ListBox в корзине

        public ShoppingCart(ListBox listBox)
        {
            cartListBox = listBox;
        }

        public void AddToCart(string item)
        {
            cartItems.Add(item);
            UpdateCart();
            UpdateTotalPrice();
        }

        private void UpdateCart()
        {
            cartListBox.Items.Clear();
            foreach (var item in cartItems)
            {
                cartListBox.Items.Add(item);
            }
        }

        public void AddContentList(string content)
        {

        }

        public void AddPriceList(string price)
        {

        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (string item in cartItems)
            {
                string[] parts = item.Split(new[] { " . " }, StringSplitOptions.None);
                if (parts.Length == 3 && decimal.TryParse(parts[2], out decimal price))
                {
                    totalPrice += price;
                }
            }
            return totalPrice;
        }

        public void UpdateTotalPrice()
        {
            decimal totalPrice = GetTotalPrice();
        }

        public event EventHandler<EventArgs> UpdateContent;
    }
}
