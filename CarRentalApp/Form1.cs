using System;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text.ToString();
            var dateOut = dtRented.Value;
            var dateIn = dtReturned.Value;
            string carType = cbCarType.SelectedItem.ToString();
           // var cost = Convert.ToDouble(tbCost.Text);    

            var isValid = true;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter a name!");
            }
            else if (string.IsNullOrWhiteSpace(carType)) 
            {
                MessageBox.Show("Please select a car type!");

            } 
            else if (dateOut > dateIn)
            {

                MessageBox.Show("Invalid date selection!");
            }
            //else if (cost == null)
            //{
              //  MessageBox.Show("Please enter cost!");
          //  }
            else if (isValid == true)
            {
                MessageBox.Show($"Customer Name: {customerName} \n\r" +
               $"Date Rented: {dateOut} \n\r" +
               $"Dte Returned: {dateIn}\n\r" +
               $"Car Type: {carType}\n\r" +
              //$"Cost: {cost}" +
               $"THANK YOU FOR YOUR SUPPORT {customerName}!");
            }            

           
        }

    }
}
