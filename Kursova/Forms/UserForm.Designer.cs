namespace Kursova.Forms
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvPayments;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 70);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комунальні платежі";

            // Панель основного контенту
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.Size = new System.Drawing.Size(500, 350);
            this.panelMain.Location = new System.Drawing.Point(50, 50);
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(50, 50, 90);
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelMain);

            // Баланс
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalance.Text = "Баланс:";
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(20, 20);
            this.panelMain.Controls.Add(this.lblBalance);

            // Випадаючий список
            this.lblService = new System.Windows.Forms.Label();
            this.lblService.Text = "Оберіть послугу:";
            this.lblService.ForeColor = System.Drawing.Color.White;
            this.lblService.Location = new System.Drawing.Point(20, 70);
            this.lblService.AutoSize = true;
            this.panelMain.Controls.Add(this.lblService);

            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbService.Items.AddRange(new object[] { "Електроенергія", "Газ", "Вода" });
            this.cmbService.Location = new System.Drawing.Point(20, 100);
            this.cmbService.Size = new System.Drawing.Size(200, 30);
            this.cmbService.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.cmbService.ForeColor = System.Drawing.Color.White;
            this.cmbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelMain.Controls.Add(this.cmbService);

            // Поля вводу
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblPrevious.Text = "Попередні показники:";
            this.lblPrevious.ForeColor = System.Drawing.Color.White;
            this.lblPrevious.Location = new System.Drawing.Point(20, 150);
            this.lblPrevious.AutoSize = true;
            this.panelMain.Controls.Add(this.lblPrevious);

            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtPrevious.Location = new System.Drawing.Point(20, 180);
            this.txtPrevious.Size = new System.Drawing.Size(200, 30);
            this.txtPrevious.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.txtPrevious.ForeColor = System.Drawing.Color.White;
            this.txtPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrevious.PlaceholderText = "Введіть число";
            this.panelMain.Controls.Add(this.txtPrevious);

            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrent.Text = "Поточні показники:";
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(20, 220);
            this.lblCurrent.AutoSize = true;
            this.panelMain.Controls.Add(this.lblCurrent);

            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtCurrent.Location = new System.Drawing.Point(20, 250);
            this.txtCurrent.Size = new System.Drawing.Size(200, 30);
            this.txtCurrent.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.txtCurrent.ForeColor = System.Drawing.Color.White;
            this.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrent.PlaceholderText = "Введіть число";
            this.panelMain.Controls.Add(this.txtCurrent);

            // Кнопки
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculate.Text = "Розрахувати та сплатити";
            this.btnCalculate.Location = new System.Drawing.Point(20, 300);
            this.btnCalculate.Size = new System.Drawing.Size(200, 40);
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 78, 139);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 58, 109);
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            this.panelMain.Controls.Add(this.btnCalculate);

            this.btnTopUp = new System.Windows.Forms.Button();
            this.btnTopUp.Text = "Поповнити баланс";
            this.btnTopUp.Location = new System.Drawing.Point(250, 100);
            this.btnTopUp.Size = new System.Drawing.Size(200, 40);
            this.btnTopUp.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnTopUp.ForeColor = System.Drawing.Color.White;
            this.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 103, 235);
            this.btnTopUp.Click += new System.EventHandler(this.BtnTopUp_Click);
            this.panelMain.Controls.Add(this.btnTopUp);

            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack.Text = "Назад";
            this.btnBack.Location = new System.Drawing.Point(250, 300);
            this.btnBack.Size = new System.Drawing.Size(200, 40);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(70, 70, 120);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 50, 90);
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.panelMain.Controls.Add(this.btnBack);

            // Таблиця платежів
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.dgvPayments.Location = new System.Drawing.Point(50, 420);
            this.dgvPayments.Size = new System.Drawing.Size(500, 180);
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(50, 50, 90);
            this.dgvPayments.ForeColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 70);
            this.dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayments.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 90);
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Controls.Add(this.dgvPayments);
        }
    }
}