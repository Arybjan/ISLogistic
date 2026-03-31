namespace ISLogistic.Forms
{
    partial class ShipmentsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvShipments;
        private System.Windows.Forms.GroupBox groupBoxData;

        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelStatus;

        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.ComboBox comboBoxVehicle;
        private System.Windows.Forms.ComboBox comboBoxRoute;

        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;

        private System.Windows.Forms.TextBox textBoxStatus;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dgvShipments = new System.Windows.Forms.DataGridView();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelDriver = new System.Windows.Forms.Label();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelRoute = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.comboBoxRoute = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(350, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Перевозки";
            // 
            // dgvShipments
            // 
            this.dgvShipments.AllowUserToAddRows = false;
            this.dgvShipments.ColumnHeadersHeight = 29;
            this.dgvShipments.Location = new System.Drawing.Point(20, 60);
            this.dgvShipments.Name = "dgvShipments";
            this.dgvShipments.ReadOnly = true;
            this.dgvShipments.RowHeadersWidth = 51;
            this.dgvShipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipments.Size = new System.Drawing.Size(820, 220);
            this.dgvShipments.TabIndex = 1;
            this.dgvShipments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipments_CellClick);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.labelOrder);
            this.groupBoxData.Controls.Add(this.labelDriver);
            this.groupBoxData.Controls.Add(this.labelVehicle);
            this.groupBoxData.Controls.Add(this.labelRoute);
            this.groupBoxData.Controls.Add(this.labelDeparture);
            this.groupBoxData.Controls.Add(this.labelArrival);
            this.groupBoxData.Controls.Add(this.labelStatus);
            this.groupBoxData.Controls.Add(this.comboBoxOrder);
            this.groupBoxData.Controls.Add(this.comboBoxDriver);
            this.groupBoxData.Controls.Add(this.comboBoxVehicle);
            this.groupBoxData.Controls.Add(this.comboBoxRoute);
            this.groupBoxData.Controls.Add(this.dateTimePickerDeparture);
            this.groupBoxData.Controls.Add(this.dateTimePickerArrival);
            this.groupBoxData.Controls.Add(this.textBoxStatus);
            this.groupBoxData.Location = new System.Drawing.Point(20, 300);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(820, 180);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные перевозки";
            // 
            // labelOrder
            // 
            this.labelOrder.Location = new System.Drawing.Point(20, 30);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(100, 23);
            this.labelOrder.TabIndex = 0;
            this.labelOrder.Text = "Заказ:";
            // 
            // labelDriver
            // 
            this.labelDriver.Location = new System.Drawing.Point(20, 65);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(100, 23);
            this.labelDriver.TabIndex = 1;
            this.labelDriver.Text = "Водитель:";
            // 
            // labelVehicle
            // 
            this.labelVehicle.Location = new System.Drawing.Point(20, 100);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(100, 23);
            this.labelVehicle.TabIndex = 2;
            this.labelVehicle.Text = "Транспорт:";
            // 
            // labelRoute
            // 
            this.labelRoute.Location = new System.Drawing.Point(20, 135);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(100, 23);
            this.labelRoute.TabIndex = 3;
            this.labelRoute.Text = "Маршрут:";
            // 
            // labelDeparture
            // 
            this.labelDeparture.Location = new System.Drawing.Point(400, 30);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(100, 23);
            this.labelDeparture.TabIndex = 4;
            this.labelDeparture.Text = "Отправка:";
            // 
            // labelArrival
            // 
            this.labelArrival.Location = new System.Drawing.Point(400, 65);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(100, 23);
            this.labelArrival.TabIndex = 5;
            this.labelArrival.Text = "Прибытие:";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(400, 100);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(100, 23);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Статус:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.Location = new System.Drawing.Point(120, 27);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(220, 24);
            this.comboBoxOrder.TabIndex = 7;
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.Location = new System.Drawing.Point(120, 62);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(220, 24);
            this.comboBoxDriver.TabIndex = 8;
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.Location = new System.Drawing.Point(120, 97);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(220, 24);
            this.comboBoxVehicle.TabIndex = 9;
            // 
            // comboBoxRoute
            // 
            this.comboBoxRoute.Location = new System.Drawing.Point(120, 132);
            this.comboBoxRoute.Name = "comboBoxRoute";
            this.comboBoxRoute.Size = new System.Drawing.Size(220, 24);
            this.comboBoxRoute.TabIndex = 10;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(500, 27);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerDeparture.TabIndex = 11;
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(500, 62);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerArrival.TabIndex = 12;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(500, 97);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(250, 22);
            this.textBoxStatus.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(380, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(510, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(640, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShipmentsForm
            // 
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvShipments);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Name = "ShipmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевозки";
            this.Load += new System.EventHandler(this.ShipmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}