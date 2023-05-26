namespace _7_Задание_16Вариант
{
    partial class Form2
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
            this.searchByFullName = new System.Windows.Forms.Button();
            this.byVizit = new System.Windows.Forms.RadioButton();
            this.byBirthday = new System.Windows.Forms.RadioButton();
            this.byUnitId = new System.Windows.Forms.RadioButton();
            this.byFullName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchByFullName
            // 
            this.searchByFullName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.searchByFullName.Location = new System.Drawing.Point(94, 86);
            this.searchByFullName.Name = "searchByFullName";
            this.searchByFullName.Size = new System.Drawing.Size(82, 32);
            this.searchByFullName.TabIndex = 38;
            this.searchByFullName.Text = "Найти";
            this.searchByFullName.UseVisualStyleBackColor = true;
            this.searchByFullName.Click += new System.EventHandler(this.searchByFullName_Click);
            // 
            // byVizit
            // 
            this.byVizit.AutoSize = true;
            this.byVizit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byVizit.Location = new System.Drawing.Point(5, 281);
            this.byVizit.Name = "byVizit";
            this.byVizit.Size = new System.Drawing.Size(202, 28);
            this.byVizit.TabIndex = 34;
            this.byVizit.TabStop = true;
            this.byVizit.Text = "по дате посещения";
            this.byVizit.UseVisualStyleBackColor = true;
            this.byVizit.CheckedChanged += new System.EventHandler(this.byFullName_CheckedChanged);
            // 
            // byBirthday
            // 
            this.byBirthday.AutoSize = true;
            this.byBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byBirthday.Location = new System.Drawing.Point(5, 247);
            this.byBirthday.Name = "byBirthday";
            this.byBirthday.Size = new System.Drawing.Size(188, 28);
            this.byBirthday.TabIndex = 33;
            this.byBirthday.TabStop = true;
            this.byBirthday.Text = "по дню рождения";
            this.byBirthday.UseVisualStyleBackColor = true;
            this.byBirthday.CheckedChanged += new System.EventHandler(this.byFullName_CheckedChanged);
            // 
            // byUnitId
            // 
            this.byUnitId.AutoSize = true;
            this.byUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byUnitId.Location = new System.Drawing.Point(5, 213);
            this.byUnitId.Name = "byUnitId";
            this.byUnitId.Size = new System.Drawing.Size(225, 28);
            this.byUnitId.TabIndex = 32;
            this.byUnitId.TabStop = true;
            this.byUnitId.Text = "По номеру отделения";
            this.byUnitId.UseVisualStyleBackColor = true;
            this.byUnitId.CheckedChanged += new System.EventHandler(this.byFullName_CheckedChanged);
            // 
            // byFullName
            // 
            this.byFullName.AutoSize = true;
            this.byFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byFullName.Location = new System.Drawing.Point(5, 179);
            this.byFullName.Name = "byFullName";
            this.byFullName.Size = new System.Drawing.Size(101, 28);
            this.byFullName.TabIndex = 31;
            this.byFullName.TabStop = true;
            this.byFullName.Text = "По ФИО";
            this.byFullName.UseVisualStyleBackColor = true;
            this.byFullName.CheckedChanged += new System.EventHandler(this.byFullName_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Сортировать по:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(13, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "ФИО";
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(13, 51);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(163, 29);
            this.fullName.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 354);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(826, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Найти по дню рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(867, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(867, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(826, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "От";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(826, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "До";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(830, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 32);
            this.button3.TabIndex = 48;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Location = new System.Drawing.Point(830, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 32);
            this.button4.TabIndex = 54;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(826, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "До";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(826, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 52;
            this.label8.Text = "От";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(867, 259);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 51;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(867, 295);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(826, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Найти по дате визита";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 537);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchByFullName);
            this.Controls.Add(this.byVizit);
            this.Controls.Add(this.byBirthday);
            this.Controls.Add(this.byUnitId);
            this.Controls.Add(this.byFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchByFullName;
        private System.Windows.Forms.RadioButton byVizit;
        private System.Windows.Forms.RadioButton byBirthday;
        private System.Windows.Forms.RadioButton byUnitId;
        private System.Windows.Forms.RadioButton byFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
    }
}