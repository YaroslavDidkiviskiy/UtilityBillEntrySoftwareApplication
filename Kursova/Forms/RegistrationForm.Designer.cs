namespace Kursova.Forms
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtNewLogin;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnBackToLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Налаштування форми
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";

            // Заголовок
            this.lblTitle = new Label();
            this.lblTitle.Text = "Реєстрація";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblTitle);

            // Поля для реєстрації
            this.txtFullName = CreateTextBox(50, 80, "ПІБ");
            this.txtAddress = CreateTextBox(50, 130, "Адреса");
            this.txtNewLogin = CreateTextBox(50, 180, "Новий логін");
            this.txtNewPassword = CreateTextBox(50, 230, "Новий пароль", true);
            this.txtConfirmPassword = CreateTextBox(50, 280, "Підтвердити пароль", true);

            // Кнопка реєстрації
            this.btnRegister = new Button();
            this.btnRegister.Text = "Зареєструватися";
            this.btnRegister.Location = new System.Drawing.Point(50, 340);
            this.btnRegister.Size = new System.Drawing.Size(350, 40);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(92, 184, 92);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.Controls.Add(this.btnRegister);

            // Кнопка повернення
            this.btnBackToLogin = new Button();
            this.btnBackToLogin.Text = "Повернутись до авторизації";
            this.btnBackToLogin.Location = new System.Drawing.Point(50, 390);
            this.btnBackToLogin.Size = new System.Drawing.Size(350, 40);
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.FlatStyle = FlatStyle.Flat;
            this.btnBackToLogin.Click += (s, e) => this.Close();
            this.Controls.Add(this.btnBackToLogin);
        }

        private TextBox CreateTextBox(int x, int y, string placeholder, bool isPassword = false)
        {
            var textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Size = new System.Drawing.Size(350, 30);
            textBox.PlaceholderText = placeholder;
            textBox.PasswordChar = isPassword ? '•' : default;
            this.Controls.Add(textBox);
            return textBox;
        }
    }
}