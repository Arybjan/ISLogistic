namespace ISLogistic.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnShipments = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(160, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(315, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Информационная система";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(25, 70);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(89, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Пользователь: ";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(25, 95);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(41, 13);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Роль: ";
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(28, 140);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(170, 40);
            this.btnClients.TabIndex = 3;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(226, 140);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(170, 40);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(424, 140);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(170, 40);
            this.btnCargo.TabIndex = 5;
            this.btnCargo.Text = "Грузы";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Location = new System.Drawing.Point(28, 200);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(170, 40);
            this.btnDrivers.TabIndex = 6;
            this.btnDrivers.Text = "Водители";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(226, 200);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(170, 40);
            this.btnVehicles.TabIndex = 7;
            this.btnVehicles.Text = "Транспорт";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.Location = new System.Drawing.Point(424, 200);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(170, 40);
            this.btnRoutes.TabIndex = 8;
            this.btnRoutes.Text = "Маршруты";
            this.btnRoutes.UseVisualStyleBackColor = true;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnShipments
            // 
            this.btnShipments.Location = new System.Drawing.Point(28, 260);
            this.btnShipments.Name = "btnShipments";
            this.btnShipments.Size = new System.Drawing.Size(170, 40);
            this.btnShipments.TabIndex = 9;
            this.btnShipments.Text = "Перевозки";
            this.btnShipments.UseVisualStyleBackColor = true;
            this.btnShipments.Click += new System.EventHandler(this.btnShipments_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(226, 260);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(170, 40);
            this.btnPayments.TabIndex = 10;
            this.btnPayments.Text = "Оплаты";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(424, 260);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(170, 40);
            this.btnEmployees.TabIndex = 11;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 40);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnShipments);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IS Logistic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnShipments;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnExit;
    }
}