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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Creamy macaroni baked with rich cheese sauce and a crispy golden crust.";
            richTextBox2.Text = "Classic Italian pasta sautéed with garlic, olive oil, and a touch of chili.";
            richTextBox3.Text = "Savory tuna tossed with aromatic basil pesto and al dente pasta.";
            richTextBox4.Text = "Silky fettuccine coated in a creamy Parmesan Alfredo sauce.";
            richTextBox5.Text = "Rich, fudgy chocolate squares with a decadent, melt-in-your-mouth texture.";
            richTextBox6.Text = "Soft, fluffy pastry swirled with cinnamon and topped with sweet cream glaze.";
            richTextBox7.Text = "Crisp on the edges, chewy inside, loaded with sweet chocolate chips.";
            richTextBox8.Text = "Golden and crispy on the outside, soft on the inside, served warm and delicious.";
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form12 snack = new Form12();
            snack.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPasta = "Baked Mac + ₱55";  // ComboBox2
            order2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPasta = "Aglio E Olio + ₱65";  // ComboBox2
            order2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPasta = "Tuna Pesto + ₱65";  // ComboBox2
            order2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPasta = "Fettuccine Alfredo + ₱70";  // ComboBox2
            order2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPastry = "Brownies + ₱35";  // ComboBox1
            order2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPastry = "Cinnamon Roll + ₱55";  // ComboBox1
            order2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPastry = "Chocolate Chips Cookies + ₱45";  // ComboBox1
            order2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 order2 = new Form3();
            order2.SelectedPastry = "Waffles + ₱30";  // ComboBox1
            order2.Show();
        }
    }
}
