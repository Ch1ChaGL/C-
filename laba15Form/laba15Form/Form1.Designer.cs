namespace laba15Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.M1option4 = new System.Windows.Forms.RadioButton();
            this.M1option3 = new System.Windows.Forms.RadioButton();
            this.M1option2 = new System.Windows.Forms.RadioButton();
            this.M1option1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.M2option4 = new System.Windows.Forms.RadioButton();
            this.M2option3 = new System.Windows.Forms.RadioButton();
            this.M2option2 = new System.Windows.Forms.RadioButton();
            this.M2option1 = new System.Windows.Forms.RadioButton();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.MassM1 = new System.Windows.Forms.DataGridView();
            this.M1N1 = new System.Windows.Forms.TextBox();
            this.M1N2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusM1 = new System.Windows.Forms.Button();
            this.minusM1 = new System.Windows.Forms.Button();
            this.plusYM1 = new System.Windows.Forms.Button();
            this.minusYM1 = new System.Windows.Forms.Button();
            this.YM1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelM1 = new System.Windows.Forms.Label();
            this.labelM2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YM2 = new System.Windows.Forms.TextBox();
            this.minusYM2 = new System.Windows.Forms.Button();
            this.plusYM2 = new System.Windows.Forms.Button();
            this.minusM2 = new System.Windows.Forms.Button();
            this.plusM2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.M2N2 = new System.Windows.Forms.TextBox();
            this.M2N1 = new System.Windows.Forms.TextBox();
            this.MassM2 = new System.Windows.Forms.DataGridView();
            this.sum = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.ZM1 = new System.Windows.Forms.Button();
            this.AM1 = new System.Windows.Forms.Label();
            this.AM2 = new System.Windows.Forms.Label();
            this.ZM2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.M1option4);
            this.groupBox1.Controls.Add(this.M1option3);
            this.groupBox1.Controls.Add(this.M1option2);
            this.groupBox1.Controls.Add(this.M1option1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод массива 1:";
            // 
            // M1option4
            // 
            this.M1option4.AutoSize = true;
            this.M1option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M1option4.Location = new System.Drawing.Point(17, 155);
            this.M1option4.Name = "M1option4";
            this.M1option4.Size = new System.Drawing.Size(87, 20);
            this.M1option4.TabIndex = 3;
            this.M1option4.Text = "из файла";
            this.M1option4.UseVisualStyleBackColor = true;
            this.M1option4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // M1option3
            // 
            this.M1option3.AutoSize = true;
            this.M1option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M1option3.Location = new System.Drawing.Point(17, 121);
            this.M1option3.Name = "M1option3";
            this.M1option3.Size = new System.Drawing.Size(252, 20);
            this.M1option3.TabIndex = 2;
            this.M1option3.TabStop = true;
            this.M1option3.Text = "Случайно в интервале от N1 до N2";
            this.M1option3.UseVisualStyleBackColor = true;
            this.M1option3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // M1option2
            // 
            this.M1option2.AutoSize = true;
            this.M1option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M1option2.Location = new System.Drawing.Point(17, 87);
            this.M1option2.Name = "M1option2";
            this.M1option2.Size = new System.Drawing.Size(242, 20);
            this.M1option2.TabIndex = 1;
            this.M1option2.Text = "Случайно в интервале от 0 до N1";
            this.M1option2.UseVisualStyleBackColor = true;
            this.M1option2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // M1option1
            // 
            this.M1option1.AutoSize = true;
            this.M1option1.Checked = true;
            this.M1option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M1option1.Location = new System.Drawing.Point(17, 53);
            this.M1option1.Name = "M1option1";
            this.M1option1.Size = new System.Drawing.Size(264, 20);
            this.M1option1.TabIndex = 0;
            this.M1option1.TabStop = true;
            this.M1option1.Text = "Случайно в интервале от -100 до 100";
            this.M1option1.UseVisualStyleBackColor = true;
            this.M1option1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.M2option4);
            this.groupBox2.Controls.Add(this.M2option3);
            this.groupBox2.Controls.Add(this.M2option2);
            this.groupBox2.Controls.Add(this.M2option1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод массива 2:";
            // 
            // M2option4
            // 
            this.M2option4.AutoSize = true;
            this.M2option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M2option4.Location = new System.Drawing.Point(17, 164);
            this.M2option4.Name = "M2option4";
            this.M2option4.Size = new System.Drawing.Size(87, 20);
            this.M2option4.TabIndex = 4;
            this.M2option4.TabStop = true;
            this.M2option4.Text = "из файла";
            this.M2option4.UseVisualStyleBackColor = true;
            this.M2option4.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // M2option3
            // 
            this.M2option3.AutoSize = true;
            this.M2option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M2option3.Location = new System.Drawing.Point(17, 127);
            this.M2option3.Name = "M2option3";
            this.M2option3.Size = new System.Drawing.Size(252, 20);
            this.M2option3.TabIndex = 4;
            this.M2option3.TabStop = true;
            this.M2option3.Text = "Случайно в интервале от N1 до N2";
            this.M2option3.UseVisualStyleBackColor = true;
            this.M2option3.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // M2option2
            // 
            this.M2option2.AutoSize = true;
            this.M2option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M2option2.Location = new System.Drawing.Point(17, 92);
            this.M2option2.Name = "M2option2";
            this.M2option2.Size = new System.Drawing.Size(242, 20);
            this.M2option2.TabIndex = 4;
            this.M2option2.TabStop = true;
            this.M2option2.Text = "Случайно в интервале от 0 до N1";
            this.M2option2.UseVisualStyleBackColor = true;
            this.M2option2.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // M2option1
            // 
            this.M2option1.AutoSize = true;
            this.M2option1.Checked = true;
            this.M2option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M2option1.Location = new System.Drawing.Point(17, 57);
            this.M2option1.Name = "M2option1";
            this.M2option1.Size = new System.Drawing.Size(264, 20);
            this.M2option1.TabIndex = 4;
            this.M2option1.TabStop = true;
            this.M2option1.Text = "Случайно в интервале от -100 до 100";
            this.M2option1.UseVisualStyleBackColor = true;
            this.M2option1.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(70, 475);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(85, 80);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(184, 475);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(88, 80);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.plus_Click);
            // 
            // MassM1
            // 
            this.MassM1.AllowUserToAddRows = false;
            this.MassM1.AllowUserToDeleteRows = false;
            this.MassM1.AllowUserToResizeColumns = false;
            this.MassM1.AllowUserToResizeRows = false;
            this.MassM1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MassM1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MassM1.ColumnHeadersVisible = false;
            this.MassM1.Location = new System.Drawing.Point(601, 58);
            this.MassM1.Name = "MassM1";
            this.MassM1.ReadOnly = true;
            this.MassM1.RowHeadersVisible = false;
            this.MassM1.Size = new System.Drawing.Size(541, 23);
            this.MassM1.TabIndex = 4;
            // 
            // M1N1
            // 
            this.M1N1.Enabled = false;
            this.M1N1.Location = new System.Drawing.Point(460, 23);
            this.M1N1.Name = "M1N1";
            this.M1N1.Size = new System.Drawing.Size(100, 20);
            this.M1N1.TabIndex = 5;
            // 
            // M1N2
            // 
            this.M1N2.Enabled = false;
            this.M1N2.Location = new System.Drawing.Point(460, 64);
            this.M1N2.Name = "M1N2";
            this.M1N2.Size = new System.Drawing.Size(100, 20);
            this.M1N2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(460, 98);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(460, 137);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 40);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Ввод массива 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "N2";
            // 
            // plusM1
            // 
            this.plusM1.Enabled = false;
            this.plusM1.Location = new System.Drawing.Point(610, 137);
            this.plusM1.Name = "plusM1";
            this.plusM1.Size = new System.Drawing.Size(89, 40);
            this.plusM1.TabIndex = 11;
            this.plusM1.Text = "++";
            this.plusM1.UseVisualStyleBackColor = true;
            this.plusM1.Click += new System.EventHandler(this.plusM1_Click);
            // 
            // minusM1
            // 
            this.minusM1.Enabled = false;
            this.minusM1.Location = new System.Drawing.Point(705, 137);
            this.minusM1.Name = "minusM1";
            this.minusM1.Size = new System.Drawing.Size(89, 40);
            this.minusM1.TabIndex = 12;
            this.minusM1.Text = "--";
            this.minusM1.UseVisualStyleBackColor = true;
            this.minusM1.Click += new System.EventHandler(this.plusM1_Click);
            // 
            // plusYM1
            // 
            this.plusYM1.Enabled = false;
            this.plusYM1.Location = new System.Drawing.Point(800, 137);
            this.plusYM1.Name = "plusYM1";
            this.plusYM1.Size = new System.Drawing.Size(89, 40);
            this.plusYM1.TabIndex = 13;
            this.plusYM1.Text = "+=Y";
            this.plusYM1.UseVisualStyleBackColor = true;
            this.plusYM1.Click += new System.EventHandler(this.plusM1_Click);
            // 
            // minusYM1
            // 
            this.minusYM1.Enabled = false;
            this.minusYM1.Location = new System.Drawing.Point(895, 137);
            this.minusYM1.Name = "minusYM1";
            this.minusYM1.Size = new System.Drawing.Size(89, 40);
            this.minusYM1.TabIndex = 14;
            this.minusYM1.Text = "-=Y";
            this.minusYM1.UseVisualStyleBackColor = true;
            this.minusYM1.Click += new System.EventHandler(this.plusM1_Click);
            // 
            // YM1
            // 
            this.YM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YM1.Location = new System.Drawing.Point(1033, 142);
            this.YM1.Name = "YM1";
            this.YM1.Size = new System.Drawing.Size(60, 31);
            this.YM1.TabIndex = 15;
            this.YM1.TextChanged += new System.EventHandler(this.YM1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(990, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Y";
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM1.Location = new System.Drawing.Point(596, 23);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(123, 25);
            this.labelM1.TabIndex = 17;
            this.labelM1.Text = "Массив M1";
            // 
            // labelM2
            // 
            this.labelM2.AutoSize = true;
            this.labelM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM2.Location = new System.Drawing.Point(610, 279);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(123, 25);
            this.labelM2.TabIndex = 31;
            this.labelM2.Text = "Массив M2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1002, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Y";
            // 
            // YM2
            // 
            this.YM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YM2.Location = new System.Drawing.Point(1045, 398);
            this.YM2.Name = "YM2";
            this.YM2.Size = new System.Drawing.Size(60, 31);
            this.YM2.TabIndex = 29;
            this.YM2.TextChanged += new System.EventHandler(this.YM1_TextChanged);
            // 
            // minusYM2
            // 
            this.minusYM2.Enabled = false;
            this.minusYM2.Location = new System.Drawing.Point(907, 393);
            this.minusYM2.Name = "minusYM2";
            this.minusYM2.Size = new System.Drawing.Size(89, 40);
            this.minusYM2.TabIndex = 28;
            this.minusYM2.Text = "-=Y";
            this.minusYM2.UseVisualStyleBackColor = true;
            this.minusYM2.Click += new System.EventHandler(this.plusM2_Click);
            // 
            // plusYM2
            // 
            this.plusYM2.Enabled = false;
            this.plusYM2.Location = new System.Drawing.Point(812, 393);
            this.plusYM2.Name = "plusYM2";
            this.plusYM2.Size = new System.Drawing.Size(89, 40);
            this.plusYM2.TabIndex = 27;
            this.plusYM2.Text = "+=Y";
            this.plusYM2.UseVisualStyleBackColor = true;
            this.plusYM2.Click += new System.EventHandler(this.plusM2_Click);
            // 
            // minusM2
            // 
            this.minusM2.Enabled = false;
            this.minusM2.Location = new System.Drawing.Point(708, 393);
            this.minusM2.Name = "minusM2";
            this.minusM2.Size = new System.Drawing.Size(89, 40);
            this.minusM2.TabIndex = 26;
            this.minusM2.Text = "--";
            this.minusM2.UseVisualStyleBackColor = true;
            this.minusM2.Click += new System.EventHandler(this.plusM2_Click);
            // 
            // plusM2
            // 
            this.plusM2.Enabled = false;
            this.plusM2.Location = new System.Drawing.Point(613, 393);
            this.plusM2.Name = "plusM2";
            this.plusM2.Size = new System.Drawing.Size(89, 40);
            this.plusM2.TabIndex = 25;
            this.plusM2.Text = "++";
            this.plusM2.UseVisualStyleBackColor = true;
            this.plusM2.Click += new System.EventHandler(this.plusM2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "N2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "N1";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(472, 393);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 40);
            this.btn2.TabIndex = 22;
            this.btn2.Text = "Ввод массива 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(472, 354);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 21;
            // 
            // M2N2
            // 
            this.M2N2.Enabled = false;
            this.M2N2.Location = new System.Drawing.Point(472, 320);
            this.M2N2.Name = "M2N2";
            this.M2N2.Size = new System.Drawing.Size(100, 20);
            this.M2N2.TabIndex = 20;
            // 
            // M2N1
            // 
            this.M2N1.Enabled = false;
            this.M2N1.Location = new System.Drawing.Point(472, 279);
            this.M2N1.Name = "M2N1";
            this.M2N1.Size = new System.Drawing.Size(100, 20);
            this.M2N1.TabIndex = 19;
            // 
            // MassM2
            // 
            this.MassM2.AllowUserToAddRows = false;
            this.MassM2.AllowUserToDeleteRows = false;
            this.MassM2.AllowUserToResizeColumns = false;
            this.MassM2.AllowUserToResizeRows = false;
            this.MassM2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MassM2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MassM2.ColumnHeadersVisible = false;
            this.MassM2.Location = new System.Drawing.Point(613, 314);
            this.MassM2.Name = "MassM2";
            this.MassM2.ReadOnly = true;
            this.MassM2.RowHeadersVisible = false;
            this.MassM2.Size = new System.Drawing.Size(529, 23);
            this.MassM2.TabIndex = 18;
            // 
            // sum
            // 
            this.sum.AllowUserToDeleteRows = false;
            this.sum.AllowUserToResizeColumns = false;
            this.sum.AllowUserToResizeRows = false;
            this.sum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sum.ColumnHeadersVisible = false;
            this.sum.Location = new System.Drawing.Point(613, 577);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.RowHeadersVisible = false;
            this.sum.Size = new System.Drawing.Size(524, 24);
            this.sum.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(610, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 33;
            // 
            // ZM1
            // 
            this.ZM1.Location = new System.Drawing.Point(485, 202);
            this.ZM1.Name = "ZM1";
            this.ZM1.Size = new System.Drawing.Size(75, 23);
            this.ZM1.TabIndex = 35;
            this.ZM1.Text = "Задание";
            this.ZM1.UseVisualStyleBackColor = true;
            this.ZM1.Click += new System.EventHandler(this.ZM1_Click);
            // 
            // AM1
            // 
            this.AM1.AutoSize = true;
            this.AM1.Location = new System.Drawing.Point(607, 207);
            this.AM1.Name = "AM1";
            this.AM1.Size = new System.Drawing.Size(0, 13);
            this.AM1.TabIndex = 36;
            // 
            // AM2
            // 
            this.AM2.AutoSize = true;
            this.AM2.Location = new System.Drawing.Point(607, 467);
            this.AM2.Name = "AM2";
            this.AM2.Size = new System.Drawing.Size(0, 13);
            this.AM2.TabIndex = 38;
            // 
            // ZM2
            // 
            this.ZM2.Location = new System.Drawing.Point(485, 462);
            this.ZM2.Name = "ZM2";
            this.ZM2.Size = new System.Drawing.Size(75, 23);
            this.ZM2.TabIndex = 37;
            this.ZM2.Text = "Задание";
            this.ZM2.UseVisualStyleBackColor = true;
            this.ZM2.Click += new System.EventHandler(this.ZM1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 629);
            this.Controls.Add(this.AM2);
            this.Controls.Add(this.ZM2);
            this.Controls.Add(this.AM1);
            this.Controls.Add(this.ZM1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.labelM2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MassM1);
            this.Controls.Add(this.YM2);
            this.Controls.Add(this.minusYM2);
            this.Controls.Add(this.plusYM2);
            this.Controls.Add(this.minusM2);
            this.Controls.Add(this.plusM2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.M2N2);
            this.Controls.Add(this.M2N1);
            this.Controls.Add(this.MassM2);
            this.Controls.Add(this.labelM1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YM1);
            this.Controls.Add(this.minusYM1);
            this.Controls.Add(this.plusYM1);
            this.Controls.Add(this.minusM1);
            this.Controls.Add(this.plusM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.M1N2);
            this.Controls.Add(this.M1N1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton M1option4;
        private System.Windows.Forms.RadioButton M1option3;
        private System.Windows.Forms.RadioButton M1option2;
        private System.Windows.Forms.RadioButton M1option1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton M2option4;
        private System.Windows.Forms.RadioButton M2option3;
        private System.Windows.Forms.RadioButton M2option2;
        private System.Windows.Forms.RadioButton M2option1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.DataGridView MassM1;
        private System.Windows.Forms.TextBox M1N1;
        private System.Windows.Forms.TextBox M1N2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plusM1;
        private System.Windows.Forms.Button minusM1;
        private System.Windows.Forms.Button plusYM1;
        private System.Windows.Forms.Button minusYM1;
        private System.Windows.Forms.TextBox YM1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelM1;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YM2;
        private System.Windows.Forms.Button minusYM2;
        private System.Windows.Forms.Button plusYM2;
        private System.Windows.Forms.Button minusM2;
        private System.Windows.Forms.Button plusM2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox M2N2;
        private System.Windows.Forms.TextBox M2N1;
        private System.Windows.Forms.DataGridView MassM2;
        private System.Windows.Forms.DataGridView sum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ZM1;
        private System.Windows.Forms.Label AM1;
        private System.Windows.Forms.Label AM2;
        private System.Windows.Forms.Button ZM2;
    }
}

