using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ISLogistic.Forms
{
    public partial class VehiclesForm : Form
    {
        private int selectedVehicleId = -1;

        public VehiclesForm()
        {
            InitializeComponent();
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            LoadVehicleTypes();
            LoadVehicles();
        }

        private void LoadVehicleTypes()
        {
            string sql = "SELECT [VehicleTypeID], [VehicleTypeName] FROM [VehicleTypes]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxVehicleType.DataSource = table;
            comboBoxVehicleType.DisplayMember = "VehicleTypeName";
            comboBoxVehicleType.ValueMember = "VehicleTypeID";
            comboBoxVehicleType.SelectedIndex = -1;
        }

        private void LoadVehicles()
        {
            string sql = @"
                SELECT
                    Vehicles.[VehicleID],
                    VehicleTypes.[VehicleTypeName],
                    Vehicles.[Brand],
                    Vehicles.[Model],
                    Vehicles.[PlateNumber],
                    Vehicles.[CapacityWeight],
                    Vehicles.[CapacityVolume],
                    Vehicles.[YearOfManufacture],
                    Vehicles.[Status]
                FROM [Vehicles]
                INNER JOIN [VehicleTypes]
                    ON Vehicles.[VehicleTypeID] = VehicleTypes.[VehicleTypeID]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvVehicles.DataSource = table;

            dgvVehicles.Columns["VehicleID"].HeaderText = "ID";
            dgvVehicles.Columns["VehicleTypeName"].HeaderText = "Тип транспорта";
            dgvVehicles.Columns["Brand"].HeaderText = "Марка";
            dgvVehicles.Columns["Model"].HeaderText = "Модель";
            dgvVehicles.Columns["PlateNumber"].HeaderText = "Гос. номер";
            dgvVehicles.Columns["CapacityWeight"].HeaderText = "Грузоподъемность";
            dgvVehicles.Columns["CapacityVolume"].HeaderText = "Объем";
            dgvVehicles.Columns["YearOfManufacture"].HeaderText = "Год выпуска";
            dgvVehicles.Columns["Status"].HeaderText = "Статус";

            dgvVehicles.ClearSelection();
        }

        private void ClearFields()
        {
            comboBoxVehicleType.SelectedIndex = -1;
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxPlateNumber.Clear();
            textBoxCapacityWeight.Clear();
            textBoxCapacityVolume.Clear();
            textBoxYear.Clear();
            textBoxStatus.Clear();

            selectedVehicleId = -1;
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];

            selectedVehicleId = Convert.ToInt32(row.Cells["VehicleID"].Value);
            comboBoxVehicleType.Text = row.Cells["VehicleTypeName"].Value.ToString();
            textBoxBrand.Text = row.Cells["Brand"].Value.ToString();
            textBoxModel.Text = row.Cells["Model"].Value.ToString();
            textBoxPlateNumber.Text = row.Cells["PlateNumber"].Value.ToString();
            textBoxCapacityWeight.Text = row.Cells["CapacityWeight"].Value.ToString();
            textBoxCapacityVolume.Text = row.Cells["CapacityVolume"].Value.ToString();
            textBoxYear.Text = row.Cells["YearOfManufacture"].Value.ToString();
            textBoxStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxVehicleType.SelectedIndex == -1 ||
                textBoxBrand.Text == "" ||
                textBoxModel.Text == "" ||
                textBoxPlateNumber.Text == "" ||
                textBoxCapacityWeight.Text == "" ||
                textBoxCapacityVolume.Text == "" ||
                textBoxYear.Text == "" ||
                textBoxStatus.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            string sql = @"
                INSERT INTO [Vehicles]
                ([VehicleTypeID], [Brand], [Model], [PlateNumber], [CapacityWeight], [CapacityVolume], [YearOfManufacture], [Status])
                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxVehicleType.SelectedValue),
                new OleDbParameter("@p2", textBoxBrand.Text),
                new OleDbParameter("@p3", textBoxModel.Text),
                new OleDbParameter("@p4", textBoxPlateNumber.Text),
                new OleDbParameter("@p5", Convert.ToDouble(textBoxCapacityWeight.Text)),
                new OleDbParameter("@p6", Convert.ToDouble(textBoxCapacityVolume.Text)),
                new OleDbParameter("@p7", Convert.ToInt32(textBoxYear.Text)),
                new OleDbParameter("@p8", textBoxStatus.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Транспорт добавлен");
                LoadVehicles();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении транспорта");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedVehicleId == -1)
            {
                MessageBox.Show("Выберите транспорт");
                return;
            }

            string sql = @"
                UPDATE [Vehicles]
                SET
                    [VehicleTypeID] = ?,
                    [Brand] = ?,
                    [Model] = ?,
                    [PlateNumber] = ?,
                    [CapacityWeight] = ?,
                    [CapacityVolume] = ?,
                    [YearOfManufacture] = ?,
                    [Status] = ?
                WHERE [VehicleID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxVehicleType.SelectedValue),
                new OleDbParameter("@p2", textBoxBrand.Text),
                new OleDbParameter("@p3", textBoxModel.Text),
                new OleDbParameter("@p4", textBoxPlateNumber.Text),
                new OleDbParameter("@p5", Convert.ToDouble(textBoxCapacityWeight.Text)),
                new OleDbParameter("@p6", Convert.ToDouble(textBoxCapacityVolume.Text)),
                new OleDbParameter("@p7", Convert.ToInt32(textBoxYear.Text)),
                new OleDbParameter("@p8", textBoxStatus.Text),
                new OleDbParameter("@p9", selectedVehicleId)
            );

            if (result > 0)
            {
                MessageBox.Show("Данные транспорта обновлены");
                LoadVehicles();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении транспорта");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedVehicleId == -1)
            {
                MessageBox.Show("Выберите транспорт");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить транспорт?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM [Vehicles] WHERE [VehicleID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedVehicleId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Транспорт удален");
                LoadVehicles();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении транспорта");
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