using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Kursova.Models;
using Kursova.Services;

namespace Kursova
{
    public partial class MainForm : Form
    {
        private List<Payment> payments = new List<Payment>();
        private ComboBox cmbServiceType;
        private DataGridView dataGridView;
        private TextBox txtPrevious, txtCurrent;

        public MainForm(bool isAdmin = false)
        {
            InitializeComponent(isAdmin);
        }

        private void InitializeComponent(bool isAdmin)
        {
            // Налаштування форми
            this.ClientSize = new Size(800, 600);
            this.Text = "Комунальні платежі";
            this.BackColor = Color.White;

            // ComboBox для вибору типу послуги
            cmbServiceType = new ComboBox();
            cmbServiceType.Items.AddRange(new[] { "Електроенергія", "Газ", "Вода" });
            cmbServiceType.Location = new Point(20, 20);
            cmbServiceType.Size = new Size(200, 30);
            this.Controls.Add(cmbServiceType);

            // Поля вводу
            txtPrevious = new TextBox 
            { 
                Location = new Point(20, 60), 
                Size = new Size(200, 30), 
                PlaceholderText = "Попередні показники" 
            };
            txtCurrent = new TextBox 
            { 
                Location = new Point(20, 100), 
                Size = new Size(200, 30), 
                PlaceholderText = "Поточні показники" 
            };
            this.Controls.Add(txtPrevious);
            this.Controls.Add(txtCurrent);

            // Кнопка розрахунку
            var btnCalculate = new Button
            {
                Text = "Розрахувати",
                Location = new Point(20, 140),
                Size = new Size(200, 40),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White
            };
            btnCalculate.Click += BtnCalculate_Click;
            this.Controls.Add(btnCalculate);

            // Таблиця результатів
            dataGridView = new DataGridView
            {
                Location = new Point(250, 20),
                Size = new Size(520, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(dataGridView);

            // Завантаження даних
            LoadData();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbServiceType.SelectedItem == null)
                {
                    MessageBox.Show("Виберіть тип послуги!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrevious.Text, out decimal previous) || 
                    !decimal.TryParse(txtCurrent.Text, out decimal current))
                {
                    MessageBox.Show("Невірний формат показників!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (current <= previous)
                {
                    MessageBox.Show("Поточні показники мають бути більшими за попередні!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var payment = new Payment
                {
                    Date = DateTime.Now,
                    ServiceType = cmbServiceType.SelectedItem.ToString(),
                    PreviousReading = previous,
                    CurrentReading = current,
                    Tariff = Calculator.GetTariff(cmbServiceType.SelectedItem.ToString())
                };

                payments.Add(payment);
                dataGridView.DataSource = null;
                dataGridView.DataSource = new List<Payment>(payments); // Оновлення DataGridView
                SaveData();

                // Очищення полів
                txtPrevious.Clear();
                txtCurrent.Clear();
                cmbServiceType.SelectedIndex = -1;

                MessageBox.Show("Розрахунок успішно збережено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            try
            {
                using (var writer = new StreamWriter("payments.xml"))
                {
                    new XmlSerializer(typeof(List<Payment>)).Serialize(writer, payments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists("payments.xml"))
                {
                    using (var reader = new StreamReader("payments.xml"))
                    {
                        var serializer = new XmlSerializer(typeof(List<Payment>));
                        payments = (List<Payment>)serializer.Deserialize(reader);
                        dataGridView.DataSource = payments;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}