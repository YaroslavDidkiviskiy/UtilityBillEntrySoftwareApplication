namespace Kursova.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

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
            this.Text = "Авторизація";

            // Додавання Label з назвою програми
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "Програмний застосунок введення розрахунків за комунальні платежі";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Size = new System.Drawing.Size(400, 60);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblTitle);

            // Поля для авторизації
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtLogin.Location = new System.Drawing.Point(50, 100);
            this.txtLogin.Size = new System.Drawing.Size(350, 30);
            this.txtLogin.PlaceholderText = "Логін";
            this.Controls.Add(this.txtLogin);

            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword.Location = new System.Drawing.Point(50, 150);
            this.txtPassword.Size = new System.Drawing.Size(350, 30);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "Пароль";
            this.Controls.Add(this.txtPassword);

            // Кнопка входу
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogin.Text = "Увійти";
            this.btnLogin.Location = new System.Drawing.Point(50, 200);
            this.btnLogin.Size = new System.Drawing.Size(350, 40);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(92, 184, 92);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.Controls.Add(this.btnLogin);

            // Кнопка реєстрації
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegister.Text = "Реєстрація";
            this.btnRegister.Location = new System.Drawing.Point(50, 250);
            this.btnRegister.Size = new System.Drawing.Size(350, 40);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.Controls.Add(this.btnRegister);
        }
    }
}