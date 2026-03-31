namespace ISLogistic.Forms
{
    partial class RoutesForm
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
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.labelStartPoint = new System.Windows.Forms.Label();
            this.labelEndPoint = new System.Windows.Forms.Label();
            this.labelDistanceKM = new System.Windows.Forms.Label();
            this.labelEstimatedTimeHours = new System.Windows.Forms.Label();
            this.labelRouteNotes = new System.Windows.Forms.Label();
            this.textBoxStartPoint = new System.Windows.Forms.TextBox();
            this.textBoxEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxDistanceKM = new System.Windows.Forms.TextBox();
            this.textBoxEstimatedTimeHours = new System.Windows.Forms.TextBox();
            this.textBoxRouteNotes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(340, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(122, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Маршруты";
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.AllowUserToAddRows = false;
            this.dgvRoutes.AllowUserToDeleteRows = false;
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Location = new System.Drawing.Point(25, 70);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.ReadOnly = true;
            this.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoutes.Size = new System.Drawing.Size(760, 220);
            this.dgvRoutes.TabIndex = 1;
            this.dgvRoutes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoutes_CellClick);
            // 
            // labelStartPoint
            // 
            this.labelStartPoint.AutoSize = true;
            this.labelStartPoint.Location = new System.Drawing.Point(25, 320);
            this.labelStartPoint.Name = "labelStartPoint";
            this.labelStartPoint.Size = new System.Drawing.Size(98, 13);
            this.labelStartPoint.TabIndex = 2;
            this.labelStartPoint.Text = "Начальная точка:";
            // 
            // labelEndPoint
            // 
            this.labelEndPoint.AutoSize = true;
            this.labelEndPoint.Location = new System.Drawing.Point(25, 355);
            this.labelEndPoint.Name = "labelEndPoint";
            this.labelEndPoint.Size = new System.Drawing.Size(99, 13);
            this.labelEndPoint.TabIndex = 3;
            this.labelEndPoint.Text = "Конечная точка:";
            // 
            // labelDistanceKM
            // 
            this.labelDistanceKM.AutoSize = true;
            this.labelDistanceKM.Location = new System.Drawing.Point(25, 390);
            this.labelDistanceKM.Name = "labelDistanceKM";
            this.labelDistanceKM.Size = new System.Drawing.Size(95, 13);
            this.labelDistanceKM.TabIndex = 4;
            this.labelDistanceKM.Text = "Расстояние (км):";
            // 
            // labelEstimatedTimeHours
            // 
            this.labelEstimatedTimeHours.AutoSize = true;
            this.labelEstimatedTimeHours.Location = new System.Drawing.Point(420, 320);
            this.labelEstimatedTimeHours.Name = "labelEstimatedTimeHours";
            this.labelEstimatedTimeHours.Size = new System.Drawing.Size(59, 13);
            this.labelEstimatedTimeHours.TabIndex = 5;
            this.labelEstimatedTimeHours.Text = "Время (ч):";
            // 
            // labelRouteNotes
            // 
            this.labelRouteNotes.AutoSize = true;
            this.labelRouteNotes.Location = new System.Drawing.Point(420, 355);
            this.labelRouteNotes.Name = "labelRouteNotes";
            this.labelRouteNotes.Size = new System.Drawing.Size(73, 13);
            this.labelRouteNotes.TabIndex = 6;
            this.labelRouteNotes.Text = "Примечание:";
            // 
            // textBoxStartPoint
            // 
            this.textBoxStartPoint.Location = new System.Drawing.Point(140, 317);
            this.textBoxStartPoint.Name = "textBoxStartPoint";
            this.textBoxStartPoint.Size = new System.Drawing.Size(230, 20);
            this.textBoxStartPoint.TabIndex = 7;
            // 
            // textBoxEndPoint
            // 
            this.textBoxEndPoint.Location = new System.Drawing.Point(140, 352);
            this.textBoxEndPoint.Name = "textBoxEndPoint";
            this.textBoxEndPoint.Size = new System.Drawing.Size(230, 20);
            this.textBoxEndPoint.TabIndex = 8;
            // 
            // textBoxDistanceKM
            // 
            this.textBoxDistanceKM.Location = new System.Drawing.Point(140, 387);
            this.textBoxDistanceKM.Name = "textBoxDistanceKM";
            this.textBoxDistanceKM.Size = new System.Drawing.Size(230, 20);
            this.textBoxDistanceKM.TabIndex = 9;
            // 
            // textBoxEstimatedTimeHours
            // 
            this.textBoxEstimatedTimeHours.Location = new System.Drawing.Point(520, 317);
            this.textBoxEstimatedTimeHours.Name = "textBoxEstimatedTimeHours";
            this.textBoxEstimatedTimeHours.Size = new System.Drawing.Size(210, 20);
            this.textBoxEstimatedTimeHours.TabIndex = 10;
            // 
            // textBoxRouteNotes
            // 
            this.textBoxRouteNotes.Location = new System.Drawing.Point(520, 352);
            this.textBoxRouteNotes.Multiline = true;
            this.textBoxRouteNotes.Name = "textBoxRouteNotes";
            this.textBoxRouteNotes.Size = new System.Drawing.Size(210, 90);
            this.textBoxRouteNotes.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(596, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RoutesForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxRouteNotes);
            this.Controls.Add(this.textBoxEstimatedTimeHours);
            this.Controls.Add(this.textBoxDistanceKM);
            this.Controls.Add(this.textBoxEndPoint);
            this.Controls.Add(this.textBoxStartPoint);
            this.Controls.Add(this.labelRouteNotes);
            this.Controls.Add(this.labelEstimatedTimeHours);
            this.Controls.Add(this.labelDistanceKM);
            this.Controls.Add(this.labelEndPoint);
            this.Controls.Add(this.labelStartPoint);
            this.Controls.Add(this.dgvRoutes);
            this.Controls.Add(this.labelTitle);
            this.Name = "RoutesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршруты";
            this.Load += new System.EventHandler(this.RoutesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.Label labelStartPoint;
        private System.Windows.Forms.Label labelEndPoint;
        private System.Windows.Forms.Label labelDistanceKM;
        private System.Windows.Forms.Label labelEstimatedTimeHours;
        private System.Windows.Forms.Label labelRouteNotes;
        private System.Windows.Forms.TextBox textBoxStartPoint;
        private System.Windows.Forms.TextBox textBoxEndPoint;
        private System.Windows.Forms.TextBox textBoxDistanceKM;
        private System.Windows.Forms.TextBox textBoxEstimatedTimeHours;
        private System.Windows.Forms.TextBox textBoxRouteNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}