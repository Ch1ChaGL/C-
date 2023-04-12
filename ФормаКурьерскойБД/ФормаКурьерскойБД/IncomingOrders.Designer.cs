namespace ФормаКурьерскойБД
{
    partial class IncomingOrders
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
            this.idOrder = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Received = new System.Windows.Forms.Button();
            this.Delivered = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.поступающиеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(930, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // idOrder
            // 
            this.idOrder.Location = new System.Drawing.Point(27, 158);
            this.idOrder.Name = "idOrder";
            this.idOrder.Size = new System.Drawing.Size(241, 20);
            this.idOrder.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(27, 139);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(42, 13);
            this.ID.TabIndex = 4;
            this.ID.Text = "IdOrder";
            // 
            // Received
            // 
            this.Received.Location = new System.Drawing.Point(174, 221);
            this.Received.Name = "Received";
            this.Received.Size = new System.Drawing.Size(94, 23);
            this.Received.TabIndex = 5;
            this.Received.Text = "Получен";
            this.Received.UseVisualStyleBackColor = true;
            this.Received.Click += new System.EventHandler(this.Received_Click);
            // 
            // Delivered
            // 
            this.Delivered.Location = new System.Drawing.Point(27, 221);
            this.Delivered.Name = "Delivered";
            this.Delivered.Size = new System.Drawing.Size(94, 23);
            this.Delivered.TabIndex = 6;
            this.Delivered.Text = "Доставлен";
            this.Delivered.UseVisualStyleBackColor = true;
            this.Delivered.Click += new System.EventHandler(this.Delivered_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поступающиеЗаказыToolStripMenuItem,
            this.заказыНаСкладеToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1313, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // поступающиеЗаказыToolStripMenuItem
            // 
            this.поступающиеЗаказыToolStripMenuItem.Name = "поступающиеЗаказыToolStripMenuItem";
            this.поступающиеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.поступающиеЗаказыToolStripMenuItem.Text = "Поступающие заказы";
            this.поступающиеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.поступающиеЗаказыToolStripMenuItem_Click);
            // 
            // заказыНаСкладеToolStripMenuItem
            // 
            this.заказыНаСкладеToolStripMenuItem.Name = "заказыНаСкладеToolStripMenuItem";
            this.заказыНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.заказыНаСкладеToolStripMenuItem.Text = "Заказы на складе";
            this.заказыНаСкладеToolStripMenuItem.Click += new System.EventHandler(this.заказыНаСкладеToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            this.отчетыToolStripMenuItem.Click += new System.EventHandler(this.отчетыToolStripMenuItem_Click);
            // 
            // IncomingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 494);
            this.Controls.Add(this.Delivered);
            this.Controls.Add(this.Received);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.idOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IncomingOrders";
            this.Text = "IncomingOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox idOrder;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Received;
        private System.Windows.Forms.Button Delivered;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem поступающиеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
    }
}