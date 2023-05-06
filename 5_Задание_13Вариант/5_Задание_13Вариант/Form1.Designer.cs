namespace _5_Задание_13Вариант
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteSity = new System.Windows.Forms.Button();
            this.deleteDistrict = new System.Windows.Forms.Button();
            this.addInformation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.areaTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countPeopleTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.districtName = new System.Windows.Forms.ComboBox();
            this.cityName = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Unload = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.cityTableComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cityDiagramComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 448);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteSity);
            this.tabPage1.Controls.Add(this.deleteDistrict);
            this.tabPage1.Controls.Add(this.addInformation);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.areaTxb);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.countPeopleTbx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.districtName);
            this.tabPage1.Controls.Add(this.cityName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввод Данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteSity
            // 
            this.deleteSity.Location = new System.Drawing.Point(30, 339);
            this.deleteSity.Name = "deleteSity";
            this.deleteSity.Size = new System.Drawing.Size(185, 51);
            this.deleteSity.TabIndex = 14;
            this.deleteSity.Text = "Удалить город";
            this.deleteSity.UseVisualStyleBackColor = true;
            this.deleteSity.Click += new System.EventHandler(this.deleteSity_Click);
            // 
            // deleteDistrict
            // 
            this.deleteDistrict.Location = new System.Drawing.Point(307, 339);
            this.deleteDistrict.Name = "deleteDistrict";
            this.deleteDistrict.Size = new System.Drawing.Size(185, 51);
            this.deleteDistrict.TabIndex = 13;
            this.deleteDistrict.Text = "Удалить район";
            this.deleteDistrict.UseVisualStyleBackColor = true;
            this.deleteDistrict.Click += new System.EventHandler(this.deleteDistrict_Click);
            // 
            // addInformation
            // 
            this.addInformation.Location = new System.Drawing.Point(579, 339);
            this.addInformation.Name = "addInformation";
            this.addInformation.Size = new System.Drawing.Size(185, 51);
            this.addInformation.TabIndex = 12;
            this.addInformation.Text = "Добавить данные о районе";
            this.addInformation.UseVisualStyleBackColor = true;
            this.addInformation.Click += new System.EventHandler(this.addInformation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Площадь района в кв.Км:";
            // 
            // areaTxb
            // 
            this.areaTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaTxb.Location = new System.Drawing.Point(242, 166);
            this.areaTxb.Name = "areaTxb";
            this.areaTxb.Size = new System.Drawing.Size(263, 29);
            this.areaTxb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество человек:";
            // 
            // countPeopleTbx
            // 
            this.countPeopleTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPeopleTbx.Location = new System.Drawing.Point(242, 112);
            this.countPeopleTbx.Name = "countPeopleTbx";
            this.countPeopleTbx.Size = new System.Drawing.Size(263, 29);
            this.countPeopleTbx.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(415, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите район или добавьте новый:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите город или введите новый:";
            // 
            // districtName
            // 
            this.districtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtName.FormattingEnabled = true;
            this.districtName.Location = new System.Drawing.Point(419, 50);
            this.districtName.Name = "districtName";
            this.districtName.Size = new System.Drawing.Size(345, 32);
            this.districtName.TabIndex = 5;
            this.districtName.SelectedIndexChanged += new System.EventHandler(this.districtName_SelectedIndexChanged);
            this.districtName.TextChanged += new System.EventHandler(this.districtName_TextChanged);
            // 
            // cityName
            // 
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityName.FormattingEnabled = true;
            this.cityName.Location = new System.Drawing.Point(10, 50);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(338, 32);
            this.cityName.TabIndex = 4;
            this.cityName.SelectedIndexChanged += new System.EventHandler(this.cityName_SelectedIndexChanged);
            this.cityName.TextChanged += new System.EventHandler(this.cityName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Unload);
            this.tabPage2.Controls.Add(this.Download);
            this.tabPage2.Controls.Add(this.cityTableComboBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Unload
            // 
            this.Unload.Location = new System.Drawing.Point(631, 148);
            this.Unload.Name = "Unload";
            this.Unload.Size = new System.Drawing.Size(152, 59);
            this.Unload.TabIndex = 4;
            this.Unload.Text = "Выгрузить в файл";
            this.Unload.UseVisualStyleBackColor = true;
            this.Unload.Click += new System.EventHandler(this.Unload_Click);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(631, 71);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(152, 56);
            this.Download.TabIndex = 3;
            this.Download.Text = "Загрузить из файла";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // cityTableComboBox
            // 
            this.cityTableComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTableComboBox.FormattingEnabled = true;
            this.cityTableComboBox.Location = new System.Drawing.Point(189, 33);
            this.cityTableComboBox.Name = "cityTableComboBox";
            this.cityTableComboBox.Size = new System.Drawing.Size(432, 32);
            this.cityTableComboBox.TabIndex = 2;
            this.cityTableComboBox.SelectedIndexChanged += new System.EventHandler(this.cityTableComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Выберите город:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(602, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cityDiagramComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Диаграмма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cityDiagramComboBox
            // 
            this.cityDiagramComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityDiagramComboBox.FormattingEnabled = true;
            this.cityDiagramComboBox.Location = new System.Drawing.Point(168, 6);
            this.cityDiagramComboBox.Name = "cityDiagramComboBox";
            this.cityDiagramComboBox.Size = new System.Drawing.Size(298, 32);
            this.cityDiagramComboBox.TabIndex = 0;
            this.cityDiagramComboBox.SelectedIndexChanged += new System.EventHandler(this.cityDiagramComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выберите город";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(77, 44);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(644, 375);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox districtName;
        private System.Windows.Forms.ComboBox cityName;
        private System.Windows.Forms.Button deleteSity;
        private System.Windows.Forms.Button deleteDistrict;
        private System.Windows.Forms.Button addInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox areaTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countPeopleTbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cityTableComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Unload;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityDiagramComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

