using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            string sql = "SELECT [RoleID], [RoleName] FROM [Roles] WHERE [RoleID] <> 1";

            DataTable table = Database.ExecuteQuery(sql);

            comboBoxRole.DataSource = table;
            comboBoxRole.DisplayMember = "RoleName";
            comboBoxRole.ValueMember = "RoleID";
            comboBoxRole.SelectedIndex = -1;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                    //string.IsNullOrWhiteSpace(textBoxPosition.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                    comboBoxRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                string checkUserSql = "SELECT COUNT(*) FROM [Users] WHERE [Login] = ?";

                object result = Database.ExecuteScalar(
                    checkUserSql,
                    new OleDbParameter("@p1", textBoxLogin.Text.Trim())
                );

                int userCount = 0;
                if (result != null && result != DBNull.Value)
                    userCount = Convert.ToInt32(result);

                if (userCount > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.");
                    return;
                }

                string insertEmployeeSql = @"
                    INSERT INTO [Employees] ([FullName], [Phone], [Email])
                    VALUES (?, ?, ?)";

                int rows1 = Database.ExecuteNonQuery(
                    insertEmployeeSql,
                    new OleDbParameter("@p1", textBoxFullName.Text.Trim()),
                    new OleDbParameter("@p2", textBoxPhone.Text.Trim()),
                    new OleDbParameter("@p3", textBoxEmail.Text.Trim())
                );

                if (rows1 <= 0)
                {
                    MessageBox.Show("Ошибка при добавлении сотрудника.");
                    return;
                }

                string getLastEmployeeIdSql = "SELECT MAX([EmployeeID]) FROM [Employees]";
                object employeeIdObj = Database.ExecuteScalar(getLastEmployeeIdSql);

                if (employeeIdObj == null || employeeIdObj == DBNull.Value)
                {
                    MessageBox.Show("Не удалось получить ID сотрудника.");
                    return;
                }

                int employeeId = Convert.ToInt32(employeeIdObj);
                int roleId = Convert.ToInt32(comboBoxRole.SelectedValue);

                string insertUserSql = @"
                    INSERT INTO [Users] ([EmployeeID], [Login], [Password], [RoleID])
                    VALUES (?, ?, ?, ?)";

                int rows2 = Database.ExecuteNonQuery(
                    insertUserSql,
                    new OleDbParameter("@p1", employeeId),
                    new OleDbParameter("@p2", textBoxLogin.Text.Trim()),
                    new OleDbParameter("@p3", textBoxPassword.Text.Trim()),
                    new OleDbParameter("@p4", roleId)
                );

                if (rows2 > 0)
                {
                    MessageBox.Show("Регистрация успешно завершена.");

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка при создании учетной записи.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации:\n" + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}