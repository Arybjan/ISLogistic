namespace ISLogistic.Forms
{
    partial class VehiclesForm
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPlateNumber = new System.Windows.Forms.Label();
            this.labelCapacityWeight = new System.Windows.Forms.Label();
            this.labelCapacityVolume = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.textBoxCapacityWeight = new System.Windows.Forms.TextBox();
            this.textBoxCapacityVolume = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(330, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Транспорт";
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(25, 70);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(760, 220);
            this.dgvVehicles.TabIndex = 1;
            this.dgvVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellClick);
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Location = new System.Drawing.Point(25, 320);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(96, 13);
            this.labelVehicleType.TabIndex = 2;
            this.labelVehicleType.Text = "Тип транспорта:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(25, 355);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(43, 13);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "Марка:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(25, 390);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 13);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Модель:";
            // 
            // labelPlateNumber
            // 
            this.labelPlateNumber.AutoSize = true;
            this.labelPlateNumber.Location = new System.Drawing.Point(25, 425);
            this.labelPlateNumber.Name = "labelPlateNumber";
            this.labelPlateNumber.Size = new System.Drawing.Size(75, 13);
            this.labelPlateNumber.TabIndex = 5;
            this.labelPlateNumber.Text = "Гос. номер:";
            // 
            // labelCapacityWeight
            // 
            this.labelCapacityWeight.AutoSize = true;
            this.labelCapacityWeight.Location = new System.Drawing.Point(420, 320);
            this.labelCapacityWeight.Name = "labelCapacityWeight";
            this.labelCapacityWeight.Size = new System.Drawing.Size(111, 13);
            this.labelCapacityWeight.TabIndex = 6;
            this.labelCapacityWeight.Text = "Грузоподъемность:";
            // 
            // labelCapacityVolume
            // 
            this.labelCapacityVolume.AutoSize = true;
            this.labelCapacityVolume.Location = new System.Drawing.Point(420, 355);
            this.labelCapacityVolume.Name = "labelCapacityVolume";
            this.labelCapacityVolume.Size = new System.Drawing.Size(45, 13);
            this.labelCapacityVolume.TabIndex = 7;
            this.labelCapacityVolume.Text = "Объем:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(420, 390);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(76, 13);
            this.labelYear.TabIndex = 8;
            this.labelYear.Text = "Год выпуска:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(420, 425);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Статус:";
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(140, 317);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(230, 21);
            this.comboBoxVehicleType.TabIndex = 10;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(140, 352);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(230, 20);
            this.textBoxBrand.TabIndex = 11;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(140, 387);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(230, 20);
            this.textBoxModel.TabIndex = 12;
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.Location = new System.Drawing.Point(140, 422);
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.Size = new System.Drawing.Size(230, 20);
            this.textBoxPlateNumber.TabIndex = 13;
            // 
            // textBoxCapacityWeight
            // 
            this.textBoxCapacityWeight.Location = new System.Drawing.Point(540, 317);
            this.textBoxCapacityWeight.Name = "textBoxCapacityWeight";
            this.textBoxCapacityWeight.Size = new System.Drawing.Size(190, 20);
            this.textBoxCapacityWeight.TabIndex = 14;
            // 
            // textBoxCapacityVolume
            // 
            this.textBoxCapacityVolume.Location = new System.Drawing.Point(540, 352);
            this.textBoxCapacityVolume.Name = "textBoxCapacityVolume";
            this.textBoxCapacityVolume.Size = new System.Drawing.Size(190, 20);
            this.textBoxCapacityVolume.TabIndex = 15;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(540, 387);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(190, 20);
            this.textBoxYear.TabIndex = 16;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(540, 422);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(190, 20);
            this.textBoxStatus.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(596, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VehiclesForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxCapacityVolume);
            this.Controls.Add(this.textBoxCapacityWeight);
            this.Controls.Add(this.textBoxPlateNumber);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.comboBoxVehicleType);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelCapacityVolume);
            this.Controls.Add(this.labelCapacityWeight);
            this.Controls.Add(this.labelPlateNumber);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelVehicleType);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.labelTitle);
            this.Name = "VehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Транспорт";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPlateNumber;
        private System.Windows.Forms.Label labelCapacityWeight;
        private System.Windows.Forms.Label labelCapacityVolume;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        private System.Windows.Forms.TextBox textBoxCapacityWeight;
        private System.Windows.Forms.TextBox textBoxCapacityVolume;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}