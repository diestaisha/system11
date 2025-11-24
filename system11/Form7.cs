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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Creamy milk tea with cookie bits for a sweet, crunchy delight.";
            richTextBox2.Text = "Smooth green tea latte with a subtle, earthy flavor.";
            richTextBox3.Text = "Rich brown sugar milk tea with a deep, caramelized taste.";
            richTextBox4.Text = "Sweet, nutty purple taro milk tea, smooth and comforting.";
            richTextBox5.Text = "Creamy milk tea with the signature sweet, cocoa-flavored twist.";
            richTextBox6.Text = "Fizzy and fruity with a burst of blueberry flavor.";
            richTextBox7.Text = "Refreshing sparkling strawberry soda.";
            richTextBox8.Text = "Tangy and zesty lemon soda, crisp and invigorating.";
            richTextBox9.Text = "Sweet and tart sparkling green apple drink.";
            richTextBox10.Text = "Tropical, tangy, and refreshing sparkling passion fruit.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Fruit Soda";  // ComboBox1
            order.SelectedFlavor = "Blueberry";       //combobox2
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Fruit Soda";  // ComboBox1
            order.SelectedFlavor = "Strawberry";       //combobox2
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Fruit Soda";  // ComboBox1
            order.SelectedFlavor = "Lemon";       //combobox2
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Fruit Soda";  // ComboBox1
            order.SelectedFlavor = "Green Apple";       //combobox2
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Fruit Soda";  // ComboBox1
            order.SelectedFlavor = "Passion Fruit";       //combobox2
            order.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Milk Tea";  // ComboBox1
            order.SelectedFlavor = "Cookies and Cream";       //combobox2
            order.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Milk Tea";  // ComboBox1
            order.SelectedFlavor = "Matcha";       //combobox2
            order.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Milk Tea";  // ComboBox1
            order.SelectedFlavor = "Okinawa";       //combobox2
            order.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Milk Tea";  // ComboBox1
            order.SelectedFlavor = "Taro";       //combobox2
            order.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Milk Tea";  // ComboBox1
            order.SelectedFlavor = "Red Velvet";       //combobox2
            order.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form11 pa = new Form11();
            pa.Show();
        }
    }
}
