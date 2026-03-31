namespace ISLogistic.Forms
{
    partial class PaymentsForm
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.labelPaymentStatus = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaymentMethod = new System.Windows.Forms.TextBox();
            this.textBoxPaymentStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(350, 20);
            this.labelTitle.Text = "Оплаты";

            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(25, 70);
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(760, 220);
            this.dgvPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellClick);

            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(25, 330);
            this.labelOrder.Text = "Заказ:";

            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Location = new System.Drawing.Point(25, 370);
            this.labelPaymentDate.Text = "Дата оплаты:";

            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(420, 330);
            this.labelAmount.Text = "Сумма:";

            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(420, 370);
            this.labelPaymentMethod.Text = "Способ оплаты:";

            this.labelPaymentStatus.AutoSize = true;
            this.labelPaymentStatus.Location = new System.Drawing.Point(420, 410);
            this.labelPaymentStatus.Text = "Статус оплаты:";

            this.comboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrder.Location = new System.Drawing.Point(140, 327);
            this.comboBoxOrder.Size = new System.Drawing.Size(220, 21);

            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(140, 367);
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(220, 20);

            this.textBoxAmount.Location = new System.Drawing.Point(540, 327);
            this.textBoxAmount.Size = new System.Drawing.Size(190, 20);

            this.textBoxPaymentMethod.Location = new System.Drawing.Point(540, 367);
            this.textBoxPaymentMethod.Size = new System.Drawing.Size(190, 20);

            this.textBoxPaymentStatus.Location = new System.Drawing.Point(540, 407);
            this.textBoxPaymentStatus.Size = new System.Drawing.Size(190, 20);

            this.btnAdd.Location = new System.Drawing.Point(28, 470);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(170, 470);
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(312, 470);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(454, 470);
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnBack.Location = new System.Drawing.Point(596, 470);
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.ClientSize = new System.Drawing.Size(814, 540);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelPaymentDate);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelPaymentStatus);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.dateTimePickerPaymentDate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPaymentMethod);
            this.Controls.Add(this.textBoxPaymentStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Name = "PaymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплаты";
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Label labelPaymentStatus;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPaymentMethod;
        private System.Windows.Forms.TextBox textBoxPaymentStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}