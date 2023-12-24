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
            string customerName = tbCustomerName.Text;
            var dateOut = dtRented.Value;
            var dateIn = dtReturned.Value;
            var carType = string.Empty;    //cbCarType.SelectedItem.ToString();
            double cost = Convert.ToDouble(value: tbCost.Text);

            var isValid = true;

            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
            {
                isValid = false;
                MessageBox.Show("Please enter missing data!");
            }

            if (dateOut > dateIn)
            {
                isValid = false;
                MessageBox.Show("Invalid date selection!");
            }

            if (isValid == true)
            {

            MessageBox.Show($"Customer Name: {customerName} \n\r" +
                $"Date Rented: {dateOut} \n\r" +
                $"Dte Returned: {dateIn}\n\r" +
                $"Car Type: {carType}\n\r" +
               $"Cost: {cost}" +
                $"THANK YOU FOR YOUR SUPPORT {customerName}!");
            }

        }

    }
}
