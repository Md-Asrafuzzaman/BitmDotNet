using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShopHome : Form
    {
        public CoffeeShopHome()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string customer_name = customerNameTextBox.Text;
            string contact_no = contactTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int price;
            double total_price;
            if (order == "Black Coffee")
            {
                price = 120;
                total_price = price * quantity;
            }
            else if (order == "Cold Coffee")
            {
                price = 100;
                total_price = price * quantity;
            }
            else if (order == "Hot Coffee")
            {
                price = 90;
                total_price = price * quantity;
            }
            else if (order == "Regular Coffe")
            {
                price = 80;
                total_price = price * quantity;
            }
            else
            {
                price = 0;
                total_price = price * quantity;
            }

            customerNameLabel.Text= ("Customer Name : ")+customer_name;
            contactNoLabel.Text = ("Contact No : ") + contact_no;
            addressLabel.Text = ("Address : ") + address;
            orderLabel.Text = ("Order : ") + order;
            quantityLabel.Text = ("Quantity : ") + quantity.ToString();
            totalPriceLabel.Text = ("Total Price : ") + total_price.ToString();
        }
    }
}
