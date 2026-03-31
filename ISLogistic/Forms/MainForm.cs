using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISLogistic.Forms
{
    public partial class MainForm : Form
    {
        private int userId;
        private int roleId;
        private string userName;

        public MainForm(int id, int role, string username)
        {
            InitializeComponent();
            userId = id;
            roleId = role;
            userName = username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = $"Вы вошли как: {userName}";
            labelRole.Text = $"Роль: {GetRoleName(roleId)}";

            // Роли
            if (roleId == 3) // USER
            {
                btnEmployees.Enabled = false;
                btnPayments.Enabled = false;
                btnDrivers.Enabled = false;
            }

            if (roleId == 2) // MANAGER
            {
                btnEmployees.Enabled = false;
            }
        }

        private string GetRoleName(int role)
        {
            if (role == 1)
                return "Администратор";
            else if (role == 2)
                return "Клиент";
            else return "Логист";
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(roleId);
            clientsForm.Show();
            //this.Hide();
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            CargoForm form = new CargoForm();
            form.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm form = new PaymentsForm();
            form.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm();
            form.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            DriversForm form = new DriversForm();
            form.ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            VehiclesForm form = new VehiclesForm();
            form.ShowDialog();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            RoutesForm form = new RoutesForm();
            form.ShowDialog();
        }

        private void btnShipments_Click(object sender, EventArgs e)
        {
            ShipmentsForm form = new ShipmentsForm();
            form.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}