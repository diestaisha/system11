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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Smooth and bold espresso diluted with hot water for a clean, rich flavor.";
            richTextBox2.Text = "Creamy espresso with milk, offering a light and mellow taste.";
            richTextBox3.Text = "Earthy Japanese green tea blended with steamed milk for a smooth, calming drink.";
            richTextBox4.Text = "A balanced mix of espresso, steamed milk, and frothy foam for a velvety texture.";
            richTextBox5.Text = "Classic rich and creamy chocolate drink topped with warm froth or whipped cream.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Hot Coffee";  // ComboBox1
            order.SelectedFlavor = "Americano";       //combobox2
            order.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Hot Coffee";  // ComboBox1
            order.SelectedFlavor = "White  Coffee";
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Hot Coffee";  // ComboBox1
            order.SelectedFlavor = "Matcha Latte";       //combobox2
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Hot Coffee";  // ComboBox1
            order.SelectedFlavor = "Cappucino";       //combobox2
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Hot Coffee";  // ComboBox1
            order.SelectedFlavor = "Hot Chocolate";       //combobox2
            order.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 nextcold = new Form6();
            nextcold.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
