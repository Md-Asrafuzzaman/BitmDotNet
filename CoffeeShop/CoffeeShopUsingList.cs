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
        int i;
        string message = "";

        public CoffeeShopUsingList()
        {
            InitializeComponent();
        }

        private void showCustomerInfoButton_Click(object sender, EventArgs e)
        {
            for (i = 0; i < names.Count(); i++)
            {
                message += "Customer Name : " + names[i] + "\nContact No: " + contacts[i] + "\nAddress : " + addresses[i]
                    + "\nOrder Item : " + orders[i] + "\nOrder Quantity : " + quantities[i];
            }
            MessageBox.Show(message);
        }

        private void customerInformationAddButton_Click(object sender, EventArgs e)
        {
           customer_Information_Assign_To_List();
           
        }

        //customer_Information_Assign_To_List
        private void customer_Information_Assign_To_List()
        {
            names.Add(customerNameTextBox.Text);
            contacts.Add(contactNoTextBox.Text);
            addresses.Add(addressTextBox.Text);
            if (!String.IsNullOrEmpty(orderIteamComboBox.Text) || !String.IsNullOrEmpty(orderQuantityTextBox.Text))
            {
                orders.Add(orderIteamComboBox.Text);
                quantities.Add(Convert.ToInt32(orderQuantityTextBox.Text));
            }
            else
                MessageBox.Show("Order Item and Order Quantity Field Required");
        }

        //customer_Information_Show_From_List

        private void customer_Information_Show_From_List()
        {
            for(i = 0; i < names.Count(); i++)
            {
                message += "Customer Name : " + names[i] + "\nContact No: " + contacts[i] + "\nAddress : " + addresses[i]
                    + "\nOrder Item : " + orders[i] + "\nOrder Quantity : " + quantities[i];
            }
        }


    }
}
