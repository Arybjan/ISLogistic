namespace ISLogistic.Forms
{
    partial class OrdersForm
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

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelPickupAddress = new System.Windows.Forms.Label();
            this.labelDeliveryAddress = new System.Windows.Forms.Label();
            this.labelPickupDate = new System.Windows.Forms.Label();
            this.labelPlannedDeliveryDate = new System.Windows.Forms.Label();
            this.labelActualDeliveryDate = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPickupAddress = new System.Windows.Forms.TextBox();
            this.textBoxDeliveryAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerPickupDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPlannedDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerActualDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(370, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Заказы";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(25, 70);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(900, 220);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(25, 320);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Клиент:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(25, 355);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Статус:";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(25, 390);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(76, 13);
            this.labelOrderDate.TabIndex = 4;
            this.labelOrderDate.Text = "Дата заказа:";
            // 
            // labelPickupAddress
            // 
            this.labelPickupAddress.AutoSize = true;
            this.labelPickupAddress.Location = new System.Drawing.Point(25, 425);
            this.labelPickupAddress.Name = "labelPickupAddress";
            this.labelPickupAddress.Size = new System.Drawing.Size(89, 13);
            this.labelPickupAddress.TabIndex = 5;
            this.labelPickupAddress.Text = "Адрес отправки:";
            // 
            // labelDeliveryAddress
            // 
            this.labelDeliveryAddress.AutoSize = true;
            this.labelDeliveryAddress.Location = new System.Drawing.Point(25, 460);
            this.labelDeliveryAddress.Name = "labelDeliveryAddress";
            this.labelDeliveryAddress.Size = new System.Drawing.Size(89, 13);
            this.labelDeliveryAddress.TabIndex = 6;
            this.labelDeliveryAddress.Text = "Адрес доставки:";
            // 
            // labelPickupDate
            // 
            this.labelPickupDate.AutoSize = true;
            this.labelPickupDate.Location = new System.Drawing.Point(500, 320);
            this.labelPickupDate.Name = "labelPickupDate";
            this.labelPickupDate.Size = new System.Drawing.Size(86, 13);
            this.labelPickupDate.TabIndex = 7;
            this.labelPickupDate.Text = "Дата отправки:";
            // 
            // labelPlannedDeliveryDate
            // 
            this.labelPlannedDeliveryDate.AutoSize = true;
            this.labelPlannedDeliveryDate.Location = new System.Drawing.Point(500, 355);
            this.labelPlannedDeliveryDate.Name = "labelPlannedDeliveryDate";
            this.labelPlannedDeliveryDate.Size = new System.Drawing.Size(135, 13);
            this.labelPlannedDeliveryDate.TabIndex = 8;
            this.labelPlannedDeliveryDate.Text = "План. дата доставки:";
            // 
            // labelActualDeliveryDate
            // 
            this.labelActualDeliveryDate.AutoSize = true;
            this.labelActualDeliveryDate.Location = new System.Drawing.Point(500, 390);
            this.labelActualDeliveryDate.Name = "labelActualDeliveryDate";
            this.labelActualDeliveryDate.Size = new System.Drawing.Size(131, 13);
            this.labelActualDeliveryDate.TabIndex = 9;
            this.labelActualDeliveryDate.Text = "Факт. дата доставки:";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(500, 425);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(65, 13);
            this.labelTotalCost.TabIndex = 10;
            this.labelTotalCost.Text = "Стоимость:";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(500, 460);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(73, 13);
            this.labelNotes.TabIndex = 11;
            this.labelNotes.Text = "Примечание:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(140, 317);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(260, 21);
            this.comboBoxClient.TabIndex = 12;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(140, 352);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(260, 21);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(140, 387);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerOrderDate.TabIndex = 14;
            // 
            // textBoxPickupAddress
            // 
            this.textBoxPickupAddress.Location = new System.Drawing.Point(140, 422);
            this.textBoxPickupAddress.Name = "textBoxPickupAddress";
            this.textBoxPickupAddress.Size = new System.Drawing.Size(260, 20);
            this.textBoxPickupAddress.TabIndex = 15;
            // 
            // textBoxDeliveryAddress
            // 
            this.textBoxDeliveryAddress.Location = new System.Drawing.Point(140, 457);
            this.textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            this.textBoxDeliveryAddress.Size = new System.Drawing.Size(260, 20);
            this.textBoxDeliveryAddress.TabIndex = 16;
            // 
            // dateTimePickerPickupDate
            // 
            this.dateTimePickerPickupDate.Location = new System.Drawing.Point(660, 317);
            this.dateTimePickerPickupDate.Name = "dateTimePickerPickupDate";
            this.dateTimePickerPickupDate.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerPickupDate.TabIndex = 17;
            // 
            // dateTimePickerPlannedDeliveryDate
            // 
            this.dateTimePickerPlannedDeliveryDate.Location = new System.Drawing.Point(660, 352);
            this.dateTimePickerPlannedDeliveryDate.Name = "dateTimePickerPlannedDeliveryDate";
            this.dateTimePickerPlannedDeliveryDate.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerPlannedDeliveryDate.TabIndex = 18;
            // 
            // dateTimePickerActualDeliveryDate
            // 
            this.dateTimePickerActualDeliveryDate.Location = new System.Drawing.Point(660, 387);
            this.dateTimePickerActualDeliveryDate.Name = "dateTimePickerActualDeliveryDate";
            this.dateTimePickerActualDeliveryDate.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerActualDeliveryDate.TabIndex = 19;
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(660, 422);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(240, 20);
            this.textBoxTotalCost.TabIndex = 20;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(660, 457);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(240, 70);
            this.textBoxNotes.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 550);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 550);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(680, 550);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OrdersForm
            // 
            this.ClientSize = new System.Drawing.Size(954, 610);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.dateTimePickerActualDeliveryDate);
            this.Controls.Add(this.dateTimePickerPlannedDeliveryDate);
            this.Controls.Add(this.dateTimePickerPickupDate);
            this.Controls.Add(this.textBoxDeliveryAddress);
            this.Controls.Add(this.textBoxPickupAddress);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelActualDeliveryDate);
            this.Controls.Add(this.labelPlannedDeliveryDate);
            this.Controls.Add(this.labelPickupDate);
            this.Controls.Add(this.labelDeliveryAddress);
            this.Controls.Add(this.labelPickupAddress);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.labelTitle);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelPickupAddress;
        private System.Windows.Forms.Label labelDeliveryAddress;
        private System.Windows.Forms.Label labelPickupDate;
        private System.Windows.Forms.Label labelPlannedDeliveryDate;
        private System.Windows.Forms.Label labelActualDeliveryDate;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.TextBox textBoxPickupAddress;
        private System.Windows.Forms.TextBox textBoxDeliveryAddress;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickupDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlannedDeliveryDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerActualDeliveryDate;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}