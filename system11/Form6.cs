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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Chilled version of the classic, combining espresso, milk, and light foam.";
            richTextBox2.Text = "Iced espresso layered with milk and caramel syrup for a sweet, silky treat.";
            richTextBox3.Text = "Iced matcha blended with milk and coffee for a refreshing, creamy, and energizing drink.";
            richTextBox4.Text = "Sweet and creamy iced latte made with espresso and condensed milk.";
            richTextBox5.Text = "Iced coffee infused with rich caramel flavor and a touch of salt for balance.";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Cold Coffee";  // ComboBox1
            order.SelectedFlavor = "Cappucino";       //combobox2
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Cold Coffee";  // ComboBox1
            order.SelectedFlavor = "Caramel Machiatto";       //combobox2
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Cold Coffee";  // ComboBox1
            order.SelectedFlavor = "Matcha";       //combobox2
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Cold Coffee";  // ComboBox1
            order.SelectedFlavor = "Spanish Latte";       //combobox2
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.SelectedDrinkType = "Cold Coffee";  // ComboBox1
            order.SelectedFlavor = "Salted Caramel";       //combobox2
            order.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 nextfrap = new Form8();
            nextfrap.Show();
        }
    }
}
