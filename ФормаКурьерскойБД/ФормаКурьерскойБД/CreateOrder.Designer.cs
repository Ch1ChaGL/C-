namespace ФормаКурьерскойБД
{
    partial class CreateOrder
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
            this.from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateDistance = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baseCostTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.департаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базоваяСтоимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentReceiv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cargoType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.additionalService = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.addOrder = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailSearch = new System.Windows.Forms.Button();
            this.ClientSender = new System.Windows.Forms.TextBox();
            this.ClientReciev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Enabled = false;
            this.from.Location = new System.Drawing.Point(8, 66);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(229, 20);
            this.from.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Откуда";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(253, 66);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(228, 20);
            this.to.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Куда";
            // 
            // calculateDistance
            // 
            this.calculateDistance.Location = new System.Drawing.Point(8, 424);
            this.calculateDistance.Name = "calculateDistance";
            this.calculateDistance.Size = new System.Drawing.Size(156, 40);
            this.calculateDistance.TabIndex = 4;
            this.calculateDistance.Text = "Расчитать";
            this.calculateDistance.UseVisualStyleBackColor = true;
            this.calculateDistance.Click += new System.EventHandler(this.calculateDistance_Click);
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(9, 350);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(229, 20);
            this.distance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расстояние";
            // 
            // baseCostTextBox
            // 
            this.baseCostTextBox.Enabled = false;
            this.baseCostTextBox.Location = new System.Drawing.Point(10, 398);
            this.baseCostTextBox.Name = "baseCostTextBox";
            this.baseCostTextBox.Size = new System.Drawing.Size(230, 20);
            this.baseCostTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(573, 231);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Базовая стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дополнительные услуги";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.департаментыToolStripMenuItem,
            this.базоваяСтоимостьToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.клиентыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // департаментыToolStripMenuItem
            // 
            this.департаментыToolStripMenuItem.Name = "департаментыToolStripMenuItem";
            this.департаментыToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.департаментыToolStripMenuItem.Text = "Департаменты";
            this.департаментыToolStripMenuItem.Click += new System.EventHandler(this.департаментыToolStripMenuItem_Click);
            // 
            // базоваяСтоимостьToolStripMenuItem
            // 
            this.базоваяСтоимостьToolStripMenuItem.Name = "базоваяСтоимостьToolStripMenuItem";
            this.базоваяСтоимостьToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.базоваяСтоимостьToolStripMenuItem.Text = "Базовая стоимость";
            this.базоваяСтоимостьToolStripMenuItem.Click += new System.EventHandler(this.базоваяСтоимостьToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // departmentReceiv
            // 
            this.departmentReceiv.FormattingEnabled = true;
            this.departmentReceiv.Location = new System.Drawing.Point(12, 124);
            this.departmentReceiv.Name = "departmentReceiv";
            this.departmentReceiv.Size = new System.Drawing.Size(225, 21);
            this.departmentReceiv.TabIndex = 13;
            this.departmentReceiv.SelectedIndexChanged += new System.EventHandler(this.departmentReceiv_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Департамент получения";
            // 
            // cargoType
            // 
            this.cargoType.FormattingEnabled = true;
            this.cargoType.Location = new System.Drawing.Point(10, 177);
            this.cargoType.Name = "cargoType";
            this.cargoType.Size = new System.Drawing.Size(230, 21);
            this.cargoType.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Тип Груза";
            // 
            // additionalService
            // 
            this.additionalService.FormattingEnabled = true;
            this.additionalService.Location = new System.Drawing.Point(8, 231);
            this.additionalService.Name = "additionalService";
            this.additionalService.Size = new System.Drawing.Size(232, 79);
            this.additionalService.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Полная стоимость";
            // 
            // TotalCost
            // 
            this.TotalCost.Enabled = false;
            this.TotalCost.Location = new System.Drawing.Point(263, 398);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(230, 20);
            this.TotalCost.TabIndex = 18;
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(263, 424);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(228, 40);
            this.addOrder.TabIndex = 20;
            this.addOrder.Text = "Создать заказ";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(654, 353);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(185, 20);
            this.emailTB.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Поиск по Email";
            // 
            // EmailSearch
            // 
            this.EmailSearch.Location = new System.Drawing.Point(861, 353);
            this.EmailSearch.Name = "EmailSearch";
            this.EmailSearch.Size = new System.Drawing.Size(85, 20);
            this.EmailSearch.TabIndex = 23;
            this.EmailSearch.Text = "Найти";
            this.EmailSearch.UseVisualStyleBackColor = true;
            this.EmailSearch.Click += new System.EventHandler(this.EmailSearch_Click);
            // 
            // ClientSender
            // 
            this.ClientSender.Location = new System.Drawing.Point(256, 144);
            this.ClientSender.Name = "ClientSender";
            this.ClientSender.Size = new System.Drawing.Size(100, 20);
            this.ClientSender.TabIndex = 24;
            // 
            // ClientReciev
            // 
            this.ClientReciev.Location = new System.Drawing.Point(257, 196);
            this.ClientReciev.Name = "ClientReciev";
            this.ClientReciev.Size = new System.Drawing.Size(100, 20);
            this.ClientReciev.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Клиент получатель";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Клиент отправитель";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 539);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ClientReciev);
            this.Controls.Add(this.ClientSender);
            this.Controls.Add(this.EmailSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.additionalService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cargoType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departmentReceiv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.baseCostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.calculateDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateDistance;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox baseCostTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem департаментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базоваяСтоимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ComboBox departmentReceiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cargoType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox additionalService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EmailSearch;
        private System.Windows.Forms.TextBox ClientSender;
        private System.Windows.Forms.TextBox ClientReciev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}