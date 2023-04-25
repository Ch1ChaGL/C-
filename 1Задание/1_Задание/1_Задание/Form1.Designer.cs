namespace _1_Задание
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
            this.formulaPBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accuracy = new System.Windows.Forms.TextBox();
            this.argumentX = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.arctgLb = new System.Windows.Forms.Label();
            this.rowSumLb = new System.Windows.Forms.Label();
            this.countRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formulaPBox
            // 
            this.formulaPBox.BackgroundImage = global::_1_Задание.Properties.Resources.Безымянный;
            this.formulaPBox.Location = new System.Drawing.Point(138, 85);
            this.formulaPBox.Name = "formulaPBox";
            this.formulaPBox.Size = new System.Drawing.Size(606, 75);
            this.formulaPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formulaPBox.TabIndex = 0;
            this.formulaPBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите точность 0<e<1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(509, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите аргумент X";
            // 
            // accuracy
            // 
            this.accuracy.Location = new System.Drawing.Point(138, 259);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(232, 20);
            this.accuracy.TabIndex = 3;
            this.accuracy.TextChanged += new System.EventHandler(this.accuracy_TextChanged);
            this.accuracy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accuracy_KeyPress);
            // 
            // argumentX
            // 
            this.argumentX.Location = new System.Drawing.Point(513, 259);
            this.argumentX.Name = "argumentX";
            this.argumentX.Size = new System.Drawing.Size(192, 20);
            this.argumentX.TabIndex = 4;
            this.argumentX.TextChanged += new System.EventHandler(this.accuracy_TextChanged);
            this.argumentX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accuracy_KeyPress);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(371, 309);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(137, 49);
            this.calc.TabIndex = 5;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(134, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            // 
            // arctgLb
            // 
            this.arctgLb.AutoSize = true;
            this.arctgLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arctgLb.Location = new System.Drawing.Point(139, 440);
            this.arctgLb.Name = "arctgLb";
            this.arctgLb.Size = new System.Drawing.Size(0, 24);
            this.arctgLb.TabIndex = 7;
            // 
            // rowSumLb
            // 
            this.rowSumLb.AutoSize = true;
            this.rowSumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowSumLb.Location = new System.Drawing.Point(139, 514);
            this.rowSumLb.Name = "rowSumLb";
            this.rowSumLb.Size = new System.Drawing.Size(0, 24);
            this.rowSumLb.TabIndex = 8;
            // 
            // countRow
            // 
            this.countRow.AutoSize = true;
            this.countRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countRow.Location = new System.Drawing.Point(139, 586);
            this.countRow.Name = "countRow";
            this.countRow.Size = new System.Drawing.Size(0, 24);
            this.countRow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 661);
            this.Controls.Add(this.countRow);
            this.Controls.Add(this.rowSumLb);
            this.Controls.Add(this.arctgLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.argumentX);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formulaPBox);
            this.Name = "Form1";
            this.Text = "CalculateArctg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formulaPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formulaPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accuracy;
        private System.Windows.Forms.TextBox argumentX;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label arctgLb;
        private System.Windows.Forms.Label rowSumLb;
        private System.Windows.Forms.Label countRow;
    }
}

