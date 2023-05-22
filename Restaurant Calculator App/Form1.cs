// Tanner Akers 10/29/2022
// CIS262AD - Fall 2022
// Class 19105
// Simple Restaurant Bill calculator, all prices and item names are initialized and indexed with the comboboxes in the designer source file as string arrays, added overview box for asthetics 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Calculator_App
{

    
    public partial class BillCalc : Form
    {
        public BillCalc()
        {
            InitializeComponent();
        }

        // instance variables initialized at execution to hold sums and a immutable value for the tax

        const double Tax = 0.0725;
        private double baseBill = 0.00;
        public double totalBill = 0.00;


        // Once invoked from the event handlers below, I made a Get Price method that splits the indexed strings from each combo box selection after the user makes a selection 
        // Also adds the newly formatted values to the listbox as strings

        private void GetPrice(string items)
        {
            string item = items.Split('$')[0];
            double price = Convert.ToDouble(items.Split('$')[1]);
            baseBill += price;
            overviewlistBox.Items.Add($"{item}: " + $"{price:C}");
        }

        // Update Bill method that updates readonly text box fields, calcluates tax and formats fields as monetary values
        private void UpdateBill()
        {
            
            textBox1.Text = baseBill.ToString("C2");
            double updatedTax = Tax * baseBill;
            textBox2.Text = updatedTax.ToString("C2");
            double updatedBill = baseBill + updatedTax;
            textBox3.Text = updatedBill.ToString("C2");
        }

        // One event handler for all 4 combo boxes, Main course, Beverage, Appetizer and Dessert
        // passes the sender object to the Get Price method immediately upon clicking utilizing the SelectedItem property and toString method
        private void dropdownSelected(object sender, EventArgs e)
        {
            
            if (sender == mainCombo)
                GetPrice(mainCombo.SelectedItem.ToString());

            if (sender == bevCombo)
                GetPrice(bevCombo.SelectedItem.ToString());

            if (sender == appeCombo)
                GetPrice(appeCombo.SelectedItem.ToString());

            if (sender == dessCombo)
                GetPrice(dessCombo.SelectedItem.ToString());

            UpdateBill();

        }

        // Simple Clear button event handler, sets all updated fields to zero and clears listbox 
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            baseBill = 0.00;
            textBox2.Clear();
            
            textBox3.Clear();
            textBox1.Text = baseBill.ToString("C2");
            textBox3.Text = totalBill.ToString("C2");

            mainCombo.Text = " ";
            bevCombo.Text = " ";
            appeCombo.Text = " ";
            dessCombo.Text = " ";

            overviewlistBox.Items.Clear();
        }
    }
}
