using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace system11
{
    public partial class Form3 : Form

    {

        int previousTotal; //  store total from Form3 (if any)
        bool hasPreviousTotal; // if form3 had total

        int total, dd1, dd2, dd3;
        private string snack;
        private object flavor;


        //will hold the type of PASTA,pastry and snack

        public string SelectedPasta { get; set; }
        public string SelectedPastry { get; set; }
        public string SelectedSnack { get; set; }

        public Form3()
        {
            InitializeComponent();

        }

        public Form3(ListBox.ObjectCollection items, int totalForm3, bool hasTotalForm3)
        {
            InitializeComponent();
         


            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }

            // Add items only once
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Cinnamon Roll + ₱55");
                comboBox1.Items.Add("Brownies + ₱35");
                comboBox1.Items.Add("Chocolate Chip Cookies + ₱45");
                comboBox1.Items.Add("Waffles + ₱30");
            }

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("Baked Mac + ₱55");
                comboBox2.Items.Add("Tuna Pesto + ₱65");
                comboBox2.Items.Add("Aglio E Olio + ₱65");
                comboBox2.Items.Add("Fettuccine Alfredo + ₱70");
            }

            if (comboBox3.Items.Count == 0)
            {
                comboBox3.Items.Add("Fries + ₱20");
                comboBox3.Items.Add("Takoyaki");
                comboBox3.Items.Add("Shawarma + ₱70");
                comboBox3.Items.Add("Cheese stick + ₱20");
                comboBox3.Items.Add("Pork Siomai + ₱20");
                comboBox3.Items.Add("Japanese Siomai + ₱30");
            }
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            //ilalabas yung na select sa button
            
            comboBox2.Text = SelectedPasta;
            comboBox1.Text = SelectedPastry;
            comboBox3.Text = SelectedSnack;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Enabled = true;

            if (comboBox3.Text == "Fries + ₱20")
            {
                comboBox4.Items.AddRange(new string[] { "Barbeque", "Cheese", "Sour Cream" });
            }
            else if (comboBox3.Text == "Cheese stick + ₱20")
            {
                comboBox4.Items.AddRange(new string[] { "Barbeque", "Cheese", "Sour Cream" });
            }
            else if (comboBox3.Text == "Shawarma + ₱70")
            {
                comboBox4.Items.AddRange(new string[] { "Original sauce", "Hummus Sauce", "Harissa Sauce" });
            }
            else if (comboBox3.Text == "Takoyaki")  // <-- Added this
            {
                comboBox4.Items.AddRange(new string[] { "Octopus + ₱85 for (4pcs)", "Bacon + ₱75 for (4pcs)", "Cheese + ₱65 for (4pcs)" });
            }
            else if (comboBox3.Text == "Pork Siomai + ₱20" || comboBox3.Text == "Japanese Siomai + ₱30")
            {
                comboBox4.Enabled = false;  // No flavor for Siomai
            }

            comboBox4.Text = string.Empty;  // Reset flavor selection
        
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null && comboBox3.SelectedItem == null && comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Please select at least one item to add.", "No Selection");
                return;
            }

            string pastry;
            if (comboBox1.SelectedItem != null)
                pastry = comboBox1.SelectedItem.ToString();
            else
                pastry = "";

            string pasta;
            if (comboBox2.SelectedItem != null)
                pasta = comboBox2.SelectedItem.ToString();
            else
                pasta = "";

            string snack;
            if (comboBox3.SelectedItem != null)
                snack = comboBox3.SelectedItem.ToString();
            else
            snack = "";

            string flavor;
            if (comboBox4.SelectedItem != null)
                flavor = comboBox4.SelectedItem.ToString();
            else
                flavor = "";


            // If any quantity (textbox) is 0, assume 1
            int qtyPastry;
            if (dd1 > 0)
                qtyPastry = dd1;
            else
                qtyPastry = 1;

            int qtyPasta;
            if (dd2 > 0)
                qtyPasta = dd2;
            else
                qtyPasta = 1;

            int qtySnack;
            if (dd3 > 0)
                qtySnack = dd3;
            else
                qtySnack = 1;

            //  Add pastry items based on quantity
            if (!string.IsNullOrEmpty(pastry))
            {
                for (int i = 0; i < qtyPastry; i++)
                {
                    listBox1.Items.Add(pastry);
                }
            }

            // 🔹 Add pasta items based on quantity
            if (!string.IsNullOrEmpty(pasta))
            {
                for (int i = 0; i < qtyPasta; i++)
                {
                    listBox1.Items.Add(pasta);
                }
            }

            // 🔹 Add snack items based on quantity
            if (!string.IsNullOrEmpty(snack))
            {
                for (int i = 0; i < qtySnack; i++)
                {
                    listBox1.Items.Add($"{snack} {flavor}");
                }
            }

            listBox1.Items.Add("------------------------------------------------------------");

            // Reset selections and quantities
            // Reset selections
            comboBox1.Text = string.Empty;  // Pastry
            comboBox2.Text = string.Empty;  // Pasta
            comboBox3.Text = string.Empty;  // Snack
            comboBox4.Text = string.Empty;  // Flavor


            dd1 = 0; dd2 = 0; dd3 = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

           
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            var delete = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(delete);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 pay = new Form13(listBox1.Items);
            pay.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dd2++;
            textBox2.Text = dd2.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {



                int peso = item.IndexOf('₱');
                if (peso != -1)
                {
                    string pricePart = item.Substring(peso + 1);
                    string number = "";

                    // get only the number part
                    foreach (char c in pricePart)
                    {
                        if (char.IsDigit(c))
                            number += c;
                        else
                            break;
                    }

                    if (number != "")
                        total += Convert.ToInt32(number);
                }
            }

            listBox1.Items.Add("Total: ₱" + (total));



            total = 0;

            // Loop through all list items
            foreach (string item in listBox1.Items)
            {
                // Skip separator lines or total lines
                if (item.StartsWith("Total:") || item.StartsWith("-") || string.IsNullOrWhiteSpace(item))
                    continue;

                // Look for every ₱ in the string
                int startIndex = 0;
                while (startIndex < item.Length)
                {
                    int pesoIndex = item.IndexOf('₱', startIndex);
                    if (pesoIndex == -1)
                        break;

                    // Get the number after ₱ until non-digit
                    string number = "";
                    for (int i = pesoIndex + 1; i < item.Length; i++)
                    {
                        if (char.IsDigit(item[i]))
                            number += item[i];
                        else
                            break;
                    }

                    if (int.TryParse(number, out int price))
                        total += price;

                    startIndex = pesoIndex + 1; // continue searching next ₱
                }
            }

            // Remove any existing total lines
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.Items[i].ToString().StartsWith("Total:"))
                    listBox1.Items.RemoveAt(i);
            }

            // Add new total line
            listBox1.Items.Add("Total: ₱" + total);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dd1++;
            textBox1.Text = dd1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dd1 > 0)
            {
                dd1--;
                textBox1.Text = dd1.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dd2 > 0)
            {
                dd2--;
                textBox2.Text = dd2.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dd3++;
            textBox3.Text = dd3.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dd3 > 0)
            {
                dd3--;
                textBox3.Text = dd3.ToString();
            }
        }
    }
}
