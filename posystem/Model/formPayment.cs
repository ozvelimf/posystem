using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posystem.Model
{
    public partial class formPayment : Sample
    {
        public formPayment()
        {
            InitializeComponent();
            discount.TextChanged += Discount_TextChanged;
        }

        public decimal totalAmount;
        public int user_id;
        public List<int> productList;
        public decimal totalAmountPayment;




        private void formPayment_Load(object sender, EventArgs e)
        {
            amount.Text = totalAmount.ToString() + " ₺";
            UpdateTotalAmountPay();

            for (int year = DateTime.Now.Year; year <= DateTime.Now.Year + 10; year++)
            {
                cardYear.Items.Add(year.ToString());
            }

            for (int month = 1; month <= 12; month++)
            {
                cardMonth.Items.Add(month.ToString("D2"));
            }


        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmountPay();
        }

        private void UpdateTotalAmountPay()
        {
            decimal disc;
            if (decimal.TryParse(discount.Text, out disc))
            {
                totalAmountPayment = totalAmount - disc;
                totalAmountPay.Text = totalAmountPayment.ToString() + " ₺";
            }
            else 
            { 
                disc = 0;
                totalAmountPayment = totalAmount - disc;
                totalAmountPay.Text = totalAmountPayment.ToString() + " ₺";
            }
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bool result = ValidatePaymentFields();
            if (result)
            {
                bool success = Function.SaveOrderData(user_id, productList, totalAmountPayment);
                if (success)
                {
                    MessageBox.Show("Your payment has been made successfully.");
                    Function.ClearCart(user_id);
                    productList.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the payment.");
                }
            }
        }

        private bool ValidatePaymentFields()
        {
            if (string.IsNullOrWhiteSpace(cardName.Text))
            {
                MessageBox.Show("Cardholder name cannot be empty.");
                return false;
            }

            if (cardName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Cardholder name cannot contain numbers.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cardNumber.Text))
            {
                MessageBox.Show("Card number cannot be empty.");
                return false;
            }

            if (!int.TryParse(cardNumber.Text, out _))
            {
                MessageBox.Show("Card number must be a valid integer.");
                return false;
            }

            if (cardYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid expiration year.");
                return false;
            }

            if (cardMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid expiration month.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cardCCV.Text))
            {
                MessageBox.Show("CCV cannot be empty.");
                return false;
            }

            if (!int.TryParse(cardCCV.Text, out _))
            {
                MessageBox.Show("CCV must be a valid integer.");
                return false;
            }

            return true;
        }

    }
}
