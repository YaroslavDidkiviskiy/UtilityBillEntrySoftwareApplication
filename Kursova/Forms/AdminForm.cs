using Kursova.Services;
using System.Windows.Forms;

namespace Kursova.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            this.BackColor = Color.FromArgb(30, 30, 70);
            dgvUsers.BackgroundColor = Color.FromArgb(50, 50, 90);
            dgvUsers.GridColor = Color.FromArgb(70, 70, 120);
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = DatabaseService.LoadUsers();
            dgvUsers.ClearSelection();
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["IsAdmin"].HeaderText = "Адмін";
            dgvUsers.Columns["Balance"].HeaderText = "Баланс";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0 &&
                MessageBox.Show("Ви впевнені, що хочете видалити користувача?", 
                    "Підтвердження", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var users = DatabaseService.LoadUsers();
                users.RemoveAt(dgvUsers.SelectedRows[0].Index);
                DatabaseService.SaveUsers(users);
                LoadUsers();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}