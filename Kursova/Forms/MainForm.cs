using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Kursova.Models;
using Kursova.Services;

namespace Kursova
{
    public partial class MainForm : Form
    {
        private User _currentUser;
        private readonly Color _darkBackColor = Color.FromArgb(30, 30, 30);
        private readonly Color _darkForeColor = Color.WhiteSmoke;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            ApplyDarkTheme();
            InitializeDataGridView();
            LoadPayments();
            dtpPaymentDate.Value = DateTime.Now;
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = _darkBackColor;
            this.ForeColor = _darkForeColor;

            foreach (Control control in this.Controls)
            {
                control.BackColor = _darkBackColor;
                control.ForeColor = _darkForeColor;

                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(70, 70, 70);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Gray;
                }
                else if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = _darkBackColor;
                    dgv.DefaultCellStyle.BackColor = _darkBackColor;
                    dgv.DefaultCellStyle.ForeColor = _darkForeColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                    dgv.EnableHeadersVisualStyles = false;
                }
            }
        }

        private void InitializeDataGridView()
        {
            dgvPayments.Columns.Clear();
            dgvPayments.Columns.Add("Date", "Дата");
            dgvPayments.Columns.Add("ServiceType", "Послуга");
            dgvPayments.Columns.Add("Amount", "Сума");
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbServiceType.SelectedItem == null)
                    throw new Exception("Оберіть тип послуги!");

                if (!decimal.TryParse(txtPrevious.Text, out decimal prev) ||
                    !decimal.TryParse(txtCurrent.Text, out decimal curr))
                    throw new Exception("Невірний формат даних!");

                if (curr <= prev)
                    throw new Exception("Поточні показники мають бути більшими!");

                string serviceType = cmbServiceType.SelectedItem.ToString();
                decimal amount = Calculator.CalculatePayment(serviceType, curr, prev);
                decimal tariff = Calculator.GetTariff(serviceType);

                var payment = new Payment
                {
                    Date = dtpPaymentDate.Value,
                    ServiceType = serviceType,
                    PreviousReading = prev,
                    CurrentReading = curr,
                    Tariff = tariff,
                    Amount = amount
                };

                _currentUser.Payments.Add(payment);
                DatabaseService.UpdateUser(_currentUser);
                LoadPayments();
                
                txtCurrent.Clear();
                cmbServiceType.SelectedIndex = -1;
                
                MessageBox.Show($"Платіж успішно додано!\nСума: {amount} грн",
                                "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPayments()
        {
            dgvPayments.Rows.Clear();
            foreach (var payment in _currentUser.Payments.OrderByDescending(p => p.Date))
            {
                dgvPayments.Rows.Add(
                    payment.Date.ToString("dd.MM.yyyy"),
                    payment.ServiceType,
                    $"{payment.Amount:N2} грн"
                );
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            var filtered = _currentUser.Payments
                .Where(p => p.Date >= dtpStartDate.Value.Date && 
                            p.Date <= dtpEndDate.Value.Date)
                .OrderByDescending(p => p.Date)
                .ToList();

            dgvPayments.Rows.Clear();
            foreach (var payment in filtered)
            {
                dgvPayments.Rows.Add(
                    payment.Date.ToString("dd.MM.yyyy"),
                    payment.ServiceType,
                    $"{payment.Amount:N2} грн"
                );
            }
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            LoadPayments();
        }
    }
}