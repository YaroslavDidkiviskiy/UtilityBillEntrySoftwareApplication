using System;
using System.Windows.Forms;
using Kursova.Models;
using Kursova.Services;

namespace Kursova.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Перевірка співпадіння паролів
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Паролі не співпадають!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Перевірка унікальності логіну
                var users = DatabaseService.LoadUsers();
                if (users.Exists(u => u.Login == txtNewLogin.Text))
                {
                    MessageBox.Show("Користувач з таким логіном вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Створення нового користувача
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
                MessageBox.Show("Реєстрація успішна!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Закрити форму після реєстрації
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}