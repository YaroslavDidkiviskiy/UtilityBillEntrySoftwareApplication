namespace Kursova.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Panel panelMain;

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
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 70);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";

            // Основна панель
            this.panelMain = new Panel();
            this.panelMain.Size = new System.Drawing.Size(400, 400);
            this.panelMain.Location = new System.Drawing.Point(50, 50);
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(50, 50, 90);
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelMain);

            // Заголовок
            this.lblTitle = new Label();
            this.lblTitle.Text = "Комунальні платежі\nСистема управління";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Size = new System.Drawing.Size(350, 80);
            this.lblTitle.Location = new System.Drawing.Point(25, 30);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.panelMain.Controls.Add(this.lblTitle);

            // Поля вводу
            this.txtLogin = new TextBox();
            this.txtLogin.Location = new System.Drawing.Point(50, 150);
            this.txtLogin.Size = new System.Drawing.Size(300, 35);
            this.txtLogin.PlaceholderText = "Логін";
            this.txtLogin.BackColor = Color.FromArgb(70, 70, 70);
            this.txtLogin.ForeColor = Color.White;
            this.txtLogin.BorderStyle = BorderStyle.FixedSingle;
            this.txtLogin.Font = new Font("Segoe UI", 11F);
            this.panelMain.Controls.Add(this.txtLogin);

            this.txtPassword = new TextBox();
            this.txtPassword.Location = new System.Drawing.Point(50, 210);
            this.txtPassword.Size = new System.Drawing.Size(300, 35);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "Пароль";
            this.txtPassword.BackColor = Color.FromArgb(70, 70, 70);
            this.txtPassword.ForeColor = Color.White;
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.panelMain.Controls.Add(this.txtPassword);

            // Кнопки
            this.btnLogin = new Button();
            this.btnLogin.Text = "Увійти";
            this.btnLogin.Location = new System.Drawing.Point(50, 270);
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 98, 204);
            this.btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.panelMain.Controls.Add(this.btnLogin);

            this.btnRegister = new Button();
            this.btnRegister.Text = "Реєстрація";
            this.btnRegister.Location = new System.Drawing.Point(50, 330);
            this.btnRegister.Size = new System.Drawing.Size(300, 40);
            this.btnRegister.BackColor = Color.FromArgb(70, 70, 120);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 90);
            this.btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRegister.Cursor = Cursors.Hand;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.panelMain.Controls.Add(this.btnRegister);
        }
    }
}