namespace _7_Задание_16Вариант
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
            this.unitNum = new System.Windows.Forms.TextBox();
            this.diagnoz = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.vizitTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // unitNum
            // 
            this.unitNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitNum.Location = new System.Drawing.Point(191, 220);
            this.unitNum.Name = "unitNum";
            this.unitNum.Size = new System.Drawing.Size(100, 29);
            this.unitNum.TabIndex = 21;
            // 
            // diagnoz
            // 
            this.diagnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnoz.Location = new System.Drawing.Point(191, 167);
            this.diagnoz.Name = "diagnoz";
            this.diagnoz.Size = new System.Drawing.Size(200, 29);
            this.diagnoz.TabIndex = 20;
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.View.ForeColor = System.Drawing.Color.Teal;
            this.View.Location = new System.Drawing.Point(483, 315);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(190, 93);
            this.View.TabIndex = 19;
            this.View.Text = "Просмотр данных";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFile.ForeColor = System.Drawing.Color.Maroon;
            this.SaveFile.Location = new System.Drawing.Point(77, 315);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(190, 93);
            this.SaveFile.TabIndex = 18;
            this.SaveFile.Text = "Записать в файл";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Номер отделения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Диагноз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Год рождения";
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(164, 35);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(189, 29);
            this.fullName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(164, 87);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 20);
            this.birthday.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Дата поступления";
            // 
            // vizitTime
            // 
            this.vizitTime.Location = new System.Drawing.Point(191, 131);
            this.vizitTime.Name = "vizitTime";
            this.vizitTime.Size = new System.Drawing.Size(200, 20);
            this.vizitTime.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vizitTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.unitNum);
            this.Controls.Add(this.diagnoz);
            this.Controls.Add(this.View);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox unitNum;
        public System.Windows.Forms.TextBox diagnoz;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker vizitTime;
    }
}

