using Kursova.Models;
using System.Drawing;
using System.Windows.Forms;

namespace Kursova.Forms
{
    public partial class TopUpForm : Form
    {
        public User UpdatedUser { get; }

        public TopUpForm(User user)
        {
            UpdatedUser = user;
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            this.BackColor = Color.FromArgb(30, 30, 70);
            txtAmount.BackColor = Color.FromArgb(70, 70, 70);
            txtAmount.ForeColor = Color.White;
            lblInstruction.ForeColor = Color.White;
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                UpdatedUser.Balance += amount;
                
                // Повідомлення, коли рахунок поповнено успішно
                MessageBox.Show($"Баланс успішно поповнено на {amount} грн!\nНовий баланс: {UpdatedUser.Balance} грн", 
                    "Успішна операція", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Пропрацювання помилки, коли користувач вводить число менше 0
                MessageBox.Show("Введіть коректну суму більше нуля!", "Помилка вводу",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
            }
        }
    }
}