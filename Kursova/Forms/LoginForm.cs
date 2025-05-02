using Kursova.Services;

namespace Kursova.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Кнопка для логіну з if-виразом для визначення чи у юзера isAdmin=True
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

        //  відкриття форми RegistrationForm для реєстрації
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog(); // Відкрити форму реєстрації
        }
    }
}