using System.Windows.Forms;
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
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var users = DatabaseService.LoadUsers();
                users.RemoveAt(dgvUsers.SelectedRows[0].Index);
                DatabaseService.SaveUsers(users);
                LoadUsers(); // Оновлення таблиці
            }
        }
    }
}