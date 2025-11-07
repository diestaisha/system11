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
        private string? snack;
        private object flavor;

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
                comboBox1.Items.Add("Chocolate Chips Cookies + ₱45");
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
                comboBox3.Items.Add("Siomai + ₱20");
            }
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] a = { "Cinnamon Roll", "Brownies", "Chocolate Chips Cookies", "Chocolate Muffin", "Waffle" };
            for (int i = 0; i < a.Length; i++)
            {
                comboBox1.Items.Add(a[i]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();

            //Pasta
           
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("Baked Mac + ₱55 ");
                comboBox2.Items.Add("Tuna Pesto + ₱65");
                comboBox2.Items.Add("Aglio E Olio + ₱65");
                comboBox2.Items.Add("Fettuccine Alfredo + ₱70");
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();

            if (comboBox4.Text.Equals("Fries"))
            {
                string[] flavor = { "Barbeque", "Cheese", "Sour Cream" };
                for (int i = 0; i < flavor.Length; i++)
                {
                    comboBox4.Items.Add(flavor[i]);
                }
            }

            

            if (comboBox4.Text.Equals("Cheese stick + ₱20"))
            {
                string[] flavor1 = { "Barbeque", "Cheese", "Sour Cream" };
                for (int i = 0; i < flavor1.Length; i++)
                {
                    comboBox4.Items.Add(flavor1[i]);
                }
            }

            if (comboBox4.Text.Equals("Shawarma + ₱70"))
            {
                string[] flavor1 = { "Original sauce", "Hummus Sauce", "Harissa Sauce" };
                for (int i = 0; i < flavor1.Length; i++)
                {
                    comboBox4.Items.Add(flavor1[i]);
                }

            }
          
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text.Equals("Takoyaki"))
            {

                comboBox4.Items.Add("Octo + ₱85 for (4pcs)");
                comboBox4.Items.Add("Octo + ₱75 for (4pcs)");
                comboBox4.Items.Add("Cheese + ₱65 for (4pcs)");

            }
        }
        

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            if (comboBox4.Text.Equals("Fries"))
            {
                string[] flavor = { "Barbeque", "Cheese", "Sour Cream" };
                for (int i = 0; i < flavor.Length; i++)
                {
                    comboBox3.Items.Add(flavor[i]);
                }
            }

            if (comboBox4.Text.Equals("Takoyaki"))
            {
                string[] flavor = { " Octo", "Bacon", "Cheese" };
                for (int i = 0; i < flavor.Length; i++)
                {
                    comboBox3.Items.Add(flavor[i]);
                }
            }

            if (comboBox4.Text.Equals("cheese stick"))
            {
                string[] flavor1 = { "Barbeque", "Cheese", "Sour Cream" };
                for (int i = 0; i < flavor1.Length; i++)
                {
                    comboBox3.Items.Add(flavor1[i]);
                }
            }

            if (comboBox4.Text.Equals("Shawarma"))
            {
                string[] flavor1 = { "Original sauce", "Hummus Sauce", "Harissa Sauce" };
                for (int i = 0; i < flavor1.Length; i++)
                {
                    comboBox3.Items.Add(flavor1[i]);
                }
                
            }
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
            if (comboBox1.SelectedItem == null && comboBox4.SelectedItem == null && comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Please select at least one item to add.", "No Selection");
                return;
            }

            string pastry = comboBox1.SelectedItem?.ToString() ?? "";
            string pasta = comboBox4.SelectedItem?.ToString() ?? "";
          

            // If any quantity (textbox) is 0, assume 1
            int qtyPastry = dd1 > 0 ? dd1 : 1;
            int qtyPasta = dd2 > 0 ? dd2 : 1;
            int qtySnack = dd3 > 0 ? dd3 : 1;

            // 🔹 Add pastry items based on quantity
            if (!string.IsNullOrWhiteSpace(pastry))
            {
                for (int i = 0; i < qtyPastry; i++)
                {
                    listBox1.Items.Add(pastry);
                }
            }

            // 🔹 Add pasta items based on quantity
            if (!string.IsNullOrWhiteSpace(pasta))
            {
                for (int i = 0; i < qtyPasta; i++)
                {
                    listBox1.Items.Add(pasta);
                }
            }

            // 🔹 Add snack items based on quantity
            if (!string.IsNullOrWhiteSpace(snack))
            {
                for (int i = 0; i < qtySnack; i++)
                {
                    listBox1.Items.Add($"{snack} {flavor}");
                }
            }

            listBox1.Items.Add("------------------------------------------------------------");

            // Reset selections and quantities
            comboBox1.Text = string.Empty;
            comboBox4.Text = string.Empty;
           

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
