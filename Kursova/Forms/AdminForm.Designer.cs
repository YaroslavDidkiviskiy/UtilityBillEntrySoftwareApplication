namespace Kursova.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Panel panelHeader;
        private Label lblTitle;
        private Button btnExit;
        private Button btnBack;

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
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Адмін-панель";

            // DataGridView
            this.dgvUsers = new DataGridView();
            this.dgvUsers.Location = new System.Drawing.Point(20, 80);
            this.dgvUsers.Size = new System.Drawing.Size(960, 400);
            this.dgvUsers.BackgroundColor = Color.FromArgb(50, 50, 90);
            this.dgvUsers.ForeColor = Color.White;
            this.dgvUsers.BorderStyle = BorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(30, 30, 70),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            this.dgvUsers.RowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 90);
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgvUsers);

            // Панель заголовка
            this.panelHeader = new Panel();
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = Color.FromArgb(50, 50, 90);
            this.Controls.Add(panelHeader);

            // Заголовок
            this.lblTitle = new Label();
            this.lblTitle.Text = "Адміністративна панель";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(20, 15);
            this.panelHeader.Controls.Add(lblTitle);

            // Кнопка видалення
            this.btnDelete = new Button();
            this.btnDelete.Text = "Видалити";
            this.btnDelete.Location = new System.Drawing.Point(20, 500);
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Click += new EventHandler(BtnDelete_Click);

            // Кнопка "Назад"
            this.btnBack = new Button();
            this.btnBack.Text = "Назад";
            this.btnBack.Location = new System.Drawing.Point(830, 500);
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.BackColor = Color.FromArgb(108, 117, 125);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Click += new EventHandler(BtnBack_Click);

            this.Controls.AddRange(new[] { btnDelete, btnBack });
        }
    }
}