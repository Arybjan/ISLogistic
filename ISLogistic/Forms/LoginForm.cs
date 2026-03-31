using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISLogistic.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            string sql = @"
                SELECT [Users].[UserID] AS id, [Employees].[FullName] AS name, [Users].[RoleID] AS role_id
                FROM [Users]
                INNER JOIN [Employees] ON [Users].[EmployeeID] = [Employees].[EmployeeID]
                WHERE [Users].[Login] = ? AND [Users].[Password] = ?";

            DataTable table = Database.ExecuteQuery(
                sql,
                new OleDbParameter("@p1", textBoxLogin.Text.Trim()),
                new OleDbParameter("@p2", textBoxPassword.Text.Trim())
            );

            if (table.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(table.Rows[0]["id"]);
                string name = table.Rows[0]["name"].ToString();
                int roleId = Convert.ToInt32(table.Rows[0]["role_id"]);

                MainForm main = new MainForm(userId, roleId, name);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void btnRegiste_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}