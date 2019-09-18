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
    public partial class CoffeeShopUsingList : Form
    {
        List<string> names = new List<string> { };
        List<string> contacts = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> orders = new List<string> { };
        List<int> quantities = new List<int> { };
        int i=0;
        string message = "";
        int price;
        int total_price;
        public CoffeeShopUsingList()
        {
            InitializeComponent();
        }

        //All Customer Information Show from List using this Method
        private void showCustomerInfoButton_Click(object sender, EventArgs e)
        {

            showInfoRichTextBox.Text = "Purchases Information : ";
            customer_Information_Show_From_List();
        }

        //Customer Information Added to List using this Method
        private void customerInformationAddButton_Click(object sender, EventArgs e)
        {
            customer_Information_Assign_To_List();
            customer_Information_Show_From_List_For_AddButton();
        }

        //customer_Information_Assign_To_List using this Method
        protected void customer_Information_Assign_To_List()
        {
            names.Add(customerNameTextBox.Text);
            contacts.Add(contactNoTextBox.Text);
            addresses.Add(addressTextBox.Text);
            if (!String.IsNullOrEmpty(orderIteamComboBox.Text) || !String.IsNullOrEmpty(orderQuantityTextBox.Text))
            {
                orders.Add(orderIteamComboBox.Text);
                quantities.Add(Convert.ToInt32(orderQuantityTextBox.Text));
                
                if (orders[i] == "Black Coffee")
                {
                    price = 120;
                }
                else if (orders[i] == "Cold Coffee")
                {
                    price = 100;

                }
                else if (orders[i] == "Hot Coffee")
                {
                    price = 90;
                }
                else if (orders[i] == "Regular Coffee")
                {
                    price = 80;
                }
                else
                {
                    price = 0;
                }
                total_price = price * quantities[i];
               
            }
            else
                MessageBox.Show("Order Item and Order Quantity Field Required");
            customer_Information_Reset_Method();
            
        }

        //All customer_Information_Raise_From_List
        private void customer_Information_Show_From_List()
        {
            for (i = 0; i < orders.Count(); i++)
            {
                message += "Customer Name : " + names[i] + "\nContact No: " + contacts[i] + "\nAddress : " + addresses[i]
                + "\nOrder Item : " + orders[i] + "\nOrder Quantity : " + quantities[i]+"\nTotal Price : "+total_price+"\n\n";
            }        
            showInfoRichTextBox.Text = message;
        }

        //customer_Information_Raise_From_List that are recently Added..................
        private void customer_Information_Show_From_List_For_AddButton()
        {
            message = "Customer Name : " + names[i] + "\nContact No: " + contacts[i] + "\nAddress : " + addresses[i]
                + "\nOrder Item : " + orders[i] + "\nOrder Quantity : " + quantities[i]+ "\nTotal Price : " + total_price + "\n\n";
            showInfoRichTextBox.Text = message;
            i++;
        }

        //customer_Information_reset_....
        private void customer_Information_Reset_Method()
        {
            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderIteamComboBox.Text = "";
            orderQuantityTextBox.Clear();
        }




    }
}
