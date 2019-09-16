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
    public partial class CoffeShopUI : Form
    {
        public CoffeShopUI()
        {
            InitializeComponent();
        }

        private void customerInformationSaveButton_Click(object sender, EventArgs e)
        {
            //Variable Declaration With Array
            const int size = 3;
            string[] name = new string[size];
            string[] contact = new string[size];
            string[] address = new string[size];
            string[] order = new string[size];
            int[] quantity = new int[size];

            //Add Purchess Information to Array
            int i = 0;
            name[i] = customerNameTextBox.Text;
            contact[i] = contactNoTextBox.Text;
            address[i] = addressTextBox.Text;
            order[i] = orderItamComboBox.Text;
            quantity[i] = 1 * Convert.ToInt16(orderQuantityTextBox.Text);

            //Price Calculation 
            int price;
            double total_price;
            if (order[i] == "Black Coffee")
            {
                price = 120;
            }
            else if (order[i] == "Cold Coffee")
            {
                price = 100;

            }
            else if (order[i] == "Hot Coffee")
            {
                price = 90;
            }
            else if (order[i] == "Regular Coffee")
            {
                price = 80;
            }
            else
            {
                price = 0;
            }
            total_price = price * quantity[i];

            //Show the Purcess Information in RichTextBox
            string[] purcessInformation = new string[size];    
             purcessInformation[i] += "Customer Name : " + name[i] + "\nContact No : " + contact[i] + "\nAddress : "
                    + address[i] + "\nOrder Iteam : " + order[i] + "\nOrder Quantity : " + quantity[i]+"\nTotal Price : "+total_price+"\n\n";                
             purchessInformationRichTextBox.Text += purcessInformation[i];
            i++;           
        }
    }
}
