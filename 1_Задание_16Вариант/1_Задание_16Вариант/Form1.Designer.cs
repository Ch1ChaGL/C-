namespace _1_Задание_16Вариант
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
            this.CosLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.argumentX = new System.Windows.Forms.TextBox();
            this.accuracy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumRow = new System.Windows.Forms.Label();
            this.CountRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_1_Задание_16Вариант.Properties.Resources.Снимок_экрана_2023_05_25_233952;
            this.pictureBox1.Location = new System.Drawing.Point(51, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CosLb
            // 
            this.CosLb.AutoSize = true;
            this.CosLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosLb.Location = new System.Drawing.Point(54, 398);
            this.CosLb.Name = "CosLb";
            this.CosLb.Size = new System.Drawing.Size(0, 24);
            this.CosLb.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(49, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(286, 267);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(137, 49);
            this.calc.TabIndex = 12;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // argumentX
            // 
            this.argumentX.Location = new System.Drawing.Point(428, 217);
            this.argumentX.Name = "argumentX";
            this.argumentX.Size = new System.Drawing.Size(192, 20);
            this.argumentX.TabIndex = 11;
            this.argumentX.TextChanged += new System.EventHandler(this.accuracy_TextChanged);
            // 
            // accuracy
            // 
            this.accuracy.Location = new System.Drawing.Point(53, 217);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(232, 20);
            this.accuracy.TabIndex = 10;
            this.accuracy.TextChanged += new System.EventHandler(this.accuracy_TextChanged);
            this.accuracy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accuracy_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(424, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите аргумент X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите точность 0<e<1";
            // 
            // sumRow
            // 
            this.sumRow.AutoSize = true;
            this.sumRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumRow.Location = new System.Drawing.Point(54, 463);
            this.sumRow.Name = "sumRow";
            this.sumRow.Size = new System.Drawing.Size(0, 24);
            this.sumRow.TabIndex = 15;
            // 
            // CountRow
            // 
            this.CountRow.AutoSize = true;
            this.CountRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountRow.Location = new System.Drawing.Point(54, 524);
            this.CountRow.Name = "CountRow";
            this.CountRow.Size = new System.Drawing.Size(0, 24);
            this.CountRow.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 681);
            this.Controls.Add(this.CountRow);
            this.Controls.Add(this.sumRow);
            this.Controls.Add(this.CosLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.argumentX);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Вычисление функции с помощью разложения в ряд";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CosLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox argumentX;
        private System.Windows.Forms.TextBox accuracy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumRow;
        private System.Windows.Forms.Label CountRow;
    }
}

