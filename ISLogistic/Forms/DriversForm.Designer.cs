namespace ISLogistic.Forms
{
    partial class DriversForm
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
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLicenseNumber = new System.Windows.Forms.Label();
            this.labelLicenseCategory = new System.Windows.Forms.Label();
            this.labelHireDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLicenseNumber = new System.Windows.Forms.TextBox();
            this.textBoxLicenseCategory = new System.Windows.Forms.TextBox();
            this.dateTimePickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(340, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(127, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Водители";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(25, 70);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(760, 220);
            this.dgvDrivers.TabIndex = 1;
            this.dgvDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellClick);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(25, 320);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(37, 13);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "ФИО:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(25, 355);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 13);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelLicenseNumber
            // 
            this.labelLicenseNumber.AutoSize = true;
            this.labelLicenseNumber.Location = new System.Drawing.Point(25, 390);
            this.labelLicenseNumber.Name = "labelLicenseNumber";
            this.labelLicenseNumber.Size = new System.Drawing.Size(85, 13);
            this.labelLicenseNumber.TabIndex = 4;
            this.labelLicenseNumber.Text = "Номер прав:";
            // 
            // labelLicenseCategory
            // 
            this.labelLicenseCategory.AutoSize = true;
            this.labelLicenseCategory.Location = new System.Drawing.Point(25, 425);
            this.labelLicenseCategory.Name = "labelLicenseCategory";
            this.labelLicenseCategory.Size = new System.Drawing.Size(66, 13);
            this.labelLicenseCategory.TabIndex = 5;
            this.labelLicenseCategory.Text = "Категория:";
            // 
            // labelHireDate
            // 
            this.labelHireDate.AutoSize = true;
            this.labelHireDate.Location = new System.Drawing.Point(420, 320);
            this.labelHireDate.Name = "labelHireDate";
            this.labelHireDate.Size = new System.Drawing.Size(74, 13);
            this.labelHireDate.TabIndex = 6;
            this.labelHireDate.Text = "Дата найма:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(420, 355);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Статус:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(140, 317);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(230, 20);
            this.textBoxFullName.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(140, 352);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(230, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxLicenseNumber
            // 
            this.textBoxLicenseNumber.Location = new System.Drawing.Point(140, 387);
            this.textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            this.textBoxLicenseNumber.Size = new System.Drawing.Size(230, 20);
            this.textBoxLicenseNumber.TabIndex = 10;
            // 
            // textBoxLicenseCategory
            // 
            this.textBoxLicenseCategory.Location = new System.Drawing.Point(140, 422);
            this.textBoxLicenseCategory.Name = "textBoxLicenseCategory";
            this.textBoxLicenseCategory.Size = new System.Drawing.Size(230, 20);
            this.textBoxLicenseCategory.TabIndex = 11;
            // 
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(500, 317);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerHireDate.TabIndex = 12;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(500, 352);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(230, 20);
            this.textBoxStatus.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(596, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DriversForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.dateTimePickerHireDate);
            this.Controls.Add(this.textBoxLicenseCategory);
            this.Controls.Add(this.textBoxLicenseNumber);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelHireDate);
            this.Controls.Add(this.labelLicenseCategory);
            this.Controls.Add(this.labelLicenseNumber);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.labelTitle);
            this.Name = "DriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водители";
            this.Load += new System.EventHandler(this.DriversForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLicenseNumber;
        private System.Windows.Forms.Label labelLicenseCategory;
        private System.Windows.Forms.Label labelHireDate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLicenseNumber;
        private System.Windows.Forms.TextBox textBoxLicenseCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerHireDate;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}