using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class ShipmentsForm : Form
    {
        private int selectedShipmentId = -1;

        public ShipmentsForm()
        {
            InitializeComponent();
        }

        private void ShipmentsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadOrders();
                LoadDrivers();
                LoadVehicles();
                LoadRoutes();
                LoadShipments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке формы:\n" + ex.Message);
            }
        }

        private void LoadOrders()
        {
            string sql = "SELECT [OrderID] FROM [Orders]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxOrder.DataSource = null;
            comboBoxOrder.DataSource = table;
            comboBoxOrder.DisplayMember = "OrderID";
            comboBoxOrder.ValueMember = "OrderID";
            comboBoxOrder.SelectedIndex = -1;
        }

        private void LoadDrivers()
        {
            string sql = "SELECT [DriverID], [FullName] FROM [Drivers]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxDriver.DataSource = null;
            comboBoxDriver.DataSource = table;
            comboBoxDriver.DisplayMember = "FullName";
            comboBoxDriver.ValueMember = "DriverID";
            comboBoxDriver.SelectedIndex = -1;
        }

        private void LoadVehicles()
        {
            string sql = "SELECT [VehicleID], [PlateNumber] FROM [Vehicles]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxVehicle.DataSource = null;
            comboBoxVehicle.DataSource = table;
            comboBoxVehicle.DisplayMember = "PlateNumber";
            comboBoxVehicle.ValueMember = "VehicleID";
            comboBoxVehicle.SelectedIndex = -1;
        }

        private void LoadRoutes()
        {
            string sql = "SELECT [RouteID], [StartPoint] & ' - ' & [EndPoint] AS [RouteName] FROM [Routes]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxRoute.DataSource = null;
            comboBoxRoute.DataSource = table;
            comboBoxRoute.DisplayMember = "RouteName";
            comboBoxRoute.ValueMember = "RouteID";
            comboBoxRoute.SelectedIndex = -1;
        }

        private void LoadShipments()
        {
            string sql = @"
                SELECT
                    [Shipments].[ShipmentID],
                    [Shipments].[OrderID],
                    [Shipments].[DriverID],
                    [Shipments].[VehicleID],
                    [Shipments].[RouteID],
                    [Drivers].[FullName],
                    [Vehicles].[PlateNumber],
                    [Routes].[StartPoint] & ' - ' & [Routes].[EndPoint] AS [RouteName],
                    [Shipments].[DepartureDate],
                    [Shipments].[PlannedArrivalDate],
                    [Shipments].[ActualArrivalDate],
                    [Shipments].[ShipmentStatus],
                    [Shipments].[Notes]
                FROM
                    (([Shipments]
                    INNER JOIN [Drivers] ON [Shipments].[DriverID] = [Drivers].[DriverID])
                    INNER JOIN [Vehicles] ON [Shipments].[VehicleID] = [Vehicles].[VehicleID])
                    INNER JOIN [Routes] ON [Shipments].[RouteID] = [Routes].[RouteID]
                ORDER BY [Shipments].[ShipmentID]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvShipments.DataSource = table;
            dgvShipments.ClearSelection();

            if (dgvShipments.Columns.Contains("DriverID"))
                dgvShipments.Columns["DriverID"].Visible = false;

            if (dgvShipments.Columns.Contains("VehicleID"))
                dgvShipments.Columns["VehicleID"].Visible = false;

            if (dgvShipments.Columns.Contains("RouteID"))
                dgvShipments.Columns["RouteID"].Visible = false;
        }

        private void ClearFields()
        {
            comboBoxOrder.SelectedIndex = -1;
            comboBoxDriver.SelectedIndex = -1;
            comboBoxVehicle.SelectedIndex = -1;
            comboBoxRoute.SelectedIndex = -1;

            dateTimePickerDeparture.Value = DateTime.Now;
            dateTimePickerArrival.Value = DateTime.Now;

            textBoxStatus.Clear();
            selectedShipmentId = -1;
            dgvShipments.ClearSelection();
        }

        private bool ValidateFields()
        {
            if (comboBoxOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите заказ");
                comboBoxOrder.Focus();
                return false;
            }

            if (comboBoxDriver.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите водителя");
                comboBoxDriver.Focus();
                return false;
            }

            if (comboBoxVehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите транспорт");
                comboBoxVehicle.Focus();
                return false;
            }

            if (comboBoxRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите маршрут");
                comboBoxRoute.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("Введите статус перевозки");
                textBoxStatus.Focus();
                return false;
            }

            if (dateTimePickerArrival.Value < dateTimePickerDeparture.Value)
            {
                MessageBox.Show("Плановая дата прибытия не может быть раньше даты отправки");
                dateTimePickerArrival.Focus();
                return false;
            }

            return true;
        }

        private void dgvShipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvShipments.Rows[e.RowIndex].Cells["ShipmentID"].Value == null)
                return;

            try
            {
                DataGridViewRow row = dgvShipments.Rows[e.RowIndex];

                selectedShipmentId = Convert.ToInt32(row.Cells["ShipmentID"].Value);

                comboBoxOrder.SelectedValue = row.Cells["OrderID"].Value;
                comboBoxDriver.SelectedValue = row.Cells["DriverID"].Value;
                comboBoxVehicle.SelectedValue = row.Cells["VehicleID"].Value;
                comboBoxRoute.SelectedValue = row.Cells["RouteID"].Value;

                textBoxStatus.Text = row.Cells["ShipmentStatus"].Value?.ToString() ?? "";

                if (row.Cells["DepartureDate"].Value != DBNull.Value && row.Cells["DepartureDate"].Value != null)
                    dateTimePickerDeparture.Value = Convert.ToDateTime(row.Cells["DepartureDate"].Value);

                if (row.Cells["PlannedArrivalDate"].Value != DBNull.Value && row.Cells["PlannedArrivalDate"].Value != null)
                    dateTimePickerArrival.Value = Convert.ToDateTime(row.Cells["PlannedArrivalDate"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выборе строки:\n" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                string sql = @"
                    INSERT INTO [Shipments]
                    ([OrderID], [VehicleID], [DriverID], [RouteID], [DepartureDate], [PlannedArrivalDate], [ActualArrivalDate], [ShipmentStatus], [Notes])
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                int result = Database.ExecuteNonQuery(
                    sql,
                    new OleDbParameter("@p1", Convert.ToInt32(comboBoxOrder.SelectedValue)),
                    new OleDbParameter("@p2", Convert.ToInt32(comboBoxVehicle.SelectedValue)),
                    new OleDbParameter("@p3", Convert.ToInt32(comboBoxDriver.SelectedValue)),
                    new OleDbParameter("@p4", Convert.ToInt32(comboBoxRoute.SelectedValue)),
                    new OleDbParameter("@p5", dateTimePickerDeparture.Value),
                    new OleDbParameter("@p6", dateTimePickerArrival.Value),
                    new OleDbParameter("@p7", DBNull.Value),
                    new OleDbParameter("@p8", textBoxStatus.Text.Trim()),
                    new OleDbParameter("@p9", DBNull.Value)
                );

                if (result > 0)
                {
                    MessageBox.Show("Перевозка добавлена");
                    LoadShipments();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении:\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == -1)
            {
                MessageBox.Show("Выберите запись для изменения");
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                string sql = @"
                    UPDATE [Shipments]
                    SET
                        [OrderID] = ?,
                        [VehicleID] = ?,
                        [DriverID] = ?,
                        [RouteID] = ?,
                        [DepartureDate] = ?,
                        [PlannedArrivalDate] = ?,
                        [ShipmentStatus] = ?
                    WHERE [ShipmentID] = ?";

                int result = Database.ExecuteNonQuery(
                    sql,
                    new OleDbParameter("@p1", Convert.ToInt32(comboBoxOrder.SelectedValue)),
                    new OleDbParameter("@p2", Convert.ToInt32(comboBoxVehicle.SelectedValue)),
                    new OleDbParameter("@p3", Convert.ToInt32(comboBoxDriver.SelectedValue)),
                    new OleDbParameter("@p4", Convert.ToInt32(comboBoxRoute.SelectedValue)),
                    new OleDbParameter("@p5", dateTimePickerDeparture.Value),
                    new OleDbParameter("@p6", dateTimePickerArrival.Value),
                    new OleDbParameter("@p7", textBoxStatus.Text.Trim()),
                    new OleDbParameter("@p8", selectedShipmentId)
                );

                if (result > 0)
                {
                    MessageBox.Show("Запись обновлена");
                    LoadShipments();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Не удалось обновить запись");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedShipmentId == -1)
            {
                MessageBox.Show("Выберите запись для удаления");
                return;
            }

            DialogResult resultDialog = MessageBox.Show(
                "Вы действительно хотите удалить эту запись?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultDialog != DialogResult.Yes)
                return;

            try
            {
                string sql = "DELETE FROM [Shipments] WHERE [ShipmentID] = ?";
                int result = Database.ExecuteNonQuery(
                    sql,
                    new OleDbParameter("@p1", selectedShipmentId)
                );

                if (result > 0)
                {
                    MessageBox.Show("Запись удалена");
                    LoadShipments();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении:\n" + ex.Message);
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