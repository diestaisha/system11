using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system11
{
    public partial class Form13 : Form
    {
        private ListBox.SelectedObjectCollection selectedItems;
        public float totalf, total;

        public Form13(ListBox.ObjectCollection items)
        {
            InitializeComponent();

            // Add items passed from previous form
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }

            // Add dine in/take out options
            comboBox1.Items.Add("Dine In");
            comboBox1.Items.Add("Take Out");

            // Add payment method options
            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adjust available payment methods based on dine type
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable payment boxes based on method
            if (comboBox2.Text == "Cash")
            {
                textBox1.Enabled = false; // card number box disabled
                textBox3.Enabled = true;  // cash payment box enabled
            }
            else
            {
                textBox1.Enabled = true;  // card number required
                textBox3.Enabled = false; // no cash input needed
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float total = 0;
            string dineType = comboBox1.Text;
            string paymentMethod = comboBox2.Text;

            // Find the total from listbox
            foreach (string item in listBox1.Items)
            {
                if (item.StartsWith("Total: ₱"))
                {
                    string priceText = item.Replace("Total: ₱", "");
                    if (float.TryParse(priceText, out float totalValue))
                    {
                        total = totalValue;
                    }
                    break;
                }
            }

            // CASH PAYMENT
            if (paymentMethod == "Cash")
            {
                if (float.TryParse(textBox3.Text, out float payment))
                {
                    float change = payment - total;
                    if (change < 0)
                    {
                        MessageBox.Show("Not enough payment!", "Payment Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
                        return;
                    }

                    // Display payment info
                    listBox1.Items.Add("Payment Method: Cash");
                    listBox1.Items.Add($"Payment: ₱{payment}");
                    listBox1.Items.Add($"Change: ₱{change}");
                    listBox1.Items.Add("Thank you for ordering, come again!");

                    // SAVE TRANSACTION
                    string allOrders = string.Join(", ", listBox1.Items.Cast<string>());
                    TransactionData.Transactions.Add(new TransactionData
                    {
                        FName = TransactionData.CurrentFName,
                        LName = TransactionData.CurrentLName,
                        IDNum = TransactionData.CurrentID,
                        Orders = allOrders,
                        Total = total,
                        PaymentAmount = payment,
                        Change = change,
                        PaymentMethod = paymentMethod,
                        DineType = dineType,
                        Date = DateTime.Now
                    });

                    MessageBox.Show("Transaction saved successfully!", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
            }

            // CARD PAYMENT (Credit or Debit)
            else if (paymentMethod == "Credit Card" || paymentMethod == "Debit Card")
            {
                listBox1.Items.Add($"Payment Method: {paymentMethod}");
                listBox1.Items.Add($"Amount Charged: ₱{total}");
                listBox1.Items.Add("Payment Approved");
                listBox1.Items.Add("Thank you for ordering, come again!");

                // STEP 3: SAVE TRANSACTION
                string allOrders = string.Join(", ", listBox1.Items.Cast<string>());
                TransactionData.Transactions.Add(new TransactionData
                {
                    FName = TransactionData.CurrentFName,
                    LName = TransactionData.CurrentLName,
                    IDNum = TransactionData.CurrentID,
                    Orders = allOrders,
                    Total = total,
                    PaymentAmount = total,
                    Change = 0,
                    PaymentMethod = paymentMethod,
                    DineType = dineType,
                    Date = DateTime.Now
                });

                MessageBox.Show("Transaction saved successfully!", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

     
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
