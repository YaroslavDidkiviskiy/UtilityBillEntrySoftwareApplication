namespace Kursova.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDelete;

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
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Адмін-панель";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Таблиця користувачів
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvUsers.Location = new System.Drawing.Point(20, 80);
            this.dgvUsers.Size = new System.Drawing.Size(960, 400);
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.Controls.Add(this.dgvUsers);

            // Кнопка видалення
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelete.Text = "Видалити";
            this.btnDelete.Location = new System.Drawing.Point(20, 500);
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.Controls.Add(this.btnDelete);
        }
    }
}