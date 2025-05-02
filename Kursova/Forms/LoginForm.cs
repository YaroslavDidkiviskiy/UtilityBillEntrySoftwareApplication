using Kursova.Services;
using System.Windows.Forms;

namespace Kursova.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            // Стилізація відповідно до UserForm
            txtLogin.BackColor = Color.FromArgb(70, 70, 70);
            txtLogin.ForeColor = Color.White;
            txtPassword.BackColor = Color.FromArgb(70, 70, 70);
            txtPassword.ForeColor = Color.White;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var users = DatabaseService.LoadUsers();
            var user = users.Find(u => u.Login == txtLogin.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                if (user.IsAdmin)
                {
                    new AdminForm().Show();
                }
                else
                {
                    new UserForm(user).Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}