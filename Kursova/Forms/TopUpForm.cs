using Kursova.Models;


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
            // Додаткові стилізації
            txtAmount.Font = new Font("Segoe UI", 11F);
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                UpdatedUser.Balance += amount;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть коректну суму більше нуля!", "Помилка вводу", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
            }
        }
    }
}