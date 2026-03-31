using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ISLogistic.Forms
{
    public partial class OrdersForm : Form
    {
        private int selectedOrderId = -1;

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadStatuses();
            LoadOrders();
        }

        private void LoadClients()
        {
            string sql = @"
                SELECT [ClientID], [CompanyName]
                FROM [Clients]";

            DataTable table = Database.ExecuteQuery(sql);

            comboBoxClient.DataSource = table;
            comboBoxClient.DisplayMember = "CompanyName";
            comboBoxClient.ValueMember = "ClientID";
            comboBoxClient.SelectedIndex = -1;
        }

        private void LoadStatuses()
        {
            string sql = @"
                SELECT [StatusID], [StatusName]
                FROM [OrderStatuses]";

            DataTable table = Database.ExecuteQuery(sql);

            comboBoxStatus.DataSource = table;
            comboBoxStatus.DisplayMember = "StatusName";
            comboBoxStatus.ValueMember = "StatusID";
            comboBoxStatus.SelectedIndex = -1;
        }

        private void LoadOrders()
        {
            string sql = @"
                SELECT
                    Orders.[OrderID],
                    Clients.[CompanyName],
                    Orders.[OrderDate],
                    Orders.[PickupAddress],
                    Orders.[DeliveryAddress],
                    Orders.[PickupDate],
                    Orders.[PlannedDeliveryDate],
                    Orders.[ActualDeliveryDate],
                    OrderStatuses.[StatusName],
                    Orders.[TotalCost],
                    Orders.[Notes]
                FROM
                    ([Orders]
                    INNER JOIN [Clients] ON Orders.[ClientID] = Clients.[ClientID])
                    INNER JOIN [OrderStatuses] ON Orders.[StatusID] = OrderStatuses.[StatusID]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvOrders.DataSource = table;

            dgvOrders.Columns["OrderID"].HeaderText = "ID";
            dgvOrders.Columns["CompanyName"].HeaderText = "Клиент";
            dgvOrders.Columns["OrderDate"].HeaderText = "Дата заказа";
            dgvOrders.Columns["PickupAddress"].HeaderText = "Адрес отправки";
            dgvOrders.Columns["DeliveryAddress"].HeaderText = "Адрес доставки";
            dgvOrders.Columns["PickupDate"].HeaderText = "Дата отправки";
            dgvOrders.Columns["PlannedDeliveryDate"].HeaderText = "План. дата доставки";
            dgvOrders.Columns["ActualDeliveryDate"].HeaderText = "Факт. дата доставки";
            dgvOrders.Columns["StatusName"].HeaderText = "Статус";
            dgvOrders.Columns["TotalCost"].HeaderText = "Стоимость";
            dgvOrders.Columns["Notes"].HeaderText = "Примечание";

            dgvOrders.ClearSelection();
        }

        private void ClearFields()
        {
            comboBoxClient.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;

            dateTimePickerOrderDate.Value = DateTime.Now;
            dateTimePickerPickupDate.Value = DateTime.Now;
            dateTimePickerPlannedDeliveryDate.Value = DateTime.Now;
            dateTimePickerActualDeliveryDate.Value = DateTime.Now;

            textBoxPickupAddress.Clear();
            textBoxDeliveryAddress.Clear();
            textBoxTotalCost.Clear();
            textBoxNotes.Clear();

            selectedOrderId = -1;
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

            selectedOrderId = Convert.ToInt32(row.Cells["OrderID"].Value);

            comboBoxClient.Text = row.Cells["CompanyName"].Value.ToString();
            comboBoxStatus.Text = row.Cells["StatusName"].Value.ToString();

            textBoxPickupAddress.Text = row.Cells["PickupAddress"].Value.ToString();
            textBoxDeliveryAddress.Text = row.Cells["DeliveryAddress"].Value.ToString();
            textBoxTotalCost.Text = row.Cells["TotalCost"].Value.ToString();
            textBoxNotes.Text = row.Cells["Notes"].Value.ToString();

            if (row.Cells["OrderDate"].Value != DBNull.Value)
                dateTimePickerOrderDate.Value = Convert.ToDateTime(row.Cells["OrderDate"].Value);

            if (row.Cells["PickupDate"].Value != DBNull.Value)
                dateTimePickerPickupDate.Value = Convert.ToDateTime(row.Cells["PickupDate"].Value);

            if (row.Cells["PlannedDeliveryDate"].Value != DBNull.Value)
                dateTimePickerPlannedDeliveryDate.Value = Convert.ToDateTime(row.Cells["PlannedDeliveryDate"].Value);

            if (row.Cells["ActualDeliveryDate"].Value != DBNull.Value)
                dateTimePickerActualDeliveryDate.Value = Convert.ToDateTime(row.Cells["ActualDeliveryDate"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedIndex == -1 ||
                comboBoxStatus.SelectedIndex == -1 ||
                textBoxPickupAddress.Text == "" ||
                textBoxDeliveryAddress.Text == "" ||
                textBoxTotalCost.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля");
                return;
            }

            string sql = @"
                INSERT INTO [Orders]
                ([ClientID], [OrderDate], [PickupAddress], [DeliveryAddress], [PickupDate],
                 [PlannedDeliveryDate], [ActualDeliveryDate], [StatusID], [TotalCost], [Notes])
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxClient.SelectedValue),
                new OleDbParameter("@p2", dateTimePickerOrderDate.Value),
                new OleDbParameter("@p3", textBoxPickupAddress.Text),
                new OleDbParameter("@p4", textBoxDeliveryAddress.Text),
                new OleDbParameter("@p5", dateTimePickerPickupDate.Value),
                new OleDbParameter("@p6", dateTimePickerPlannedDeliveryDate.Value),
                new OleDbParameter("@p7", dateTimePickerActualDeliveryDate.Value),
                new OleDbParameter("@p8", comboBoxStatus.SelectedValue),
                new OleDbParameter("@p9", Convert.ToDecimal(textBoxTotalCost.Text)),
                new OleDbParameter("@p10", textBoxNotes.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Заказ успешно добавлен");
                LoadOrders();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении заказа");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            if (comboBoxClient.SelectedIndex == -1 ||
                comboBoxStatus.SelectedIndex == -1 ||
                textBoxPickupAddress.Text == "" ||
                textBoxDeliveryAddress.Text == "" ||
                textBoxTotalCost.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля");
                return;
            }

            string sql = @"
                UPDATE [Orders]
                SET
                    [ClientID] = ?,
                    [OrderDate] = ?,
                    [PickupAddress] = ?,
                    [DeliveryAddress] = ?,
                    [PickupDate] = ?,
                    [PlannedDeliveryDate] = ?,
                    [ActualDeliveryDate] = ?,
                    [StatusID] = ?,
                    [TotalCost] = ?,
                    [Notes] = ?
                WHERE [OrderID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxClient.SelectedValue),
                new OleDbParameter("@p2", dateTimePickerOrderDate.Value),
                new OleDbParameter("@p3", textBoxPickupAddress.Text),
                new OleDbParameter("@p4", textBoxDeliveryAddress.Text),
                new OleDbParameter("@p5", dateTimePickerPickupDate.Value),
                new OleDbParameter("@p6", dateTimePickerPlannedDeliveryDate.Value),
                new OleDbParameter("@p7", dateTimePickerActualDeliveryDate.Value),
                new OleDbParameter("@p8", comboBoxStatus.SelectedValue),
                new OleDbParameter("@p9", Convert.ToDecimal(textBoxTotalCost.Text)),
                new OleDbParameter("@p10", textBoxNotes.Text),
                new OleDbParameter("@p11", selectedOrderId)
            );

            if (result > 0)
            {
                MessageBox.Show("Заказ успешно обновлен");
                LoadOrders();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении заказа");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить заказ?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            string sql = "DELETE FROM [Orders] WHERE [OrderID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedOrderId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Заказ удален");
                LoadOrders();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении заказа");
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