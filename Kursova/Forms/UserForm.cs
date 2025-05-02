using Kursova.Models;
using Kursova.Services;

namespace Kursova.Forms
{
    public partial class UserForm : Form
    {
        private User _currentUser;

        public UserForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Баланс: {_currentUser.Balance} грн";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbService.SelectedItem == null)
                    throw new Exception("Оберіть послугу!");

                if (!decimal.TryParse(txtPrevious.Text, out decimal prev) || 
                    !decimal.TryParse(txtCurrent.Text, out decimal curr))
                    throw new Exception("Невірний формат даних!");

                if (curr <= prev)
                    throw new Exception("Поточні показники мають бути більшими!");

                decimal tariff = Calculator.GetTariff(cmbService.Text);
                decimal amount = (curr - prev) * tariff;

                Payment payment = new Payment
                {
                    ServiceType = cmbService.Text,
                    PreviousReading = prev,
                    CurrentReading = curr,
                    Date = DateTime.Now,
                    Tariff = tariff,
                    Amount = amount
                };

                PaymentService.ProcessPayment(_currentUser, payment);
                UpdateBalanceLabel();
                MessageBox.Show($"Оплачено: {amount} грн", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTopUp_Click(object sender, EventArgs e)
        {
            using (var topUpForm = new TopUpForm(_currentUser))
            {
                if (topUpForm.ShowDialog() == DialogResult.OK)
                {
                    _currentUser = topUpForm.UpdatedUser;
                    UpdateBalanceLabel();
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}