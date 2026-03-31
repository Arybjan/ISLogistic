using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class CargoForm : Form
    {
        private int selectedCargoId = -1;

        public CargoForm()
        {
            InitializeComponent();
        }

        private void CargoForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadCargoTypes();
            LoadCargo();
        }

        private void LoadOrders()
        {
            string sql = "SELECT [OrderID], [OrderID] FROM [Orders]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxOrder.DataSource = table;
            comboBoxOrder.DisplayMember = "OrderID";
            comboBoxOrder.ValueMember = "OrderID";
            comboBoxOrder.SelectedIndex = -1;
        }

        private void LoadCargoTypes()
        {
            string sql = "SELECT [CargoTypeID], [CargoTypeName] FROM [CargoTypes]";
            DataTable table = Database.ExecuteQuery(sql);

            comboBoxCargoType.DataSource = table;
            comboBoxCargoType.DisplayMember = "CargoTypeName";
            comboBoxCargoType.ValueMember = "CargoTypeID";
            comboBoxCargoType.SelectedIndex = -1;
        }

        private void LoadCargo()
        {
            string sql = @"
                SELECT
                    Cargo.[CargoID],
                    Cargo.[OrderID],
                    Cargo.[CargoName],
                    CargoTypes.[CargoTypeName],
                    Cargo.[Weight],
                    Cargo.[Volume],
                    Cargo.[Quantity],
                    Cargo.[DeclaredValue],
                    Cargo.[Fragile],
                    Cargo.[Description]
                FROM [Cargo]
                INNER JOIN [CargoTypes]
                    ON Cargo.[CargoTypeID] = CargoTypes.[CargoTypeID]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvCargo.DataSource = table;

            dgvCargo.Columns["CargoID"].HeaderText = "ID";
            dgvCargo.Columns["OrderID"].HeaderText = "Заказ";
            dgvCargo.Columns["CargoName"].HeaderText = "Название груза";
            dgvCargo.Columns["CargoTypeName"].HeaderText = "Тип груза";
            dgvCargo.Columns["Weight"].HeaderText = "Вес";
            dgvCargo.Columns["Volume"].HeaderText = "Объем";
            dgvCargo.Columns["Quantity"].HeaderText = "Количество";
            dgvCargo.Columns["DeclaredValue"].HeaderText = "Объявленная стоимость";
            dgvCargo.Columns["Fragile"].HeaderText = "Хрупкий";
            dgvCargo.Columns["Description"].HeaderText = "Описание";

            dgvCargo.ClearSelection();
        }

        private void ClearFields()
        {
            comboBoxOrder.SelectedIndex = -1;
            comboBoxCargoType.SelectedIndex = -1;
            textBoxCargoName.Clear();
            textBoxWeight.Clear();
            textBoxVolume.Clear();
            textBoxQuantity.Clear();
            textBoxDeclaredValue.Clear();
            checkBoxFragile.Checked = false;
            textBoxDescription.Clear();

            selectedCargoId = -1;
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCargo.Rows[e.RowIndex];

            selectedCargoId = Convert.ToInt32(row.Cells["CargoID"].Value);
            comboBoxOrder.Text = row.Cells["OrderID"].Value.ToString();
            comboBoxCargoType.Text = row.Cells["CargoTypeName"].Value.ToString();
            textBoxCargoName.Text = row.Cells["CargoName"].Value.ToString();
            textBoxWeight.Text = row.Cells["Weight"].Value.ToString();
            textBoxVolume.Text = row.Cells["Volume"].Value.ToString();
            textBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
            textBoxDeclaredValue.Text = row.Cells["DeclaredValue"].Value.ToString();
            checkBoxFragile.Checked = Convert.ToBoolean(row.Cells["Fragile"].Value);
            textBoxDescription.Text = row.Cells["Description"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedIndex == -1 ||
                comboBoxCargoType.SelectedIndex == -1 ||
                textBoxCargoName.Text == "" ||
                textBoxWeight.Text == "" ||
                textBoxVolume.Text == "" ||
                textBoxQuantity.Text == "" ||
                textBoxDeclaredValue.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля");
                return;
            }

            string sql = @"
                INSERT INTO [Cargo]
                ([OrderID], [CargoName], [CargoTypeID], [Weight], [Volume], [Quantity], [DeclaredValue], [Fragile], [Description])
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxOrder.SelectedValue),
                new OleDbParameter("@p2", textBoxCargoName.Text),
                new OleDbParameter("@p3", comboBoxCargoType.SelectedValue),
                new OleDbParameter("@p4", Convert.ToDouble(textBoxWeight.Text)),
                new OleDbParameter("@p5", Convert.ToDouble(textBoxVolume.Text)),
                new OleDbParameter("@p6", Convert.ToInt32(textBoxQuantity.Text)),
                new OleDbParameter("@p7", Convert.ToDecimal(textBoxDeclaredValue.Text)),
                new OleDbParameter("@p8", checkBoxFragile.Checked),
                new OleDbParameter("@p9", textBoxDescription.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Груз успешно добавлен");
                LoadCargo();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении груза");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCargoId == -1)
            {
                MessageBox.Show("Выберите груз");
                return;
            }

            string sql = @"
                UPDATE [Cargo]
                SET
                    [OrderID] = ?,
                    [CargoName] = ?,
                    [CargoTypeID] = ?,
                    [Weight] = ?,
                    [Volume] = ?,
                    [Quantity] = ?,
                    [DeclaredValue] = ?,
                    [Fragile] = ?,
                    [Description] = ?
                WHERE [CargoID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxOrder.SelectedValue),
                new OleDbParameter("@p2", textBoxCargoName.Text),
                new OleDbParameter("@p3", comboBoxCargoType.SelectedValue),
                new OleDbParameter("@p4", Convert.ToDouble(textBoxWeight.Text)),
                new OleDbParameter("@p5", Convert.ToDouble(textBoxVolume.Text)),
                new OleDbParameter("@p6", Convert.ToInt32(textBoxQuantity.Text)),
                new OleDbParameter("@p7", Convert.ToDecimal(textBoxDeclaredValue.Text)),
                new OleDbParameter("@p8", checkBoxFragile.Checked),
                new OleDbParameter("@p9", textBoxDescription.Text),
                new OleDbParameter("@p10", selectedCargoId)
            );

            if (result > 0)
            {
                MessageBox.Show("Данные груза обновлены");
                LoadCargo();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении груза");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCargoId == -1)
            {
                MessageBox.Show("Выберите груз");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить груз?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM [Cargo] WHERE [CargoID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedCargoId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Груз удален");
                LoadCargo();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении груза");
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