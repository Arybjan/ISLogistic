using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class ClientsForm : Form
    {
        private int selectedClientId = -1;
        private int roleID;

        public ClientsForm(int id)
        {
            InitializeComponent();
            roleID = id;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LoadClients();

            if (roleID == 3)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void LoadClients()
        {
            string sql = @"
                SELECT 
                    [ClientID],
                    [ClientType],
                    [CompanyName],
                    [ContactPerson],
                    [Phone],
                    [Email],
                    [Address]
                FROM [Clients]";

            DataTable table = Database.ExecuteQuery(sql);
            dgvClients.DataSource = table;

            dgvClients.Columns["ClientID"].HeaderText = "ID";
            dgvClients.Columns["ClientType"].HeaderText = "Тип клиента";
            dgvClients.Columns["CompanyName"].HeaderText = "Компания";
            dgvClients.Columns["ContactPerson"].HeaderText = "Контактное лицо";
            dgvClients.Columns["Phone"].HeaderText = "Телефон";
            dgvClients.Columns["Email"].HeaderText = "Email";
            dgvClients.Columns["Address"].HeaderText = "Адрес";

            dgvClients.ClearSelection();
        }

        private void ClearFields()
        {
            textBoxClientType.Clear();
            textBoxCompanyName.Clear();
            textBoxContactPerson.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();

            selectedClientId = -1;
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvClients.Rows[e.RowIndex];

            selectedClientId = Convert.ToInt32(row.Cells["ClientID"].Value);
            textBoxClientType.Text = row.Cells["ClientType"].Value.ToString();
            textBoxCompanyName.Text = row.Cells["CompanyName"].Value.ToString();
            textBoxContactPerson.Text = row.Cells["ContactPerson"].Value.ToString();
            textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
            textBoxEmail.Text = row.Cells["Email"].Value.ToString();
            textBoxAddress.Text = row.Cells["Address"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxClientType.Text == "" ||
                textBoxCompanyName.Text == "" ||
                textBoxContactPerson.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxAddress.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            string sql = @"
                INSERT INTO [Clients]
                ([ClientType], [CompanyName], [ContactPerson], [Phone], [Email], [Address])
                VALUES (?, ?, ?, ?, ?, ?)";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxClientType.Text),
                new OleDbParameter("@p2", textBoxCompanyName.Text),
                new OleDbParameter("@p3", textBoxContactPerson.Text),
                new OleDbParameter("@p4", textBoxPhone.Text),
                new OleDbParameter("@p5", textBoxEmail.Text),
                new OleDbParameter("@p6", textBoxAddress.Text)
            );

            if (result > 0)
            {
                MessageBox.Show("Клиент успешно добавлен");
                LoadClients();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении клиента");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedClientId == -1)
            {
                MessageBox.Show("Выберите клиента для редактирования");
                return;
            }

            if (textBoxClientType.Text == "" ||
                textBoxCompanyName.Text == "" ||
                textBoxContactPerson.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxAddress.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            string sql = @"
                UPDATE [Clients]
                SET
                    [ClientType] = ?,
                    [CompanyName] = ?,
                    [ContactPerson] = ?,
                    [Phone] = ?,
                    [Email] = ?,
                    [Address] = ?
                WHERE [ClientID] = ?";

            int result = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", textBoxClientType.Text),
                new OleDbParameter("@p2", textBoxCompanyName.Text),
                new OleDbParameter("@p3", textBoxContactPerson.Text),
                new OleDbParameter("@p4", textBoxPhone.Text),
                new OleDbParameter("@p5", textBoxEmail.Text),
                new OleDbParameter("@p6", textBoxAddress.Text),
                new OleDbParameter("@p7", selectedClientId)
            );

            if (result > 0)
            {
                MessageBox.Show("Данные клиента обновлены");
                LoadClients();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении клиента");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedClientId == -1)
            {
                MessageBox.Show("Выберите клиента для удаления");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить клиента?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            string sql = "DELETE FROM [Clients] WHERE [ClientID] = ?";

            int deleteResult = Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@p1", selectedClientId)
            );

            if (deleteResult > 0)
            {
                MessageBox.Show("Клиент удален");
                LoadClients();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении клиента");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(0, 0, ""); // Здесь нужно передать реальные данные пользователя
            this.Close();

        }
    }
}