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
    public partial class Form14 : Form
    {
        
        public Form14()
        {


            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;

            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Create columns for transaction details
            dataGridView1.Columns.Add("Cashier Full Name", "Cashier Full Name");
            dataGridView1.Columns.Add("IDNum", "ID Number");
            dataGridView1.Columns.Add("CustomerNumber", "Customer No.");
            dataGridView1.Columns.Add("Orders", "Orders");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns.Add("PaymentAmount", "Amount Paid");
            dataGridView1.Columns.Add("Change", "Change");
            dataGridView1.Columns.Add("PaymentMethod", "Payment Method");
            dataGridView1.Columns.Add("DineType", "Dine Type");
            dataGridView1.Columns.Add("Date", "Date & Time");

            // Clear old rows before adding new ones
            dataGridView1.Rows.Clear();

            //  Load data from the shared list of transactions
            int customerNumber = 1;

            foreach (var t in TransactionData.Transactions)
            {
                dataGridView1.Rows.Add(
                    t.FName + " " + t.LName,
                    t.IDNum,
                     $"Customer {customerNumber}",
                    t.Orders,
                    $"₱{t.Total}",
                    $"₱{t.PaymentAmount}",
                    $"₱{t.Change}",
                    t.PaymentMethod,
                    t.DineType,
                    t.Date.ToString("g")
                );

                customerNumber++;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
