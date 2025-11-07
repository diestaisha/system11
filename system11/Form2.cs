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
    public partial class Form2 : Form

    {
        int pearl, nata, popping, noneads;

        int dd = 0;
        int total;

        //will hold the type of drink
        public string SelectedDrinkType { get; set; }
        //will hold the type of flavor
        public string SelectedFlavor { get; set; }

        string[] tea = { "Matcha", "Okinawa", "Red Velvet", "Cookies and Cream", "Taro" };
        public Form2()


        {
            InitializeComponent();
            //for Types of drink
            comboBox1.Items.Add("Hot Coffee");
            comboBox1.Items.Add("Ice Coffee");
            comboBox1.Items.Add("Frappe");
            comboBox1.Items.Add("Fruit Soda");
            comboBox1.Items.Add("Milk Tea");

            // choices sa ice/hot coffee
            comboBox3.Items.Add("Short: 12oz ₱49");
            comboBox3.Items.Add("Medio: 16oz ₱59");
            comboBox3.Items.Add("Grande: 20oz ₱69");

            //choices sa milk tea and Fruits soda
            comboBox3.Items.Add("Short: 12oz ₱29");
            comboBox3.Items.Add("Medio: 16oz ₱39");
            comboBox3.Items.Add("Grande: 20oz ₱49");

            //adds on
            comboBox5.Items.Add("Nata ₱15");
            comboBox5.Items.Add("Pearl ₱15");
            comboBox5.Items.Add("Popping Boba ₱15");
            comboBox6.Items.Add("Nata ₱15");
            comboBox6.Items.Add("Pearl ₱15");
            comboBox6.Items.Add("Popping Boba ₱15");

        }



        private void Form2_Load(object sender, EventArgs e)
        {
            //ilalabas yung na select sa button
            comboBox1.Text = SelectedDrinkType;
            comboBox2.Text = SelectedFlavor;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kahit pindutin yung combo box 1 hindi na sasama yung ibang choices ng iba
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();



            // para di masama yung sugar level
            comboBox6.Enabled = false;
            comboBox5.Enabled = false;
            comboBox3.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Text = ("Not Available");
            button1.Enabled = false;


            // para pag namili si user
            if (comboBox1.Text.Equals("Milk Tea"))
            {
                comboBox6.Enabled = true;
                comboBox5.Enabled = true;
                comboBox3.Enabled = true;
                textBox1.Enabled = true;
                textBox1.Text = (" ");
                button1.Enabled = true;
                // choices sa lahat ng size
                comboBox4.Items.Add("Short: 12oz ₱29.00");
                comboBox4.Items.Add("Medio: 16oz ₱39.00");
                comboBox4.Items.Add("Grande: 20oz ₱49.00");





                //choices sa  Milk Tea
                string[] tea = { "Matcha", "Okinawa", "Red Velvet", "Cookies and Cream", "Taro" };
                for (int i = 0; i < tea.Length; i++)
                {
                    comboBox2.Items.Add(tea[i]);

                }

                // add on

                comboBox5.Items.Add("Nata ₱15");
                comboBox5.Items.Add("Pearl ₱15");
                comboBox5.Items.Add("Popping Boba ₱15");

                comboBox6.Items.Add("Nata ₱15");
                comboBox6.Items.Add("Pearl ₱15");
                comboBox6.Items.Add("Popping Boba ₱15");





            }

            // sugar level  at kung na mili na sya ng choices sa sugar level 
            string[] l = { "25%", "50%", "75%", "100%" };
            for (int i = 0; i < l.Length; i++)
            {
                comboBox3.Items.Add(l[i]);
            }
            if (comboBox1.Text.Equals("Fruit Soda"))
            {
                comboBox6.Enabled = true;
                comboBox5.Enabled = true;

                // choices sa lahat ng size
                comboBox4.Items.Add("Short: 12oz ₱29.00");
                comboBox4.Items.Add("Medio: 16oz ₱39.00");
                comboBox4.Items.Add("Grande: 20oz ₱49.00");



                //choices sa Fruit Soda
                string[] fruits = { "Blue Berry Soda", "Strawberry Soda", "Green Apple Soda", "Lemon Soda", "Passion Fruit Soda" };
                for (int j = 0; j < fruits.Length; j++)
                {
                    comboBox2.Items.Add(fruits[j]);
                }

                // for add on
                string[] add1 = { "Nata ₱15", "Popping Boba  ₱15" };
                for (int i = 0; i < add1.Length; i++)
                {
                    comboBox5.Items.Add(add1[i]);
                    comboBox6.Items.Add(add1[i]);

                }


            }
            if (comboBox1.Text.Equals("Hot Coffee"))
            {



                // choices sa lahat ng size
                comboBox3.Items.Add("Short: 12oz ₱39.00");
                comboBox3.Items.Add("Medio: 16oz ₱49.00");
                comboBox3.Items.Add("Grande: 20oz ₱59.00");



                //choices sa Hot Coffee
                string[] hot = { "Americano", "White Coffee", "Matcha Latte", "Cappucino", "Dark Choco" };
                for (int j = 0; j < hot.Length; j++)
                {
                    comboBox2.Items.Add(hot[j]);
                }

            }
            if (comboBox1.Text == "Ice Coffee")
            {



                // choices sa lahat ng size
                comboBox3.Items.Add("Short: 12oz ₱39.00");
                comboBox3.Items.Add("Medio: 16oz ₱49.00");
                comboBox3.Items.Add("Grande: 20oz ₱59.00");

                //choices sa Ice Coffee
                string[] ice = { "Matcha", "Spanish latte", "Cappucino", "Caramel Macchiatto", "Salted Caramel" };
                for (int j = 0; j < ice.Length; j++)
                {
                    comboBox2.Items.Add(ice[j]);
                }

            }
            if (comboBox1.Text.Equals("Frappe"))
            {



                // choices sa lahat ng size
                comboBox3.Items.Add("Short: 12oz ₱49.00");
                comboBox3.Items.Add("Medio: 16oz ₱59.00");
                comboBox3.Items.Add("Grande: 20oz ₱69.00");





                //choices sa Frappe
                string[] f = { "Java Chip ", "Mocha", "Matcha", "Caramel", "Hazelnut" };
                for (int j = 0; j < f.Length; j++)
                {
                    comboBox2.Items.Add(f[j]);
                }





            }
        }






        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = (" ");
            button1.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // to user that can input the size he/she want and clear the textbox

            int input;

            // TryParse checks if the input can be converted to an int
            if (int.TryParse(textBox1.Text, out input))
            {
                // Add the number with a % sign to the ComboBox
                string newItem = input + "%";
                comboBox4.Items.Add(newItem);
                comboBox4.SelectedItem = newItem;

                // Clear the textbox
                textBox1.Clear();
            }
            else
            {
                // Show warning if not a valid number
                MessageBox.Show("Please enter a valid number only.");
                textBox1.Clear();
            }
        }

        /*int input = Convert.ToInt32(textBox1.Text);

        comboBox4.Items.Add(input + "%");
        comboBox4.SelectedItem = input;
        textBox1.Clear();*/



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null ||
       comboBox2.SelectedItem == null ||
       comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select all required options (Drink, Flavor, and Size).");
                return;
            }


            // Get all selected values
            string drinkType = comboBox1.SelectedItem.ToString();
            string flavor = comboBox2.SelectedItem.ToString();
            string size = comboBox3.SelectedItem.ToString();
            string sugar = comboBox4.SelectedItem != null ? comboBox4.SelectedItem.ToString() : " " + "No Sugar Selected";
            string addon = comboBox5.SelectedItem != null ? comboBox5.SelectedItem.ToString() : " " + "No Add-ons";
            string addon1 = comboBox6.SelectedItem != null ? comboBox5.SelectedItem.ToString() : " " + "No Add-ons";

            // If dd (quantity) is 0, assume 1
            int quantity = dd > 0 ? dd : 1;

            // Loop to add items based on quantity
            for (int i = 0; i < quantity; i++)
            {
                string order = $"{drinkType}  {flavor}  {sugar}";
                string order1 = $"{size}  {addon}  {addon1} ";
                listbox1.Items.Add(order);
                listbox1.Items.Add(order1);
                listbox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------");
            }

            // Reset combo boxes
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox5.Text = string.Empty;
            comboBox6.Text = string.Empty;

            // Reset quantity
            dd = 0;
            textBox2.Text = "0";


        }


        private void button4_Click(object sender, EventArgs e)
        {
            // makapag delete
            var delete = listbox1.SelectedIndex;
            listbox1.Items.RemoveAt(delete);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int totalForm3 = 0;
            bool hasTotalForm3 = false;

            // Check if Form3 already has a "Total:" line
            foreach (string item in listbox1.Items)
            {
                if (item.StartsWith("Total: ₱"))
                {
                    hasTotalForm3 = true;
                    string pricePart = item.Substring(item.IndexOf('₱') + 1);
                    int.TryParse(new string(pricePart.TakeWhile(char.IsDigit).ToArray()), out totalForm3);
                    break;
                }
            }

            // Open Form4 and pass the needed values
            Form3 pastry = new Form3(listbox1.Items, totalForm3, hasTotalForm3);
            pastry.StartPosition = FormStartPosition.CenterScreen;
            pastry.Show();
        }

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
            


        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Pearl ₱15 ")
            {
                pearl = 15;



            }
            if (comboBox5.Text == "Nata ₱15")
            {
                nata = 15;


            }
            if (comboBox5.Text == "Popping Boba ₱15")
            {
                popping = 15;

            }
            else
            {

                noneads = 0;


            }
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            int total = 0;


            if (comboBox5.Text == "Nata")
            {


            }



            foreach (string item in listbox1.Items)
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

            listbox1.Items.Add("Total: ₱" + (total + pearl + nata + popping + noneads));



            total = 0;

            // Loop through all list items
            foreach (string item in listbox1.Items)
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
            for (int i = listbox1.Items.Count - 1; i >= 0; i--)
            {
                if (listbox1.Items[i].ToString().StartsWith("Total:"))
                    listbox1.Items.RemoveAt(i);
            }

            // Add new total line
            listbox1.Items.Add("Total: ₱" + total);

        }
    
        private void button7_Click(object sender, EventArgs e)
        {
            if (dd > 0)
            {
                dd--;
                textBox2.Text = dd.ToString();
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            dd++;
            textBox2.Text = dd.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "Pearl ₱15 ")
            {
                pearl = 15;



            }
            if (comboBox6.Text == "Nata ₱15")
            {
                nata = 15;


            }
            if (comboBox6.Text == "Popping Boba ₱15")
            {
                popping = 15;

            }
            else
            {

                noneads = 0;


            }
        }

    }
}

