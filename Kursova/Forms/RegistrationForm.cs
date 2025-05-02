using Kursova.Models;
using Kursova.Services;
using System.Windows.Forms;

namespace Kursova.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            this.BackColor = Color.FromArgb(30, 30, 70);
            panelMain.BackColor = Color.FromArgb(50, 50, 90);
            lblTitle.ForeColor = Color.White;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 98, 204);
            btnBackToLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 120);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Паролі не співпадають!", "Помилка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var users = DatabaseService.LoadUsers();
                if (users.Exists(u => u.Login == txtNewLogin.Text))
                {
                    MessageBox.Show("Користувач з таким логіном вже існує!", "Помилка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newUser = new User
                {
                    FullName = txtFullName.Text,
                    Address = txtAddress.Text,
                    Login = txtNewLogin.Text,
                    Password = txtNewPassword.Text,
                    Balance = 0,
                    IsAdmin = false
                };

                users.Add(newUser);
                DatabaseService.SaveUsers(users);
                MessageBox.Show("Реєстрація успішна!", "Інформація", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}