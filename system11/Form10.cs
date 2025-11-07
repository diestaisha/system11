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
    public partial class Form10 : Form
    {
        int ulit = 3;
        public Form10()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
        }
        
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox3.Text;
            string idnum = textBox2.Text;

            string Comfirmpass = textBox4.Text;
            Comfirmpass = "12345678";

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(idnum))
            {
                MessageBox.Show("There is missing information");
                return;
            }

            if (idnum.Length != 4 || !idnum.All(char.IsDigit))
            {
                MessageBox.Show("ID number must be exactly 4 digits.");
                textBox2.Clear();
                return;
            }
            if (Comfirmpass.Length != 8 || !Comfirmpass.All(char.IsDigit))
            {
                MessageBox.Show("Password number must be exactly 8 digits.");

                return;



            }


            if (textBox4.Text == Comfirmpass)
            {
                Form1 Home = new Form1();
                Home.Show();
                MessageBox.Show("Log in successful");
            }
            else
            {
                ulit--;
                if (ulit > 0)
                {
                    MessageBox.Show("Wrong password! Attempts left: " + ulit);
                    textBox4.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Too many attempts! Access denied. The system will automatically close");
                    this.Close();
                }
            }


        
    }
    }
}
