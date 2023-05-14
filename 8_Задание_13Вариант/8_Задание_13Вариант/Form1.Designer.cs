namespace _8_Задание_13Вариант
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.raceNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.airport = new System.Windows.Forms.ComboBox();
            this.airplaneNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.newTypeAirplane = new System.Windows.Forms.Button();
            this.newTypeFlightFrequency = new System.Windows.Forms.Button();
            this.timeEnd = new System.Windows.Forms.MaskedTextBox();
            this.timeStart = new System.Windows.Forms.MaskedTextBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.periodicity = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.airplaneType = new System.Windows.Forms.ComboBox();
            this.countPasanger = new System.Windows.Forms.TextBox();
            this.raceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // raceNumber2
            // 
            this.raceNumber2.Enabled = false;
            this.raceNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceNumber2.Location = new System.Drawing.Point(16, 283);
            this.raceNumber2.Name = "raceNumber2";
            this.raceNumber2.Size = new System.Drawing.Size(100, 29);
            this.raceNumber2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер рейса";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.airport);
            this.groupBox1.Controls.Add(this.airplaneNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.newTypeAirplane);
            this.groupBox1.Controls.Add(this.newTypeFlightFrequency);
            this.groupBox1.Controls.Add(this.timeEnd);
            this.groupBox1.Controls.Add(this.timeStart);
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.periodicity);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.airplaneType);
            this.groupBox1.Controls.Add(this.countPasanger);
            this.groupBox1.Controls.Add(this.raceNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(348, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // airport
            // 
            this.airport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airport.FormattingEnabled = true;
            this.airport.Location = new System.Drawing.Point(134, 173);
            this.airport.Name = "airport";
            this.airport.Size = new System.Drawing.Size(298, 24);
            this.airport.TabIndex = 28;
            // 
            // airplaneNumber
            // 
            this.airplaneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airplaneNumber.Location = new System.Drawing.Point(128, 69);
            this.airplaneNumber.Name = "airplaneNumber";
            this.airplaneNumber.Size = new System.Drawing.Size(304, 22);
            this.airplaneNumber.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Номер самолета";
            // 
            // newTypeAirplane
            // 
            this.newTypeAirplane.Location = new System.Drawing.Point(438, 95);
            this.newTypeAirplane.Name = "newTypeAirplane";
            this.newTypeAirplane.Size = new System.Drawing.Size(75, 23);
            this.newTypeAirplane.TabIndex = 25;
            this.newTypeAirplane.Text = "Новый";
            this.newTypeAirplane.UseVisualStyleBackColor = true;
            // 
            // newTypeFlightFrequency
            // 
            this.newTypeFlightFrequency.Location = new System.Drawing.Point(439, 344);
            this.newTypeFlightFrequency.Name = "newTypeFlightFrequency";
            this.newTypeFlightFrequency.Size = new System.Drawing.Size(75, 23);
            this.newTypeFlightFrequency.TabIndex = 24;
            this.newTypeFlightFrequency.Text = "Новый";
            this.newTypeFlightFrequency.UseVisualStyleBackColor = true;
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(118, 309);
            this.timeEnd.Mask = "00:00";
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(100, 20);
            this.timeEnd.TabIndex = 23;
            // 
            // timeStart
            // 
            this.timeStart.Location = new System.Drawing.Point(111, 243);
            this.timeStart.Mask = "00:00";
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(100, 20);
            this.timeStart.TabIndex = 20;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(118, 278);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(314, 20);
            this.dateEnd.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Дата прилета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Дата вылета";
            // 
            // periodicity
            // 
            this.periodicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodicity.FormattingEnabled = true;
            this.periodicity.Location = new System.Drawing.Point(185, 344);
            this.periodicity.Name = "periodicity";
            this.periodicity.Size = new System.Drawing.Size(247, 24);
            this.periodicity.TabIndex = 18;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(111, 215);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(321, 20);
            this.dateStart.TabIndex = 19;
            // 
            // airplaneType
            // 
            this.airplaneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airplaneType.FormattingEnabled = true;
            this.airplaneType.Location = new System.Drawing.Point(118, 96);
            this.airplaneType.Name = "airplaneType";
            this.airplaneType.Size = new System.Drawing.Size(314, 24);
            this.airplaneType.TabIndex = 17;
            // 
            // countPasanger
            // 
            this.countPasanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPasanger.Location = new System.Drawing.Point(225, 131);
            this.countPasanger.Name = "countPasanger";
            this.countPasanger.Size = new System.Drawing.Size(207, 22);
            this.countPasanger.TabIndex = 13;
            // 
            // raceNumber
            // 
            this.raceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceNumber.Location = new System.Drawing.Point(118, 25);
            this.raceNumber.Name = "raceNumber";
            this.raceNumber.Size = new System.Drawing.Size(314, 22);
            this.raceNumber.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Периодичность рейса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Время прилета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Время вылета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Порт назначения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество пассажирских мест";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип самолета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер рейса";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.ForestGreen;
            this.add.Location = new System.Drawing.Point(875, 23);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 35);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change.ForeColor = System.Drawing.Color.DarkBlue;
            this.change.Location = new System.Drawing.Point(875, 70);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(104, 37);
            this.change.TabIndex = 6;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(875, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(875, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(875, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сборс";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 314);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 738);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceNumber2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "База данных Аэропорта";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox raceNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox periodicity;
        private System.Windows.Forms.ComboBox airplaneType;
        private System.Windows.Forms.TextBox countPasanger;
        private System.Windows.Forms.TextBox raceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.MaskedTextBox timeStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox timeEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newTypeAirplane;
        private System.Windows.Forms.Button newTypeFlightFrequency;
        private System.Windows.Forms.TextBox airplaneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox airport;
    }
}

