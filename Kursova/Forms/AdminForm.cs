using Kursova.Services;


namespace Kursova.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = DatabaseService.LoadUsers();
            dgvUsers.ClearSelection();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}