using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class EmployeesForm : Form
    {
        private int selectedEmployeeId = -1;

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            string sql = @"
                SELECT
                    [EmployeeID],
                    [FullName],
                    [Phone],
                    [Email],
                    [Position]
                FROM [Employees]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvEmployees.DataSource = table;

            dgvEmployees.Columns["EmployeeID"].HeaderText = "ID";
            dgvEmployees.Columns["FullName"].HeaderText = "ФИО";
            dgvEmployees.Columns["Phone"].HeaderText = "Телефон";
            dgvEmployees.Columns["Email"].HeaderText = "Email";
            dgvEmployees.Columns["Position"].HeaderText = "Должность";

            dgvEmployees.ClearSelection();
        }

        private void ClearFields()
        {
            textBoxFullName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxPosition.Clear();

            selectedEmployeeId = -1;
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

            selectedEmployeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
            textBoxFullName.Text = row.Cells["FullName"].Value.ToString();
            textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
            textBoxEmail.Text = row.Cells["Email"].Value.ToString();
            textBoxPosition.Text = row.Cells["Position"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxPosition.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            string sql = @"
                INSERT INTO [Employees]
                ([FullName], [Phone], [Email], [Position])
                VALUES (?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxFullName.Text),
                new OleDbParameter("@p2", textBoxPhone.Text),
                new OleDbParameter("@p3", textBoxEmail.Text),
                new OleDbParameter("@p4", textBoxPosition.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Сотрудник добавлен");
                LoadEmployees();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении сотрудника");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            string sql = @"
                UPDATE [Employees]
                SET
                    [FullName] = ?,
                    [Phone] = ?,
                    [Email] = ?,
                    [Position] = ?
                WHERE [EmployeeID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxFullName.Text),
                new OleDbParameter("@p2", textBoxPhone.Text),
                new OleDbParameter("@p3", textBoxEmail.Text),
                new OleDbParameter("@p4", textBoxPosition.Text),
                new OleDbParameter("@p5", selectedEmployeeId)
            );

            if (result > 0)
            {
                MessageBox.Show("Данные сотрудника обновлены");
                LoadEmployees();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении сотрудника");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить сотрудника?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM [Employees] WHERE [EmployeeID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedEmployeeId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Сотрудник удален");
                LoadEmployees();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении сотрудника");
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