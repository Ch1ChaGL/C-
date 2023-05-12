namespace _7_Задание_13Вариант
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
            this.label1 = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeGame = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.MemorySize = new System.Windows.Forms.TextBox();
            this.CPUsize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название игры";
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameName.Location = new System.Drawing.Point(182, 70);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(189, 29);
            this.gameName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Жанр игры";
            // 
            // TypeGame
            // 
            this.TypeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeGame.FormattingEnabled = true;
            this.TypeGame.Items.AddRange(new object[] {
            "RPG",
            "Shooter",
            "Simulator",
            "Strategy"});
            this.TypeGame.Location = new System.Drawing.Point(182, 118);
            this.TypeGame.Name = "TypeGame";
            this.TypeGame.Size = new System.Drawing.Size(189, 32);
            this.TypeGame.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Объем памяти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Частота процессора";
            // 
            // SaveFile
            // 
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFile.ForeColor = System.Drawing.Color.Maroon;
            this.SaveFile.Location = new System.Drawing.Point(95, 315);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(190, 93);
            this.SaveFile.TabIndex = 8;
            this.SaveFile.Text = "Записать в файл";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.View.ForeColor = System.Drawing.Color.Teal;
            this.View.Location = new System.Drawing.Point(499, 315);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(190, 93);
            this.View.TabIndex = 9;
            this.View.Text = "Просмотр данных";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // MemorySize
            // 
            this.MemorySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemorySize.Location = new System.Drawing.Point(271, 185);
            this.MemorySize.Name = "MemorySize";
            this.MemorySize.Size = new System.Drawing.Size(100, 29);
            this.MemorySize.TabIndex = 10;
            // 
            // CPUsize
            // 
            this.CPUsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUsize.Location = new System.Drawing.Point(271, 237);
            this.CPUsize.Name = "CPUsize";
            this.CPUsize.Size = new System.Drawing.Size(100, 29);
            this.CPUsize.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CPUsize);
            this.Controls.Add(this.MemorySize);
            this.Controls.Add(this.View);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Работа с бинарным файлом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button View;
        public System.Windows.Forms.TextBox gameName;
        public System.Windows.Forms.ComboBox TypeGame;
        public System.Windows.Forms.TextBox MemorySize;
        public System.Windows.Forms.TextBox CPUsize;
    }
}

