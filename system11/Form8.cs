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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Creamy coffee blended with ice and rich caramel syrup for a sweet, smooth treat.";
            richTextBox2.Text = "Iced matcha mixed with milk and ice for a refreshing, earthy, and creamy drink.";
            richTextBox3.Text = "Coffee frappe with a nutty hazelnut twist, perfectly sweet and creamy.";
            richTextBox4.Text = "Chilled coffee and chocolate blended with ice for a rich, chocolaty delight.";
            richTextBox5.Text = "Coffee frappe with chocolate chips blended in for a crunchy, chocolate-packed experience.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 order = new Form2();
            order.SelectedDrinkType = "Frappe";  // ComboBox1
            order.SelectedFlavor = "Caramel";
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 order = new Form2();
            order.SelectedDrinkType = "Frappe";  // ComboBox1
            order.SelectedFlavor = "Matcha";
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 order = new Form2();
            order.SelectedDrinkType = "Frappe";  // ComboBox1
            order.SelectedFlavor = "Hazelnut";
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form2 order = new Form2();
            order.SelectedDrinkType = "Frappe";  // ComboBox1
            order.SelectedFlavor = "Mocha";
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form2 order = new Form2();
            order.SelectedDrinkType = "Frappe";  // ComboBox1
            order.SelectedFlavor = "Java Chip";
            order.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form7 nextmf = new Form7();
            nextmf.Show();
        }
    }
}
