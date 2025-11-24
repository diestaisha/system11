// Importing namespaces – these allow you to use prebuilt .NET features
using System;                      // Provides basic system functions (e.g., Console, Convert, Math)
using System.Collections.Generic;  // Enables the use of collections like List, Dictionary, etc.
using System.ComponentModel;       // Supports component and control behavior (mainly for WinForms)
using System.Data;                 // Used when working with databases or DataTables
using System.Drawing;              // Allows the use of graphics, colors, fonts, etc.
using System.Linq;                 // Enables LINQ queries, used for checking conditions like .All()
using System.Text;                 // Provides tools for working with text encoding
using System.Threading.Tasks;      // Enables asynchronous programming
using System.Windows.Forms;        // Core library for creating Windows Forms applications (UI)

namespace system11                // Defines a namespace to group related classes together
{
    public partial class Form10 : Form  // Declares Form10 class that inherits from the base Form class
    {
        int ulit = 3;             // Counter for login attempts (starts with 3)
        string fname, lname;      // Variables to store user's first and last name
        int idnum;                // Variable to store user's ID number

        public Form10()           // Constructor – runs when Form10 is created
        {
            InitializeComponent();           // Automatically generated method that sets up form controls
            textBox4.PasswordChar = '*';     // Masks password characters with '*' in the password box
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // Executes when the form is loaded – currently empty
        }

        // These methods trigger when their respective text boxes’ text changes
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }

        // Executes when the Login button (button1) is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            fname = textBox1.Text;                      // Get First Name
            lname = textBox3.Text;                      // Get Last Name
            idnum = Convert.ToInt32(textBox2.Text);     // Convert ID from text to integer

            string Comfirmpass = textBox4.Text;         // Get entered password
            Comfirmpass = "12345678";                   // Set the correct password for comparison

            // 1️⃣ Check if any field is empty
            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(idnum.ToString()))
            {
                MessageBox.Show(                         // Display a warning message
                    "There is missing information.",
                    "Missing Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;  // Stop the code here and return to the form
            }

            // 2️⃣ Check if ID is exactly 4 digits and contains only numbers
            if (idnum.ToString().Length != 4 || !idnum.ToString().All(char.IsDigit))
            {
                MessageBox.Show(
                    "ID number must be exactly 4 digits.",
                    "Invalid ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                textBox2.Clear();  // Clear the ID textbox
                return;
            }

            // 3️⃣ Check if password is exactly 8 digits and numeric
            if (Comfirmpass.Length != 8 || !Comfirmpass.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Password number must be exactly 8 digits.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // 4️⃣ Compare entered password with the correct password
            if (textBox4.Text == Comfirmpass)
            {
                // Store user information in TransactionData (a shared static class)
                TransactionData.CurrentFName = fname;
                TransactionData.CurrentLName = lname;
                TransactionData.CurrentID = idnum;

                // Open the next form (Home)
                Form1 Home = new Form1();
                Home.Show();

                // Show success message
                MessageBox.Show(
                    "Log in successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                // 5️⃣ If password is incorrect
                ulit--;  // Decrease remaining attempts
                if (ulit > 0)
                {
                    MessageBox.Show(
                        "Wrong password! Attempts left: " + ulit,
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    textBox4.Clear(); // Clear password field for re-entry
                    return;
                }
                else
                {
                    // If no attempts left, show error and close the system
                    MessageBox.Show(
                        "Too many attempts! Access denied. The system will automatically close.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    this.Close(); // Close the form/application
                }
            }
        }
    }
}
