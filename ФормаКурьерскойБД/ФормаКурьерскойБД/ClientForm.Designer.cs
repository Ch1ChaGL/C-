namespace ФормаКурьерскойБД
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Services = new System.Windows.Forms.Button();
            this.BaseCost = new System.Windows.Forms.Button();
            this.CargoType = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.OrderInfo = new System.Windows.Forms.Button();
            this.idOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(357, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(677, 336);
            this.dataGridView.TabIndex = 0;
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(52, 59);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(170, 54);
            this.Services.TabIndex = 1;
            this.Services.Text = "Получить данные о услугах";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // BaseCost
            // 
            this.BaseCost.Location = new System.Drawing.Point(52, 147);
            this.BaseCost.Name = "BaseCost";
            this.BaseCost.Size = new System.Drawing.Size(170, 54);
            this.BaseCost.TabIndex = 2;
            this.BaseCost.Text = "Получить данные о тарифе";
            this.BaseCost.UseVisualStyleBackColor = true;
            this.BaseCost.Click += new System.EventHandler(this.BaseCost_Click);
            // 
            // CargoType
            // 
            this.CargoType.Location = new System.Drawing.Point(52, 243);
            this.CargoType.Name = "CargoType";
            this.CargoType.Size = new System.Drawing.Size(170, 57);
            this.CargoType.TabIndex = 3;
            this.CargoType.Text = "Получить данные о типах груза";
            this.CargoType.UseVisualStyleBackColor = true;
            this.CargoType.Click += new System.EventHandler(this.CargoType_Click);
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(53, 334);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(169, 61);
            this.Orders.TabIndex = 4;
            this.Orders.Text = "Получить данные заказа";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // OrderInfo
            // 
            this.OrderInfo.Location = new System.Drawing.Point(53, 416);
            this.OrderInfo.Name = "OrderInfo";
            this.OrderInfo.Size = new System.Drawing.Size(169, 67);
            this.OrderInfo.TabIndex = 5;
            this.OrderInfo.Text = "Получить полную информацию о заказе";
            this.OrderInfo.UseVisualStyleBackColor = true;
            this.OrderInfo.Click += new System.EventHandler(this.OrderInfo_Click);
            // 
            // idOrder
            // 
            this.idOrder.Location = new System.Drawing.Point(268, 440);
            this.idOrder.Name = "idOrder";
            this.idOrder.Size = new System.Drawing.Size(184, 20);
            this.idOrder.TabIndex = 6;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 530);
            this.Controls.Add(this.idOrder);
            this.Controls.Add(this.OrderInfo);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.CargoType);
            this.Controls.Add(this.BaseCost);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.dataGridView);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button BaseCost;
        private System.Windows.Forms.Button CargoType;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button OrderInfo;
        private System.Windows.Forms.TextBox idOrder;
    }
}