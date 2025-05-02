namespace Kursova.Forms
{
    partial class TopUpForm
    {
        private System.ComponentModel.IContainer components = null;
        
        private TextBox txtAmount;
        private Button btnConfirm;
        private Label lblTitle;
        private Panel panelHeader;
        private Label lblInstruction;

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
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Text = "Поповнення балансу";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 70);
            
            // panelHeader
            this.panelHeader = new Panel();
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = Color.FromArgb(50, 50, 90);
            this.Controls.Add(this.panelHeader);
            
            // lblTitle
            this.lblTitle = new Label();
            this.lblTitle.Text = "Поповнення балансу";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(20, 15);
            this.panelHeader.Controls.Add(this.lblTitle);
            
            // Інструкційний напис
            this.lblInstruction = new Label();
            this.lblInstruction.Text = "Введіть суму поповнення:";
            this.lblInstruction.ForeColor = Color.White;
            this.lblInstruction.Font = new Font("Segoe UI", 11F);
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new Point(50, 80);
            this.Controls.Add(this.lblInstruction);
            
            // txtAmount
            this.txtAmount = new TextBox();
            this.txtAmount.Location = new Point(50, 110);
            this.txtAmount.Size = new Size(300, 40);
            this.txtAmount.PlaceholderText = "Сума у гривнях";
            this.txtAmount.BorderStyle = BorderStyle.FixedSingle;
            this.txtAmount.Font = new Font("Segoe UI", 11F);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.BackColor = Color.FromArgb(70, 70, 70);
            this.txtAmount.ForeColor = Color.White;
            this.Controls.Add(this.txtAmount);
            
            // btnConfirm
            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Поповнити";
            this.btnConfirm.Location = new Point(50, 170);
            this.btnConfirm.Size = new Size(300, 45);
            this.btnConfirm.BackColor = Color.FromArgb(0, 123, 255);
            this.btnConfirm.ForeColor = Color.White;
            this.btnConfirm.FlatStyle = FlatStyle.Flat;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Cursor = Cursors.Hand;
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 98, 204);
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            this.Controls.Add(this.btnConfirm);
        }
    }
}