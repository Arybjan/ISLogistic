using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class RoutesForm : Form
    {
        private int selectedRouteId = -1;

        public RoutesForm()
        {
            InitializeComponent();
        }

        private void RoutesForm_Load(object sender, EventArgs e)
        {
            LoadRoutes();
        }

        private void LoadRoutes()
        {
            string sql = @"
                SELECT
                    [RouteID],
                    [StartPoint],
                    [EndPoint],
                    [DistanceKM],
                    [EstimatedTimeHours],
                    [RouteNotes]
                FROM [Routes]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvRoutes.DataSource = table;

            dgvRoutes.Columns["RouteID"].HeaderText = "ID";
            dgvRoutes.Columns["StartPoint"].HeaderText = "Начальная точка";
            dgvRoutes.Columns["EndPoint"].HeaderText = "Конечная точка";
            dgvRoutes.Columns["DistanceKM"].HeaderText = "Расстояние (км)";
            dgvRoutes.Columns["EstimatedTimeHours"].HeaderText = "Время (ч)";
            dgvRoutes.Columns["RouteNotes"].HeaderText = "Примечание";

            dgvRoutes.ClearSelection();
        }

        private void ClearFields()
        {
            textBoxStartPoint.Clear();
            textBoxEndPoint.Clear();
            textBoxDistanceKM.Clear();
            textBoxEstimatedTimeHours.Clear();
            textBoxRouteNotes.Clear();

            selectedRouteId = -1;
        }

        private void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvRoutes.Rows[e.RowIndex];

            selectedRouteId = Convert.ToInt32(row.Cells["RouteID"].Value);
            textBoxStartPoint.Text = row.Cells["StartPoint"].Value.ToString();
            textBoxEndPoint.Text = row.Cells["EndPoint"].Value.ToString();
            textBoxDistanceKM.Text = row.Cells["DistanceKM"].Value.ToString();
            textBoxEstimatedTimeHours.Text = row.Cells["EstimatedTimeHours"].Value.ToString();
            textBoxRouteNotes.Text = row.Cells["RouteNotes"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxStartPoint.Text == "" ||
                textBoxEndPoint.Text == "" ||
                textBoxDistanceKM.Text == "" ||
                textBoxEstimatedTimeHours.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля");
                return;
            }

            string sql = @"
                INSERT INTO [Routes]
                ([StartPoint], [EndPoint], [DistanceKM], [EstimatedTimeHours], [RouteNotes])
                VALUES (?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxStartPoint.Text),
                new OleDbParameter("@p2", textBoxEndPoint.Text),
                new OleDbParameter("@p3", Convert.ToDouble(textBoxDistanceKM.Text)),
                new OleDbParameter("@p4", Convert.ToDouble(textBoxEstimatedTimeHours.Text)),
                new OleDbParameter("@p5", textBoxRouteNotes.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Маршрут добавлен");
                LoadRoutes();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении маршрута");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRouteId == -1)
            {
                MessageBox.Show("Выберите маршрут");
                return;
            }

            string sql = @"
                UPDATE [Routes]
                SET
                    [StartPoint] = ?,
                    [EndPoint] = ?,
                    [DistanceKM] = ?,
                    [EstimatedTimeHours] = ?,
                    [RouteNotes] = ?
                WHERE [RouteID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxStartPoint.Text),
                new OleDbParameter("@p2", textBoxEndPoint.Text),
                new OleDbParameter("@p3", Convert.ToDouble(textBoxDistanceKM.Text)),
                new OleDbParameter("@p4", Convert.ToDouble(textBoxEstimatedTimeHours.Text)),
                new OleDbParameter("@p5", textBoxRouteNotes.Text),
                new OleDbParameter("@p6", selectedRouteId)
            );

            if (result > 0)
            {
                MessageBox.Show("Маршрут обновлен");
                LoadRoutes();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении маршрута");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRouteId == -1)
            {
                MessageBox.Show("Выберите маршрут");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить маршрут?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM [Routes] WHERE [RouteID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedRouteId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Маршрут удален");
                LoadRoutes();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении маршрута");
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