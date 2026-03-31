namespace ISLogistic.Forms
{
    partial class CargoForm
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
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelCargoName = new System.Windows.Forms.Label();
            this.labelCargoType = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDeclaredValue = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxCargoType = new System.Windows.Forms.ComboBox();
            this.textBoxCargoName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDeclaredValue = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxFragile = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(360, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Грузы";
            // 
            // dgvCargo
            // 
            this.dgvCargo.AllowUserToAddRows = false;
            this.dgvCargo.AllowUserToDeleteRows = false;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Location = new System.Drawing.Point(25, 70);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.ReadOnly = true;
            this.dgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargo.Size = new System.Drawing.Size(760, 220);
            this.dgvCargo.TabIndex = 1;
            this.dgvCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargo_CellClick);
            // 
            // labels
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(25, 320);
            this.labelOrder.Text = "Заказ:";
            this.labelCargoName.AutoSize = true;
            this.labelCargoName.Location = new System.Drawing.Point(25, 355);
            this.labelCargoName.Text = "Название:";
            this.labelCargoType.AutoSize = true;
            this.labelCargoType.Location = new System.Drawing.Point(25, 390);
            this.labelCargoType.Text = "Тип груза:";
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(25, 425);
            this.labelWeight.Text = "Вес:";
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(420, 320);
            this.labelVolume.Text = "Объем:";
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(420, 355);
            this.labelQuantity.Text = "Количество:";
            this.labelDeclaredValue.AutoSize = true;
            this.labelDeclaredValue.Location = new System.Drawing.Point(420, 390);
            this.labelDeclaredValue.Text = "Стоимость:";
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(420, 425);
            this.labelDescription.Text = "Описание:";
            // 
            // controls
            // 
            this.comboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrder.Location = new System.Drawing.Point(140, 317);
            this.comboBoxOrder.Size = new System.Drawing.Size(230, 21);

            this.textBoxCargoName.Location = new System.Drawing.Point(140, 352);
            this.textBoxCargoName.Size = new System.Drawing.Size(230, 20);

            this.comboBoxCargoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargoType.Location = new System.Drawing.Point(140, 387);
            this.comboBoxCargoType.Size = new System.Drawing.Size(230, 21);

            this.textBoxWeight.Location = new System.Drawing.Point(140, 422);
            this.textBoxWeight.Size = new System.Drawing.Size(230, 20);

            this.textBoxVolume.Location = new System.Drawing.Point(540, 317);
            this.textBoxVolume.Size = new System.Drawing.Size(190, 20);

            this.textBoxQuantity.Location = new System.Drawing.Point(540, 352);
            this.textBoxQuantity.Size = new System.Drawing.Size(190, 20);

            this.textBoxDeclaredValue.Location = new System.Drawing.Point(540, 387);
            this.textBoxDeclaredValue.Size = new System.Drawing.Size(190, 20);

            this.textBoxDescription.Location = new System.Drawing.Point(540, 422);
            this.textBoxDescription.Size = new System.Drawing.Size(190, 50);
            this.textBoxDescription.Multiline = true;

            this.checkBoxFragile.AutoSize = true;
            this.checkBoxFragile.Location = new System.Drawing.Point(140, 455);
            this.checkBoxFragile.Text = "Хрупкий груз";

            // buttons
            this.btnAdd.Location = new System.Drawing.Point(28, 500);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(170, 500);
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(312, 500);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(454, 500);
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnBack.Location = new System.Drawing.Point(596, 500);
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // form
            this.ClientSize = new System.Drawing.Size(814, 560);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvCargo);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelCargoName);
            this.Controls.Add(this.labelCargoType);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDeclaredValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.comboBoxCargoType);
            this.Controls.Add(this.textBoxCargoName);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxDeclaredValue);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxFragile);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Name = "CargoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Грузы";
            this.Load += new System.EventHandler(this.CargoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelCargoName;
        private System.Windows.Forms.Label labelCargoType;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDeclaredValue;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.ComboBox comboBoxCargoType;
        private System.Windows.Forms.TextBox textBoxCargoName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxDeclaredValue;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxFragile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}