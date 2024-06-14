using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Catalog : Form, IView
    {
        private readonly Creator _creator;
        private ShoppingCart _shoppingCart;
        public Catalog()
        {
            InitializeComponent();
            _creator = new Creator(this, new CatalogFill());
            _shoppingCart = new ShoppingCart(cartListBox);
        }

        public string GetSelectedItemPrice()
        {
            int selectedIndex = ContentList.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < ContentList.Items.Count)
            {
                string selectedItem = ContentList.Items[selectedIndex].ToString();
                string[] parts = selectedItem.Split(new[] { " . " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    return parts[1];
                }
            }
            return string.Empty;
        }

        private void AddInCorzineButton_Click(object sender, EventArgs e)
        {
            string selectedItem = ContentList.SelectedItem.ToString();
            string price = GetSelectedItemPrice();
            string itemWithPrice = $"{selectedItem} . {price}";
            _shoppingCart.AddToCart(itemWithPrice);
            UpdateTotalPriceLabel();
        }

        private void CorzineButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            ContentList.Items.Clear();
            UpdateContent(sender, e);
        }
        public void AddContentList(string content)
        {
            ContentList.Items.Add(content);
        }
        public void AddPriceList(string price)
        {
            PriceList.Items.Add(price);
        }

        private void UpdateTotalPriceLabel()
        {
            decimal totalPrice = _shoppingCart.GetTotalPrice();
            totalPriceLabel.Text = $"Общая цена: {totalPrice} рублей";
        }

        public event EventHandler<EventArgs> UpdateContent;
    }
    public interface IView
    {
        void AddContentList(string content);
        void AddPriceList(string price);
        event EventHandler<EventArgs> UpdateContent;
    }

    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
