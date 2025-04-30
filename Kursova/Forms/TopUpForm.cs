using System.Windows.Forms;
using Kursova.Models;

namespace Kursova.Forms
{
    public partial class TopUpForm : Form
    {
        public User UpdatedUser { get; }
        private TextBox txtAmount;
        private Button btnConfirm;

        public TopUpForm(User user)
        {
            UpdatedUser = user;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "Поповнення балансу";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            txtAmount = new TextBox
            {
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(200, 30),
                PlaceholderText = "Сума поповнення"
            };
            this.Controls.Add(txtAmount);

            btnConfirm = new Button
            {
                Text = "Поповнити",
                Location = new System.Drawing.Point(50, 100),
                Size = new System.Drawing.Size(200, 40),
                BackColor = System.Drawing.Color.FromArgb(0, 123, 255),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnConfirm.Click += BtnConfirm_Click;
            this.Controls.Add(btnConfirm);
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
                MessageBox.Show("Введіть коректну суму!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}