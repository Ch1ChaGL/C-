namespace _3_Задание_16Вариант
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
            this.triangle2 = new System.Windows.Forms.PictureBox();
            this.triangle1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.directionT1 = new System.Windows.Forms.ComboBox();
            this.moveT1 = new System.Windows.Forms.Button();
            this.distanceT1 = new System.Windows.Forms.TextBox();
            this.createT1 = new System.Windows.Forms.Button();
            this.tCY = new System.Windows.Forms.TextBox();
            this.tCX = new System.Windows.Forms.TextBox();
            this.tBY = new System.Windows.Forms.TextBox();
            this.tBX = new System.Windows.Forms.TextBox();
            this.tAY = new System.Windows.Forms.TextBox();
            this.tAX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.directionT2 = new System.Windows.Forms.ComboBox();
            this.moveT2 = new System.Windows.Forms.Button();
            this.distanceT2 = new System.Windows.Forms.TextBox();
            this.createT2 = new System.Windows.Forms.Button();
            this.t2CY = new System.Windows.Forms.TextBox();
            this.t2CX = new System.Windows.Forms.TextBox();
            this.t2BY = new System.Windows.Forms.TextBox();
            this.t2BX = new System.Windows.Forms.TextBox();
            this.t2AY = new System.Windows.Forms.TextBox();
            this.t2AX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compare = new System.Windows.Forms.Button();
            this.ShowStringT1 = new System.Windows.Forms.Button();
            this.ShowStringT2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.triangle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // triangle2
            // 
            this.triangle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangle2.Location = new System.Drawing.Point(12, 360);
            this.triangle2.Name = "triangle2";
            this.triangle2.Size = new System.Drawing.Size(246, 250);
            this.triangle2.TabIndex = 0;
            this.triangle2.TabStop = false;
            // 
            // triangle1
            // 
            this.triangle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangle1.Location = new System.Drawing.Point(12, 61);
            this.triangle1.Name = "triangle1";
            this.triangle1.Size = new System.Drawing.Size(246, 254);
            this.triangle1.TabIndex = 1;
            this.triangle1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Треугольник 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Треугольник 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.directionT1);
            this.groupBox1.Controls.Add(this.moveT1);
            this.groupBox1.Controls.Add(this.distanceT1);
            this.groupBox1.Controls.Add(this.createT1);
            this.groupBox1.Controls.Add(this.tCY);
            this.groupBox1.Controls.Add(this.tCX);
            this.groupBox1.Controls.Add(this.tBY);
            this.groupBox1.Controls.Add(this.tBX);
            this.groupBox1.Controls.Add(this.tAY);
            this.groupBox1.Controls.Add(this.tAX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(560, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 254);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Треугольник 1";
            // 
            // directionT1
            // 
            this.directionT1.FormattingEnabled = true;
            this.directionT1.Items.AddRange(new object[] {
            "Вертикаль",
            "Горизонталь"});
            this.directionT1.Location = new System.Drawing.Point(190, 60);
            this.directionT1.Name = "directionT1";
            this.directionT1.Size = new System.Drawing.Size(121, 21);
            this.directionT1.TabIndex = 14;
            this.directionT1.TextChanged += new System.EventHandler(this.directionT1_TextChanged);
            // 
            // moveT1
            // 
            this.moveT1.Enabled = false;
            this.moveT1.Location = new System.Drawing.Point(236, 144);
            this.moveT1.Name = "moveT1";
            this.moveT1.Size = new System.Drawing.Size(75, 31);
            this.moveT1.TabIndex = 13;
            this.moveT1.Text = "Сдвинуть";
            this.moveT1.UseVisualStyleBackColor = true;
            this.moveT1.Click += new System.EventHandler(this.moveT1_Click);
            // 
            // distanceT1
            // 
            this.distanceT1.Location = new System.Drawing.Point(226, 108);
            this.distanceT1.Name = "distanceT1";
            this.distanceT1.Size = new System.Drawing.Size(85, 20);
            this.distanceT1.TabIndex = 12;
            this.distanceT1.TextChanged += new System.EventHandler(this.directionT1_TextChanged);
            // 
            // createT1
            // 
            this.createT1.Enabled = false;
            this.createT1.Location = new System.Drawing.Point(140, 206);
            this.createT1.Name = "createT1";
            this.createT1.Size = new System.Drawing.Size(75, 31);
            this.createT1.TabIndex = 9;
            this.createT1.Text = "Создать";
            this.createT1.UseVisualStyleBackColor = true;
            this.createT1.Click += new System.EventHandler(this.createT1_Click);
            // 
            // tCY
            // 
            this.tCY.Location = new System.Drawing.Point(102, 155);
            this.tCY.Name = "tCY";
            this.tCY.Size = new System.Drawing.Size(30, 20);
            this.tCY.TabIndex = 8;
            this.tCY.TextChanged += new System.EventHandler(this.tAX_TextChanged);
            // 
            // tCX
            // 
            this.tCX.Location = new System.Drawing.Point(57, 155);
            this.tCX.Name = "tCX";
            this.tCX.Size = new System.Drawing.Size(30, 20);
            this.tCX.TabIndex = 7;
            this.tCX.TextChanged += new System.EventHandler(this.tAX_TextChanged);
            // 
            // tBY
            // 
            this.tBY.Location = new System.Drawing.Point(102, 108);
            this.tBY.Name = "tBY";
            this.tBY.Size = new System.Drawing.Size(30, 20);
            this.tBY.TabIndex = 6;
            this.tBY.TextChanged += new System.EventHandler(this.tAX_TextChanged);
            // 
            // tBX
            // 
            this.tBX.Location = new System.Drawing.Point(57, 108);
            this.tBX.Name = "tBX";
            this.tBX.Size = new System.Drawing.Size(30, 20);
            this.tBX.TabIndex = 5;
            this.tBX.TextChanged += new System.EventHandler(this.tAX_TextChanged);
            // 
            // tAY
            // 
            this.tAY.Location = new System.Drawing.Point(102, 60);
            this.tAY.Name = "tAY";
            this.tAY.Size = new System.Drawing.Size(30, 20);
            this.tAY.TabIndex = 4;
            this.tAY.TextChanged += new System.EventHandler(this.tAX_TextChanged);
            // 
            // tAX
            // 
            this.tAX.Location = new System.Drawing.Point(57, 60);
            this.tAX.Name = "tAX";
            this.tAX.Size = new System.Drawing.Size(30, 20);
            this.tAX.TabIndex = 3;
            this.tAX.TextChanged += new System.EventHandler(this.tAX_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.directionT2);
            this.groupBox2.Controls.Add(this.moveT2);
            this.groupBox2.Controls.Add(this.distanceT2);
            this.groupBox2.Controls.Add(this.createT2);
            this.groupBox2.Controls.Add(this.t2CY);
            this.groupBox2.Controls.Add(this.t2CX);
            this.groupBox2.Controls.Add(this.t2BY);
            this.groupBox2.Controls.Add(this.t2BX);
            this.groupBox2.Controls.Add(this.t2AY);
            this.groupBox2.Controls.Add(this.t2AX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(560, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 250);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Треугольник 2";
            // 
            // directionT2
            // 
            this.directionT2.FormattingEnabled = true;
            this.directionT2.Items.AddRange(new object[] {
            "Вертикаль",
            "Горизонталь"});
            this.directionT2.Location = new System.Drawing.Point(203, 59);
            this.directionT2.Name = "directionT2";
            this.directionT2.Size = new System.Drawing.Size(121, 21);
            this.directionT2.TabIndex = 15;
            this.directionT2.TextChanged += new System.EventHandler(this.distanceT2_TextChanged);
            // 
            // moveT2
            // 
            this.moveT2.Enabled = false;
            this.moveT2.Location = new System.Drawing.Point(249, 148);
            this.moveT2.Name = "moveT2";
            this.moveT2.Size = new System.Drawing.Size(75, 31);
            this.moveT2.TabIndex = 14;
            this.moveT2.Text = "Сдвинуть";
            this.moveT2.UseVisualStyleBackColor = true;
            this.moveT2.Click += new System.EventHandler(this.moveT2_Click);
            // 
            // distanceT2
            // 
            this.distanceT2.Location = new System.Drawing.Point(239, 104);
            this.distanceT2.Name = "distanceT2";
            this.distanceT2.Size = new System.Drawing.Size(85, 20);
            this.distanceT2.TabIndex = 15;
            this.distanceT2.TextChanged += new System.EventHandler(this.distanceT2_TextChanged);
            // 
            // createT2
            // 
            this.createT2.Enabled = false;
            this.createT2.Location = new System.Drawing.Point(140, 203);
            this.createT2.Name = "createT2";
            this.createT2.Size = new System.Drawing.Size(75, 31);
            this.createT2.TabIndex = 10;
            this.createT2.Text = "Создать";
            this.createT2.UseVisualStyleBackColor = true;
            this.createT2.Click += new System.EventHandler(this.createT2_Click);
            // 
            // t2CY
            // 
            this.t2CY.Location = new System.Drawing.Point(102, 160);
            this.t2CY.Name = "t2CY";
            this.t2CY.Size = new System.Drawing.Size(30, 20);
            this.t2CY.TabIndex = 14;
            this.t2CY.TextChanged += new System.EventHandler(this.t2AX_TextChanged);
            // 
            // t2CX
            // 
            this.t2CX.Location = new System.Drawing.Point(57, 159);
            this.t2CX.Name = "t2CX";
            this.t2CX.Size = new System.Drawing.Size(30, 20);
            this.t2CX.TabIndex = 13;
            this.t2CX.TextChanged += new System.EventHandler(this.t2AX_TextChanged);
            // 
            // t2BY
            // 
            this.t2BY.Location = new System.Drawing.Point(102, 108);
            this.t2BY.Name = "t2BY";
            this.t2BY.Size = new System.Drawing.Size(30, 20);
            this.t2BY.TabIndex = 12;
            this.t2BY.TextChanged += new System.EventHandler(this.t2AX_TextChanged);
            // 
            // t2BX
            // 
            this.t2BX.Location = new System.Drawing.Point(57, 108);
            this.t2BX.Name = "t2BX";
            this.t2BX.Size = new System.Drawing.Size(30, 20);
            this.t2BX.TabIndex = 11;
            this.t2BX.TextChanged += new System.EventHandler(this.t2AX_TextChanged);
            // 
            // t2AY
            // 
            this.t2AY.Location = new System.Drawing.Point(102, 59);
            this.t2AY.Name = "t2AY";
            this.t2AY.Size = new System.Drawing.Size(30, 20);
            this.t2AY.TabIndex = 10;
            this.t2AY.TextChanged += new System.EventHandler(this.t2AX_TextChanged);
            // 
            // t2AX
            // 
            this.t2AX.Location = new System.Drawing.Point(57, 59);
            this.t2AX.Name = "t2AX";
            this.t2AX.Size = new System.Drawing.Size(30, 20);
            this.t2AX.TabIndex = 9;
            this.t2AX.TextChanged += new System.EventHandler(this.t2AX_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "A";
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(281, 247);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(172, 51);
            this.compare.TabIndex = 8;
            this.compare.Text = "Сравнить";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // ShowStringT1
            // 
            this.ShowStringT1.Location = new System.Drawing.Point(472, 61);
            this.ShowStringT1.Name = "ShowStringT1";
            this.ShowStringT1.Size = new System.Drawing.Size(82, 41);
            this.ShowStringT1.TabIndex = 9;
            this.ShowStringT1.Text = "Показать строку";
            this.ShowStringT1.UseVisualStyleBackColor = true;
            this.ShowStringT1.Click += new System.EventHandler(this.ShowStringT1_Click);
            // 
            // ShowStringT2
            // 
            this.ShowStringT2.Location = new System.Drawing.Point(472, 360);
            this.ShowStringT2.Name = "ShowStringT2";
            this.ShowStringT2.Size = new System.Drawing.Size(82, 41);
            this.ShowStringT2.TabIndex = 10;
            this.ShowStringT2.Text = "Показать строку";
            this.ShowStringT2.UseVisualStyleBackColor = true;
            this.ShowStringT2.Click += new System.EventHandler(this.ShowStringT2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Площадь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Площадь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 642);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowStringT2);
            this.Controls.Add(this.ShowStringT1);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.triangle1);
            this.Controls.Add(this.triangle2);
            this.Name = "Form1";
            this.Text = "Треугольник";
            ((System.ComponentModel.ISupportInitialize)(this.triangle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox triangle2;
        private System.Windows.Forms.PictureBox triangle1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox directionT1;
        private System.Windows.Forms.Button moveT1;
        private System.Windows.Forms.TextBox distanceT1;
        private System.Windows.Forms.Button createT1;
        private System.Windows.Forms.TextBox tCY;
        private System.Windows.Forms.TextBox tCX;
        private System.Windows.Forms.TextBox tBY;
        private System.Windows.Forms.TextBox tBX;
        private System.Windows.Forms.TextBox tAY;
        private System.Windows.Forms.TextBox tAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox directionT2;
        private System.Windows.Forms.Button moveT2;
        private System.Windows.Forms.TextBox distanceT2;
        private System.Windows.Forms.Button createT2;
        private System.Windows.Forms.TextBox t2CY;
        private System.Windows.Forms.TextBox t2CX;
        private System.Windows.Forms.TextBox t2BY;
        private System.Windows.Forms.TextBox t2BX;
        private System.Windows.Forms.TextBox t2AY;
        private System.Windows.Forms.TextBox t2AX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button ShowStringT1;
        private System.Windows.Forms.Button ShowStringT2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

