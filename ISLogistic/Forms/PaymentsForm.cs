using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class PaymentsForm : Form
    {
        private int selectedPaymentId = -1;

        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadPayments();
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

        private void LoadPayments()
        {
            string sql = @"
                SELECT
                    [PaymentID],
                    [OrderID],
                    [PaymentDate],
                    [Amount],
                    [PaymentMethod],
                    [PaymentStatus]
                FROM [Payments]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvPayments.DataSource = table;

            dgvPayments.Columns["PaymentID"].HeaderText = "ID";
            dgvPayments.Columns["OrderID"].HeaderText = "Заказ";
            dgvPayments.Columns["PaymentDate"].HeaderText = "Дата оплаты";
            dgvPayments.Columns["Amount"].HeaderText = "Сумма";
            dgvPayments.Columns["PaymentMethod"].HeaderText = "Способ оплаты";
            dgvPayments.Columns["PaymentStatus"].HeaderText = "Статус оплаты";

            dgvPayments.ClearSelection();
        }

        private void ClearFields()
        {
            comboBoxOrder.SelectedIndex = -1;
            dateTimePickerPaymentDate.Value = DateTime.Now;
            textBoxAmount.Clear();
            textBoxPaymentMethod.Clear();
            textBoxPaymentStatus.Clear();

            selectedPaymentId = -1;
        }

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPayments.Rows[e.RowIndex];

            selectedPaymentId = Convert.ToInt32(row.Cells["PaymentID"].Value);
            comboBoxOrder.Text = row.Cells["OrderID"].Value.ToString();
            textBoxAmount.Text = row.Cells["Amount"].Value.ToString();
            textBoxPaymentMethod.Text = row.Cells["PaymentMethod"].Value.ToString();
            textBoxPaymentStatus.Text = row.Cells["PaymentStatus"].Value.ToString();

            if (row.Cells["PaymentDate"].Value != DBNull.Value)
                dateTimePickerPaymentDate.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedIndex == -1 ||
                textBoxAmount.Text == "" ||
                textBoxPaymentMethod.Text == "" ||
                textBoxPaymentStatus.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            string sql = @"
                INSERT INTO [Payments]
                ([OrderID], [PaymentDate], [Amount], [PaymentMethod], [PaymentStatus])
                VALUES (?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxOrder.SelectedValue),
                new OleDbParameter("@p2", dateTimePickerPaymentDate.Value),
                new OleDbParameter("@p3", Convert.ToDecimal(textBoxAmount.Text)),
                new OleDbParameter("@p4", textBoxPaymentMethod.Text),
                new OleDbParameter("@p5", textBoxPaymentStatus.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Оплата добавлена");
                LoadPayments();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении оплаты");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPaymentId == -1)
            {
                MessageBox.Show("Выберите оплату");
                return;
            }

            string sql = @"
                UPDATE [Payments]
                SET
                    [OrderID] = ?,
                    [PaymentDate] = ?,
                    [Amount] = ?,
                    [PaymentMethod] = ?,
                    [PaymentStatus] = ?
                WHERE [PaymentID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", comboBoxOrder.SelectedValue),
                new OleDbParameter("@p2", dateTimePickerPaymentDate.Value),
                new OleDbParameter("@p3", Convert.ToDecimal(textBoxAmount.Text)),
                new OleDbParameter("@p4", textBoxPaymentMethod.Text),
                new OleDbParameter("@p5", textBoxPaymentStatus.Text),
                new OleDbParameter("@p6", selectedPaymentId)
            );

            if (result > 0)
            {
                MessageBox.Show("Оплата обновлена");
                LoadPayments();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении оплаты");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPaymentId == -1)
            {
                MessageBox.Show("Выберите оплату");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить оплату?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM [Payments] WHERE [PaymentID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedPaymentId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Оплата удалена");
                LoadPayments();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении оплаты");
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