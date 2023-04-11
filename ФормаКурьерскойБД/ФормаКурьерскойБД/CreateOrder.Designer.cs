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
            this.departmentReceiv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cargoType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.additionalService = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Enabled = false;
            this.from.Location = new System.Drawing.Point(12, 86);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(229, 20);
            this.from.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Откуда";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(257, 86);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(228, 20);
            this.to.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Куда";
            // 
            // calculateDistance
            // 
            this.calculateDistance.Location = new System.Drawing.Point(15, 484);
            this.calculateDistance.Name = "calculateDistance";
            this.calculateDistance.Size = new System.Drawing.Size(138, 23);
            this.calculateDistance.TabIndex = 4;
            this.calculateDistance.Text = "Расчитать расстояние";
            this.calculateDistance.UseVisualStyleBackColor = true;
            this.calculateDistance.Click += new System.EventHandler(this.calculateDistance_Click);
            // 
            // distance
            // 
            this.distance.Enabled = false;
            this.distance.Location = new System.Drawing.Point(13, 370);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(229, 20);
            this.distance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расстояние";
            // 
            // baseCostTextBox
            // 
            this.baseCostTextBox.Enabled = false;
            this.baseCostTextBox.Location = new System.Drawing.Point(14, 418);
            this.baseCostTextBox.Name = "baseCostTextBox";
            this.baseCostTextBox.Size = new System.Drawing.Size(230, 20);
            this.baseCostTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 231);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Базовая стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 235);
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
            this.услугиToolStripMenuItem});
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
            // 
            // базоваяСтоимостьToolStripMenuItem
            // 
            this.базоваяСтоимостьToolStripMenuItem.Name = "базоваяСтоимостьToolStripMenuItem";
            this.базоваяСтоимостьToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.базоваяСтоимостьToolStripMenuItem.Text = "Базовая стоимость";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // departmentReceiv
            // 
            this.departmentReceiv.FormattingEnabled = true;
            this.departmentReceiv.Location = new System.Drawing.Point(16, 144);
            this.departmentReceiv.Name = "departmentReceiv";
            this.departmentReceiv.Size = new System.Drawing.Size(304, 21);
            this.departmentReceiv.TabIndex = 13;
            this.departmentReceiv.SelectedIndexChanged += new System.EventHandler(this.departmentReceiv_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Департамент получения";
            // 
            // cargoType
            // 
            this.cargoType.FormattingEnabled = true;
            this.cargoType.Location = new System.Drawing.Point(14, 197);
            this.cargoType.Name = "cargoType";
            this.cargoType.Size = new System.Drawing.Size(306, 21);
            this.cargoType.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Тип Груза";
            // 
            // additionalService
            // 
            this.additionalService.FormattingEnabled = true;
            this.additionalService.Location = new System.Drawing.Point(12, 251);
            this.additionalService.Name = "additionalService";
            this.additionalService.Size = new System.Drawing.Size(232, 79);
            this.additionalService.TabIndex = 17;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 539);
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
    }
}