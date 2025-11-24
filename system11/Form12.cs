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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = "Crunchy snack with melted cheese inside.";
            richTextBox3.Text = "Crispy golden potato sticks served hot.";
            richTextBox4.Text = "Steamed pork dumplings served with soy and chili sauce.";
            richTextBox5.Text = "Flavorful meat wrapped in pita with fresh veggies and creamy sauce.";
            richTextBox6.Text = "Japanese octopus balls topped with savory sauce and bonito flakes.";
            richTextBox8.Text = "Savory dumplings with a light, delicate Japanese twist.";
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Form1 snack = new Form1();
            snack.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 order3 = new Form3();
            order3.SelectedSnack = "Cheese stick + ₱20";  // ComboBox3
            order3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 order3 = new Form3();
            order3.SelectedSnack = "Fries + ₱20";  // ComboBox3
            order3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 order3 = new Form3();
            order3.SelectedSnack = "Pork Siomai + ₱20";  // ComboBox3
            order3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 order3 = new Form3();
            order3.SelectedSnack = "Shawarma + ₱70";  // ComboBox3
            order3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 order3 = new Form3();
            order3.SelectedSnack = "Takoyaki";  // ComboBox3
            order3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 order3 = new Form3();
            order3.SelectedSnack = "Japanese Siomai + ₱30";  // ComboBox3
            order3.Show();
        }
    }
}
