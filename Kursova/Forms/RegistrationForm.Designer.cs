namespace Kursova.Forms
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMain;
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
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";

            // Основна панель
            this.panelMain = new Panel();
            this.panelMain.Size = new System.Drawing.Size(450, 450);
            this.panelMain.Location = new System.Drawing.Point(25, 50);
            this.panelMain.BackColor = Color.FromArgb(50, 50, 90);
            this.panelMain.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelMain);

            // Заголовок
            this.lblTitle = new Label();
            this.lblTitle.Text = "Реєстрація";
            this.lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(180, 20);
            this.panelMain.Controls.Add(lblTitle);

            // Текстові поля
            int yPos = 70;
            this.txtFullName = CreateField("ПІБ", ref yPos);
            this.txtAddress = CreateField("Адреса", ref yPos);
            this.txtNewLogin = CreateField("Логін", ref yPos);
            this.txtNewPassword = CreateField("Пароль", ref yPos, true);
            this.txtConfirmPassword = CreateField("Підтвердити пароль", ref yPos, true);

            // Кнопки
            this.btnRegister = new Button();
            this.btnRegister.Text = "Зареєструватися";
            this.btnRegister.Location = new Point(50, 350);
            this.btnRegister.Size = new Size(350, 40);
            StyleButton(btnRegister, Color.FromArgb(0, 123, 255));
            this.btnRegister.Click += BtnRegister_Click;

            this.btnBackToLogin = new Button();
            this.btnBackToLogin.Text = "Назад до входу";
            this.btnBackToLogin.Location = new Point(50, 400);
            this.btnBackToLogin.Size = new Size(350, 40);
            StyleButton(btnBackToLogin, Color.FromArgb(70, 70, 120));
            this.btnBackToLogin.Click += (s, e) => Close();

            this.panelMain.Controls.AddRange(new[] { btnRegister, btnBackToLogin });
        }

        private TextBox CreateField(string placeholder, ref int y, bool isPassword = false)
        {
            var txt = new TextBox();
            txt.Location = new Point(50, y);
            txt.Size = new Size(350, 35);
            txt.BackColor = Color.FromArgb(70, 70, 70);
            txt.ForeColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.PlaceholderText = placeholder;
            txt.PasswordChar = isPassword ? '•' : default;
            y += 50;
            panelMain.Controls.Add(txt);
            return txt;
        }

        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }
    }
}