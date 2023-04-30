namespace _3_Задание_13Вариант
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawCircle = new System.Windows.Forms.Button();
            this.yCircle = new System.Windows.Forms.TextBox();
            this.xCircle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.TextBox();
            this.xContainer = new System.Windows.Forms.TextBox();
            this.yContainer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.heightContainer = new System.Windows.Forms.TextBox();
            this.widthContainer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drawTriangle = new System.Windows.Forms.Button();
            this.yTriangle = new System.Windows.Forms.TextBox();
            this.xTriangle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xB = new System.Windows.Forms.TextBox();
            this.xA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.yA = new System.Windows.Forms.TextBox();
            this.yB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.yC = new System.Windows.Forms.TextBox();
            this.xC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drawSquare = new System.Windows.Forms.Button();
            this.ySquare = new System.Windows.Forms.TextBox();
            this.xSquare = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sideSquare = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.drawRectangle = new System.Windows.Forms.Button();
            this.yRectangle = new System.Windows.Forms.TextBox();
            this.xRectangle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.heightRectangle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.widthRectangle = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SquareA = new System.Windows.Forms.RadioButton();
            this.RectangleA = new System.Windows.Forms.RadioButton();
            this.TriangleA = new System.Windows.Forms.RadioButton();
            this.CircleA = new System.Windows.Forms.RadioButton();
            this.circleB = new System.Windows.Forms.RadioButton();
            this.triangleB = new System.Windows.Forms.RadioButton();
            this.rectangleB = new System.Windows.Forms.RadioButton();
            this.squareB = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.compare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 468);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawCircle);
            this.groupBox1.Controls.Add(this.yCircle);
            this.groupBox1.Controls.Add(this.xCircle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radius);
            this.groupBox1.Location = new System.Drawing.Point(654, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Круг";
            // 
            // drawCircle
            // 
            this.drawCircle.Enabled = false;
            this.drawCircle.Location = new System.Drawing.Point(143, 134);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(80, 23);
            this.drawCircle.TabIndex = 10;
            this.drawCircle.Text = "Нарисовать";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // yCircle
            // 
            this.yCircle.Location = new System.Drawing.Point(84, 105);
            this.yCircle.Name = "yCircle";
            this.yCircle.Size = new System.Drawing.Size(139, 20);
            this.yCircle.TabIndex = 5;
            this.yCircle.TextChanged += new System.EventHandler(this.radius_TextChanged);
            this.yCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xCircle
            // 
            this.xCircle.Location = new System.Drawing.Point(84, 71);
            this.xCircle.Name = "xCircle";
            this.xCircle.Size = new System.Drawing.Size(139, 20);
            this.xCircle.TabIndex = 4;
            this.xCircle.TextChanged += new System.EventHandler(this.radius_TextChanged);
            this.xCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y-Фигуры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X-Фигуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Радиус";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(66, 36);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(157, 20);
            this.radius.TabIndex = 0;
            this.radius.TextChanged += new System.EventHandler(this.radius_TextChanged);
            this.radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xContainer
            // 
            this.xContainer.Location = new System.Drawing.Point(754, 22);
            this.xContainer.Name = "xContainer";
            this.xContainer.Size = new System.Drawing.Size(45, 20);
            this.xContainer.TabIndex = 6;
            this.xContainer.TextChanged += new System.EventHandler(this.xContainer_TextChanged);
            this.xContainer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // yContainer
            // 
            this.yContainer.Location = new System.Drawing.Point(754, 53);
            this.yContainer.Name = "yContainer";
            this.yContainer.Size = new System.Drawing.Size(45, 20);
            this.yContainer.TabIndex = 7;
            this.yContainer.TextChanged += new System.EventHandler(this.xContainer_TextChanged);
            this.yContainer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X-Контейнера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y-Контейнера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height-Контейнера";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Width-Контейнера";
            // 
            // heightContainer
            // 
            this.heightContainer.Location = new System.Drawing.Point(936, 53);
            this.heightContainer.Name = "heightContainer";
            this.heightContainer.Size = new System.Drawing.Size(69, 20);
            this.heightContainer.TabIndex = 11;
            this.heightContainer.TextChanged += new System.EventHandler(this.xContainer_TextChanged);
            this.heightContainer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // widthContainer
            // 
            this.widthContainer.Location = new System.Drawing.Point(936, 22);
            this.widthContainer.Name = "widthContainer";
            this.widthContainer.Size = new System.Drawing.Size(69, 20);
            this.widthContainer.TabIndex = 10;
            this.widthContainer.TextChanged += new System.EventHandler(this.xContainer_TextChanged);
            this.widthContainer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yC);
            this.groupBox2.Controls.Add(this.xC);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.yB);
            this.groupBox2.Controls.Add(this.yA);
            this.groupBox2.Controls.Add(this.xB);
            this.groupBox2.Controls.Add(this.xA);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.drawTriangle);
            this.groupBox2.Controls.Add(this.yTriangle);
            this.groupBox2.Controls.Add(this.xTriangle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(654, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Треугольник";
            // 
            // drawTriangle
            // 
            this.drawTriangle.Location = new System.Drawing.Point(178, 90);
            this.drawTriangle.Name = "drawTriangle";
            this.drawTriangle.Size = new System.Drawing.Size(80, 23);
            this.drawTriangle.TabIndex = 10;
            this.drawTriangle.Text = "Нарисовать";
            this.drawTriangle.UseVisualStyleBackColor = true;
            this.drawTriangle.Click += new System.EventHandler(this.drawTriangle_Click);
            // 
            // yTriangle
            // 
            this.yTriangle.Location = new System.Drawing.Point(229, 60);
            this.yTriangle.Name = "yTriangle";
            this.yTriangle.Size = new System.Drawing.Size(139, 20);
            this.yTriangle.TabIndex = 5;
            this.yTriangle.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.yTriangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xTriangle
            // 
            this.xTriangle.Location = new System.Drawing.Point(229, 26);
            this.xTriangle.Name = "xTriangle";
            this.xTriangle.Size = new System.Drawing.Size(139, 20);
            this.xTriangle.TabIndex = 4;
            this.xTriangle.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.xTriangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Y-Фигуры";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "X-Фигуры";
            // 
            // xB
            // 
            this.xB.Location = new System.Drawing.Point(70, 63);
            this.xB.Name = "xB";
            this.xB.Size = new System.Drawing.Size(34, 20);
            this.xB.TabIndex = 14;
            this.xB.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.xB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xA
            // 
            this.xA.Location = new System.Drawing.Point(70, 29);
            this.xA.Name = "xA";
            this.xA.Size = new System.Drawing.Size(34, 20);
            this.xA.TabIndex = 13;
            this.xA.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.xA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Точка B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Точка А";
            // 
            // yA
            // 
            this.yA.Location = new System.Drawing.Point(110, 29);
            this.yA.Name = "yA";
            this.yA.Size = new System.Drawing.Size(34, 20);
            this.yA.TabIndex = 15;
            this.yA.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.yA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // yB
            // 
            this.yB.Location = new System.Drawing.Point(111, 63);
            this.yB.Name = "yB";
            this.yB.Size = new System.Drawing.Size(34, 20);
            this.yB.TabIndex = 16;
            this.yB.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.yB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Точка C";
            // 
            // yC
            // 
            this.yC.Location = new System.Drawing.Point(111, 92);
            this.yC.Name = "yC";
            this.yC.Size = new System.Drawing.Size(34, 20);
            this.yC.TabIndex = 19;
            this.yC.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.yC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xC
            // 
            this.xC.Location = new System.Drawing.Point(70, 92);
            this.xC.Name = "xC";
            this.xC.Size = new System.Drawing.Size(34, 20);
            this.xC.TabIndex = 18;
            this.xC.TextChanged += new System.EventHandler(this.xA_TextChanged);
            this.xC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drawSquare);
            this.groupBox3.Controls.Add(this.ySquare);
            this.groupBox3.Controls.Add(this.xSquare);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.sideSquare);
            this.groupBox3.Location = new System.Drawing.Point(908, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 173);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Квадрат";
            // 
            // drawSquare
            // 
            this.drawSquare.Location = new System.Drawing.Point(143, 134);
            this.drawSquare.Name = "drawSquare";
            this.drawSquare.Size = new System.Drawing.Size(80, 23);
            this.drawSquare.TabIndex = 10;
            this.drawSquare.Text = "Нарисовать";
            this.drawSquare.UseVisualStyleBackColor = true;
            this.drawSquare.Click += new System.EventHandler(this.drawSquare_Click);
            // 
            // ySquare
            // 
            this.ySquare.Location = new System.Drawing.Point(84, 105);
            this.ySquare.Name = "ySquare";
            this.ySquare.Size = new System.Drawing.Size(139, 20);
            this.ySquare.TabIndex = 5;
            this.ySquare.TextChanged += new System.EventHandler(this.sideSquare_TextChanged);
            this.ySquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xSquare
            // 
            this.xSquare.Location = new System.Drawing.Point(84, 71);
            this.xSquare.Name = "xSquare";
            this.xSquare.Size = new System.Drawing.Size(139, 20);
            this.xSquare.TabIndex = 4;
            this.xSquare.TextChanged += new System.EventHandler(this.sideSquare_TextChanged);
            this.xSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Y-Фигуры";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "X-Фигуры";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Сторона";
            // 
            // sideSquare
            // 
            this.sideSquare.Location = new System.Drawing.Point(66, 36);
            this.sideSquare.Name = "sideSquare";
            this.sideSquare.Size = new System.Drawing.Size(157, 20);
            this.sideSquare.TabIndex = 0;
            this.sideSquare.TextChanged += new System.EventHandler(this.sideSquare_TextChanged);
            this.sideSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.widthRectangle);
            this.groupBox4.Controls.Add(this.drawRectangle);
            this.groupBox4.Controls.Add(this.yRectangle);
            this.groupBox4.Controls.Add(this.xRectangle);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.heightRectangle);
            this.groupBox4.Location = new System.Drawing.Point(1152, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 173);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прямоугольник";
            // 
            // drawRectangle
            // 
            this.drawRectangle.Location = new System.Drawing.Point(143, 134);
            this.drawRectangle.Name = "drawRectangle";
            this.drawRectangle.Size = new System.Drawing.Size(80, 23);
            this.drawRectangle.TabIndex = 10;
            this.drawRectangle.Text = "Нарисовать";
            this.drawRectangle.UseVisualStyleBackColor = true;
            this.drawRectangle.Click += new System.EventHandler(this.drawRectangle_Click);
            // 
            // yRectangle
            // 
            this.yRectangle.Location = new System.Drawing.Point(84, 105);
            this.yRectangle.Name = "yRectangle";
            this.yRectangle.Size = new System.Drawing.Size(139, 20);
            this.yRectangle.TabIndex = 5;
            this.yRectangle.TextChanged += new System.EventHandler(this.heightRectangle_TextChanged);
            this.yRectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // xRectangle
            // 
            this.xRectangle.Location = new System.Drawing.Point(84, 71);
            this.xRectangle.Name = "xRectangle";
            this.xRectangle.Size = new System.Drawing.Size(139, 20);
            this.xRectangle.TabIndex = 4;
            this.xRectangle.TextChanged += new System.EventHandler(this.heightRectangle_TextChanged);
            this.xRectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Y-Фигуры";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "X-Фигуры";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Высота";
            // 
            // heightRectangle
            // 
            this.heightRectangle.Location = new System.Drawing.Point(65, 19);
            this.heightRectangle.Name = "heightRectangle";
            this.heightRectangle.Size = new System.Drawing.Size(157, 20);
            this.heightRectangle.TabIndex = 0;
            this.heightRectangle.TextChanged += new System.EventHandler(this.heightRectangle_TextChanged);
            this.heightRectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Ширина";
            // 
            // widthRectangle
            // 
            this.widthRectangle.Location = new System.Drawing.Point(65, 45);
            this.widthRectangle.Name = "widthRectangle";
            this.widthRectangle.Size = new System.Drawing.Size(157, 20);
            this.widthRectangle.TabIndex = 11;
            this.widthRectangle.TextChanged += new System.EventHandler(this.heightRectangle_TextChanged);
            this.widthRectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xA_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.compare);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(654, 427);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(539, 195);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сравнить фигуры";
            // 
            // SquareA
            // 
            this.SquareA.AutoSize = true;
            this.SquareA.Location = new System.Drawing.Point(20, 19);
            this.SquareA.Name = "SquareA";
            this.SquareA.Size = new System.Drawing.Size(67, 17);
            this.SquareA.TabIndex = 0;
            this.SquareA.TabStop = true;
            this.SquareA.Text = "Квадрат";
            this.SquareA.UseVisualStyleBackColor = true;
            this.SquareA.CheckedChanged += new System.EventHandler(this.SquareA_CheckedChanged);
            // 
            // RectangleA
            // 
            this.RectangleA.AutoSize = true;
            this.RectangleA.Location = new System.Drawing.Point(20, 42);
            this.RectangleA.Name = "RectangleA";
            this.RectangleA.Size = new System.Drawing.Size(105, 17);
            this.RectangleA.TabIndex = 1;
            this.RectangleA.TabStop = true;
            this.RectangleA.Text = "Прямоугольник";
            this.RectangleA.UseVisualStyleBackColor = true;
            this.RectangleA.CheckedChanged += new System.EventHandler(this.SquareA_CheckedChanged);
            // 
            // TriangleA
            // 
            this.TriangleA.AutoSize = true;
            this.TriangleA.Location = new System.Drawing.Point(20, 65);
            this.TriangleA.Name = "TriangleA";
            this.TriangleA.Size = new System.Drawing.Size(90, 17);
            this.TriangleA.TabIndex = 2;
            this.TriangleA.TabStop = true;
            this.TriangleA.Text = "Треугольник";
            this.TriangleA.UseVisualStyleBackColor = true;
            this.TriangleA.CheckedChanged += new System.EventHandler(this.SquareA_CheckedChanged);
            // 
            // CircleA
            // 
            this.CircleA.AutoSize = true;
            this.CircleA.Location = new System.Drawing.Point(20, 88);
            this.CircleA.Name = "CircleA";
            this.CircleA.Size = new System.Drawing.Size(48, 17);
            this.CircleA.TabIndex = 3;
            this.CircleA.TabStop = true;
            this.CircleA.Text = "Круг";
            this.CircleA.UseVisualStyleBackColor = true;
            this.CircleA.CheckedChanged += new System.EventHandler(this.SquareA_CheckedChanged);
            // 
            // circleB
            // 
            this.circleB.AutoSize = true;
            this.circleB.Location = new System.Drawing.Point(6, 88);
            this.circleB.Name = "circleB";
            this.circleB.Size = new System.Drawing.Size(48, 17);
            this.circleB.TabIndex = 7;
            this.circleB.TabStop = true;
            this.circleB.Text = "Круг";
            this.circleB.UseVisualStyleBackColor = true;
            this.circleB.CheckedChanged += new System.EventHandler(this.squareB_CheckedChanged);
            // 
            // triangleB
            // 
            this.triangleB.AutoSize = true;
            this.triangleB.Location = new System.Drawing.Point(6, 65);
            this.triangleB.Name = "triangleB";
            this.triangleB.Size = new System.Drawing.Size(90, 17);
            this.triangleB.TabIndex = 6;
            this.triangleB.TabStop = true;
            this.triangleB.Text = "Треугольник";
            this.triangleB.UseVisualStyleBackColor = true;
            this.triangleB.CheckedChanged += new System.EventHandler(this.squareB_CheckedChanged);
            // 
            // rectangleB
            // 
            this.rectangleB.AutoSize = true;
            this.rectangleB.Location = new System.Drawing.Point(6, 42);
            this.rectangleB.Name = "rectangleB";
            this.rectangleB.Size = new System.Drawing.Size(105, 17);
            this.rectangleB.TabIndex = 5;
            this.rectangleB.TabStop = true;
            this.rectangleB.Text = "Прямоугольник";
            this.rectangleB.UseVisualStyleBackColor = true;
            this.rectangleB.CheckedChanged += new System.EventHandler(this.squareB_CheckedChanged);
            // 
            // squareB
            // 
            this.squareB.AutoSize = true;
            this.squareB.Location = new System.Drawing.Point(6, 19);
            this.squareB.Name = "squareB";
            this.squareB.Size = new System.Drawing.Size(67, 17);
            this.squareB.TabIndex = 4;
            this.squareB.TabStop = true;
            this.squareB.Text = "Квадрат";
            this.squareB.UseVisualStyleBackColor = true;
            this.squareB.CheckedChanged += new System.EventHandler(this.squareB_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SquareA);
            this.groupBox6.Controls.Add(this.RectangleA);
            this.groupBox6.Controls.Add(this.TriangleA);
            this.groupBox6.Controls.Add(this.CircleA);
            this.groupBox6.Location = new System.Drawing.Point(23, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 111);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ФигураА";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.squareB);
            this.groupBox7.Controls.Add(this.circleB);
            this.groupBox7.Controls.Add(this.rectangleB);
            this.groupBox7.Controls.Add(this.triangleB);
            this.groupBox7.Location = new System.Drawing.Point(306, 36);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(141, 113);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ФигураБ";
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(183, 80);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(93, 27);
            this.compare.TabIndex = 16;
            this.compare.Text = "Сравнить";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 659);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.heightContainer);
            this.Controls.Add(this.widthContainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yContainer);
            this.Controls.Add(this.xContainer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yContainer;
        private System.Windows.Forms.TextBox xContainer;
        private System.Windows.Forms.TextBox yCircle;
        private System.Windows.Forms.TextBox xCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox heightContainer;
        private System.Windows.Forms.TextBox widthContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox yC;
        private System.Windows.Forms.TextBox xC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox yB;
        private System.Windows.Forms.TextBox yA;
        private System.Windows.Forms.TextBox xB;
        private System.Windows.Forms.TextBox xA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button drawTriangle;
        private System.Windows.Forms.TextBox yTriangle;
        private System.Windows.Forms.TextBox xTriangle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button drawSquare;
        private System.Windows.Forms.TextBox ySquare;
        private System.Windows.Forms.TextBox xSquare;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox sideSquare;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox widthRectangle;
        private System.Windows.Forms.Button drawRectangle;
        private System.Windows.Forms.TextBox yRectangle;
        private System.Windows.Forms.TextBox xRectangle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox heightRectangle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton squareB;
        private System.Windows.Forms.RadioButton circleB;
        private System.Windows.Forms.RadioButton rectangleB;
        private System.Windows.Forms.RadioButton triangleB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton SquareA;
        private System.Windows.Forms.RadioButton RectangleA;
        private System.Windows.Forms.RadioButton TriangleA;
        private System.Windows.Forms.RadioButton CircleA;
    }
}

