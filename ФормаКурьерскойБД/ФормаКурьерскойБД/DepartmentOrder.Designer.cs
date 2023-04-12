namespace ФормаКурьерскойБД
{
    partial class DepartmentOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заказыБезКурьеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курьерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderIDSearch = new System.Windows.Forms.TextBox();
            this.SearchOrderId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courierList = new System.Windows.Forms.ComboBox();
            this.AddCourier = new System.Windows.Forms.Button();
            this.SearchCourierEmail = new System.Windows.Forms.Button();
            this.CourierEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchOrderIdClent = new System.Windows.Forms.Button();
            this.SearchOrderClientId = new System.Windows.Forms.TextBox();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchClientEmail = new System.Windows.Forms.Button();
            this.ClientsEmail = new System.Windows.Forms.TextBox();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.отправленныеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(771, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыБезКурьеровToolStripMenuItem,
            this.курьерыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.отправленныеЗаказыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заказыБезКурьеровToolStripMenuItem
            // 
            this.заказыБезКурьеровToolStripMenuItem.Name = "заказыБезКурьеровToolStripMenuItem";
            this.заказыБезКурьеровToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.заказыБезКурьеровToolStripMenuItem.Text = "Заказы без курьеров";
            this.заказыБезКурьеровToolStripMenuItem.Click += new System.EventHandler(this.заказыБезКурьеровToolStripMenuItem_Click);
            // 
            // курьерыToolStripMenuItem
            // 
            this.курьерыToolStripMenuItem.Name = "курьерыToolStripMenuItem";
            this.курьерыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.курьерыToolStripMenuItem.Text = "Курьеры";
            this.курьерыToolStripMenuItem.Click += new System.EventHandler(this.курьерыToolStripMenuItem_Click);
            // 
            // OrderIDSearch
            // 
            this.OrderIDSearch.Location = new System.Drawing.Point(376, 431);
            this.OrderIDSearch.Name = "OrderIDSearch";
            this.OrderIDSearch.Size = new System.Drawing.Size(159, 20);
            this.OrderIDSearch.TabIndex = 2;
            // 
            // SearchOrderId
            // 
            this.SearchOrderId.Location = new System.Drawing.Point(541, 429);
            this.SearchOrderId.Name = "SearchOrderId";
            this.SearchOrderId.Size = new System.Drawing.Size(123, 23);
            this.SearchOrderId.TabIndex = 3;
            this.SearchOrderId.Text = "Найти";
            this.SearchOrderId.UseVisualStyleBackColor = true;
            this.SearchOrderId.Click += new System.EventHandler(this.SearchOrderId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Курьер";
            // 
            // courierList
            // 
            this.courierList.FormattingEnabled = true;
            this.courierList.Location = new System.Drawing.Point(9, 119);
            this.courierList.Name = "courierList";
            this.courierList.Size = new System.Drawing.Size(335, 21);
            this.courierList.TabIndex = 6;
            // 
            // AddCourier
            // 
            this.AddCourier.Location = new System.Drawing.Point(12, 167);
            this.AddCourier.Name = "AddCourier";
            this.AddCourier.Size = new System.Drawing.Size(165, 46);
            this.AddCourier.TabIndex = 11;
            this.AddCourier.Text = "Назначить курьера";
            this.AddCourier.UseVisualStyleBackColor = true;
            this.AddCourier.Click += new System.EventHandler(this.AddCourier_Click);
            // 
            // SearchCourierEmail
            // 
            this.SearchCourierEmail.Location = new System.Drawing.Point(541, 371);
            this.SearchCourierEmail.Name = "SearchCourierEmail";
            this.SearchCourierEmail.Size = new System.Drawing.Size(123, 23);
            this.SearchCourierEmail.TabIndex = 14;
            this.SearchCourierEmail.Text = "Найти";
            this.SearchCourierEmail.UseVisualStyleBackColor = true;
            this.SearchCourierEmail.Click += new System.EventHandler(this.SearchCourierEmail_Click);
            // 
            // CourierEmail
            // 
            this.CourierEmail.Location = new System.Drawing.Point(376, 373);
            this.CourierEmail.Name = "CourierEmail";
            this.CourierEmail.Size = new System.Drawing.Size(159, 20);
            this.CourierEmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Поиск курьера по Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Поиск заказа по id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Поиск заказов по id клиента";
            // 
            // SearchOrderIdClent
            // 
            this.SearchOrderIdClent.Location = new System.Drawing.Point(833, 429);
            this.SearchOrderIdClent.Name = "SearchOrderIdClent";
            this.SearchOrderIdClent.Size = new System.Drawing.Size(123, 23);
            this.SearchOrderIdClent.TabIndex = 18;
            this.SearchOrderIdClent.Text = "Найти";
            this.SearchOrderIdClent.UseVisualStyleBackColor = true;
            this.SearchOrderIdClent.Click += new System.EventHandler(this.SearchOrderIdClent_Click);
            // 
            // SearchOrderClientId
            // 
            this.SearchOrderClientId.Location = new System.Drawing.Point(668, 431);
            this.SearchOrderClientId.Name = "SearchOrderClientId";
            this.SearchOrderClientId.Size = new System.Drawing.Size(159, 20);
            this.SearchOrderClientId.TabIndex = 17;
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Поиск клиента по Email";
            // 
            // SearchClientEmail
            // 
            this.SearchClientEmail.Location = new System.Drawing.Point(833, 371);
            this.SearchClientEmail.Name = "SearchClientEmail";
            this.SearchClientEmail.Size = new System.Drawing.Size(123, 23);
            this.SearchClientEmail.TabIndex = 21;
            this.SearchClientEmail.Text = "Найти";
            this.SearchClientEmail.UseVisualStyleBackColor = true;
            this.SearchClientEmail.Click += new System.EventHandler(this.SearchClientEmail_Click);
            // 
            // ClientsEmail
            // 
            this.ClientsEmail.Location = new System.Drawing.Point(668, 373);
            this.ClientsEmail.Name = "ClientsEmail";
            this.ClientsEmail.Size = new System.Drawing.Size(159, 20);
            this.ClientsEmail.TabIndex = 20;
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(203, 167);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(141, 46);
            this.CancelOrder.TabIndex = 23;
            this.CancelOrder.Text = "Отменить заказ";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(9, 68);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(94, 20);
            this.OrderId.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Заказ";
            // 
            // отправленныеЗаказыToolStripMenuItem
            // 
            this.отправленныеЗаказыToolStripMenuItem.Name = "отправленныеЗаказыToolStripMenuItem";
            this.отправленныеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.отправленныеЗаказыToolStripMenuItem.Text = "Отправленные заказы";
            this.отправленныеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.отправленныеЗаказыToolStripMenuItem_Click);
            // 
            // DepartmentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 538);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchClientEmail);
            this.Controls.Add(this.ClientsEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchOrderIdClent);
            this.Controls.Add(this.SearchOrderClientId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchCourierEmail);
            this.Controls.Add(this.CourierEmail);
            this.Controls.Add(this.AddCourier);
            this.Controls.Add(this.courierList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchOrderId);
            this.Controls.Add(this.OrderIDSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DepartmentOrder";
            this.Text = "AboutOrderForm";
            this.Load += new System.EventHandler(this.DepartmentOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заказыБезКурьеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курьерыToolStripMenuItem;
        private System.Windows.Forms.TextBox OrderIDSearch;
        private System.Windows.Forms.Button SearchOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courierList;
        private System.Windows.Forms.Button AddCourier;
        private System.Windows.Forms.Button SearchCourierEmail;
        private System.Windows.Forms.TextBox CourierEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchOrderIdClent;
        private System.Windows.Forms.TextBox SearchOrderClientId;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchClientEmail;
        private System.Windows.Forms.TextBox ClientsEmail;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem отправленныеЗаказыToolStripMenuItem;
    }
}