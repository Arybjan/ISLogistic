using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ISLogistic.Forms
{
    public partial class DriversForm : Form
    {
        private int selectedDriverId = -1;

        public DriversForm()
        {
            InitializeComponent();
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void LoadDrivers()
        {
            string sql = @"
                SELECT
                    [DriverID],
                    [FullName],
                    [Phone],
                    [LicenseNumber],
                    [LicenseCategory],
                    [HireDate],
                    [Status]
                FROM [Drivers]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvDrivers.DataSource = table;

            dgvDrivers.Columns["DriverID"].HeaderText = "ID";
            dgvDrivers.Columns["FullName"].HeaderText = "ФИО";
            dgvDrivers.Columns["Phone"].HeaderText = "Телефон";
            dgvDrivers.Columns["LicenseNumber"].HeaderText = "Номер прав";
            dgvDrivers.Columns["LicenseCategory"].HeaderText = "Категория";
            dgvDrivers.Columns["HireDate"].HeaderText = "Дата найма";
            dgvDrivers.Columns["Status"].HeaderText = "Статус";

            dgvDrivers.ClearSelection();
        }

        private void ClearFields()
        {
            textBoxFullName.Clear();
            textBoxPhone.Clear();
            textBoxLicenseNumber.Clear();
            textBoxLicenseCategory.Clear();
            dateTimePickerHireDate.Value = DateTime.Now;
            textBoxStatus.Clear();

            selectedDriverId = -1;
        }

        private void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDrivers.Rows[e.RowIndex];

            selectedDriverId = Convert.ToInt32(row.Cells["DriverID"].Value);
            textBoxFullName.Text = row.Cells["FullName"].Value.ToString();
            textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
            textBoxLicenseNumber.Text = row.Cells["LicenseNumber"].Value.ToString();
            textBoxLicenseCategory.Text = row.Cells["LicenseCategory"].Value.ToString();
            textBoxStatus.Text = row.Cells["Status"].Value.ToString();

            if (row.Cells["HireDate"].Value != DBNull.Value)
                dateTimePickerHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxLicenseNumber.Text == "" ||
                textBoxLicenseCategory.Text == "" ||
                textBoxStatus.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            string sql = @"
                INSERT INTO [Drivers]
                ([FullName], [Phone], [LicenseNumber], [LicenseCategory], [HireDate], [Status])
                VALUES (?, ?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxFullName.Text),
                new OleDbParameter("@p2", textBoxPhone.Text),
                new OleDbParameter("@p3", textBoxLicenseNumber.Text),
                new OleDbParameter("@p4", textBoxLicenseCategory.Text),
                new OleDbParameter("@p5", dateTimePickerHireDate.Value),
                new OleDbParameter("@p6", textBoxStatus.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Водитель успешно добавлен");
                LoadDrivers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении водителя");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == -1)
            {
                MessageBox.Show("Выберите водителя");
                return;
            }

            string sql = @"
                UPDATE [Drivers]
                SET
                    [FullName] = ?,
                    [Phone] = ?,
                    [LicenseNumber] = ?,
                    [LicenseCategory] = ?,
                    [HireDate] = ?,
                    [Status] = ?
                WHERE [DriverID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxFullName.Text),
                new OleDbParameter("@p2", textBoxPhone.Text),
                new OleDbParameter("@p3", textBoxLicenseNumber.Text),
                new OleDbParameter("@p4", textBoxLicenseCategory.Text),
                new OleDbParameter("@p5", dateTimePickerHireDate.Value),
                new OleDbParameter("@p6", textBoxStatus.Text),
                new OleDbParameter("@p7", selectedDriverId)
            );

            if (result > 0)
            {
                MessageBox.Show("Данные водителя обновлены");
                LoadDrivers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении водителя");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == -1)
            {
                MessageBox.Show("Выберите водителя");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить водителя?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM [Drivers] WHERE [DriverID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedDriverId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Водитель удален");
                LoadDrivers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении водителя");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}