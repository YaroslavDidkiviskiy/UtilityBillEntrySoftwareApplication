namespace Kursova
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbServiceType;
        private TextBox txtPrevious;
        private TextBox txtCurrent;
        private DateTimePicker dtpPaymentDate;
        private Button btnCalculate;
        private DataGridView dgvPayments;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnFilter;
        private Button btnResetFilter;
        private Label lblService;
        private Label lblPrevious;
        private Label lblCurrent;
        private Label lblDate;
        private Label lblFilter;

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
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Text = "Комунальні платежі";
            this.MinimumSize = new System.Drawing.Size(1000, 600);

            // ComboBox для послуг
            this.cmbServiceType = new ComboBox();
            this.cmbServiceType.Location = new Point(30, 60);
            this.cmbServiceType.Size = new Size(300, 32);
            this.cmbServiceType.Items.AddRange(new[] { "Електроенергія", "Газ", "Вода" });
            this.Controls.Add(this.cmbServiceType);

            // Текстові поля
            this.txtPrevious = new TextBox();
            this.txtPrevious.Location = new Point(30, 140);
            this.txtPrevious.Size = new Size(300, 32);
            this.txtPrevious.PlaceholderText = "Попередні показники";
            this.Controls.Add(this.txtPrevious);

            this.txtCurrent = new TextBox();
            this.txtCurrent.Location = new Point(30, 220);
            this.txtCurrent.Size = new Size(300, 32);
            this.txtCurrent.PlaceholderText = "Поточні показники";
            this.Controls.Add(this.txtCurrent);

            // DateTimePicker для дати
            this.dtpPaymentDate = new DateTimePicker();
            this.dtpPaymentDate.Location = new Point(30, 300);
            this.dtpPaymentDate.Size = new Size(300, 32);
            this.Controls.Add(this.dtpPaymentDate);

            // Кнопка розрахунку
            this.btnCalculate = new Button();
            this.btnCalculate.Text = "РОЗРАХУВАТИ";
            this.btnCalculate.Location = new Point(30, 360);
            this.btnCalculate.Size = new Size(300, 40);
            this.btnCalculate.Click += new EventHandler(this.BtnCalculate_Click);
            this.Controls.Add(this.btnCalculate);

            // DataGridView
            this.dgvPayments = new DataGridView();
            this.dgvPayments.Location = new Point(400, 30);
            this.dgvPayments.Size = new Size(750, 600);
            this.dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(this.dgvPayments);

            // Фільтрація
            this.dtpStartDate = new DateTimePicker();
            this.dtpStartDate.Location = new Point(400, 650);
            this.dtpStartDate.Size = new Size(150, 32);
            this.dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            this.Controls.Add(this.dtpStartDate);

            this.dtpEndDate = new DateTimePicker();
            this.dtpEndDate.Location = new Point(580, 650);
            this.dtpEndDate.Size = new Size(150, 32);
            this.Controls.Add(this.dtpEndDate);

            this.btnFilter = new Button();
            this.btnFilter.Text = "Фільтрувати";
            this.btnFilter.Location = new Point(760, 650);
            this.btnFilter.Size = new Size(100, 32);
            this.btnFilter.Click += new EventHandler(this.BtnFilter_Click);
            this.Controls.Add(this.btnFilter);

            this.btnResetFilter = new Button();
            this.btnResetFilter.Text = "Скинути";
            this.btnResetFilter.Location = new Point(900, 650);
            this.btnResetFilter.Size = new Size(100, 32);
            this.btnResetFilter.Click += new EventHandler(this.BtnResetFilter_Click);
            this.Controls.Add(this.btnResetFilter);

            // Мітки
            this.lblService = CreateLabel("Тип послуги:", 30, 30);
            this.lblPrevious = CreateLabel("Попередні показники:", 30, 110);
            this.lblCurrent = CreateLabel("Поточні показники:", 30, 190);
            this.lblDate = CreateLabel("Дата оплати:", 30, 270);
            this.lblFilter = CreateLabel("Фільтр за датами:", 400, 620);
        }

        private Label CreateLabel(string text, int x, int y)
        {
            var label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.ForeColor = Color.WhiteSmoke;
            return label;
        }
    }
}