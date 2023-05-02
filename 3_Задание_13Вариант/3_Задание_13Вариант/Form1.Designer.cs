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
            this.xContainer = new System.Windows.Forms.TextBox();
            this.yContainer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.heightContainer = new System.Windows.Forms.TextBox();
            this.widthContainer = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.compare = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.squareB = new System.Windows.Forms.RadioButton();
            this.circleB = new System.Windows.Forms.RadioButton();
            this.rectangleB = new System.Windows.Forms.RadioButton();
            this.triangleB = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SquareA = new System.Windows.Forms.RadioButton();
            this.RectangleA = new System.Windows.Forms.RadioButton();
            this.TriangleA = new System.Windows.Forms.RadioButton();
            this.CircleA = new System.Windows.Forms.RadioButton();
            this.rotateAngle = new System.Windows.Forms.TextBox();
            this.rotate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.draw = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drawSquare = new System.Windows.Forms.RadioButton();
            this.rectangleDraw = new System.Windows.Forms.RadioButton();
            this.drawTriangle = new System.Windows.Forms.RadioButton();
            this.drawCircle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 509);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.compare);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(674, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(539, 195);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сравнить фигуры";
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
            // rotateAngle
            // 
            this.rotateAngle.Location = new System.Drawing.Point(216, 81);
            this.rotateAngle.Name = "rotateAngle";
            this.rotateAngle.Size = new System.Drawing.Size(100, 20);
            this.rotateAngle.TabIndex = 15;
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(338, 79);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 23);
            this.rotate.TabIndex = 16;
            this.rotate.Text = "Повернуть";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.draw);
            this.groupBox1.Controls.Add(this.rotate);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rotateAngle);
            this.groupBox1.Location = new System.Drawing.Point(674, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 195);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сравнить фигуры";
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(43, 136);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(93, 27);
            this.draw.TabIndex = 16;
            this.draw.Text = "Нарисовать";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drawSquare);
            this.groupBox3.Controls.Add(this.rectangleDraw);
            this.groupBox3.Controls.Add(this.drawTriangle);
            this.groupBox3.Controls.Add(this.drawCircle);
            this.groupBox3.Location = new System.Drawing.Point(23, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 111);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фигура";
            // 
            // drawSquare
            // 
            this.drawSquare.AutoSize = true;
            this.drawSquare.Location = new System.Drawing.Point(20, 19);
            this.drawSquare.Name = "drawSquare";
            this.drawSquare.Size = new System.Drawing.Size(67, 17);
            this.drawSquare.TabIndex = 0;
            this.drawSquare.TabStop = true;
            this.drawSquare.Text = "Квадрат";
            this.drawSquare.UseVisualStyleBackColor = true;
            // 
            // rectangleDraw
            // 
            this.rectangleDraw.AutoSize = true;
            this.rectangleDraw.Location = new System.Drawing.Point(20, 42);
            this.rectangleDraw.Name = "rectangleDraw";
            this.rectangleDraw.Size = new System.Drawing.Size(105, 17);
            this.rectangleDraw.TabIndex = 1;
            this.rectangleDraw.TabStop = true;
            this.rectangleDraw.Text = "Прямоугольник";
            this.rectangleDraw.UseVisualStyleBackColor = true;
            // 
            // drawTriangle
            // 
            this.drawTriangle.AutoSize = true;
            this.drawTriangle.Location = new System.Drawing.Point(20, 65);
            this.drawTriangle.Name = "drawTriangle";
            this.drawTriangle.Size = new System.Drawing.Size(90, 17);
            this.drawTriangle.TabIndex = 2;
            this.drawTriangle.TabStop = true;
            this.drawTriangle.Text = "Треугольник";
            this.drawTriangle.UseVisualStyleBackColor = true;
            // 
            // drawCircle
            // 
            this.drawCircle.AutoSize = true;
            this.drawCircle.Location = new System.Drawing.Point(20, 88);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(48, 17);
            this.drawCircle.TabIndex = 3;
            this.drawCircle.TabStop = true;
            this.drawCircle.Text = "Круг";
            this.drawCircle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.heightContainer);
            this.Controls.Add(this.widthContainer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yContainer);
            this.Controls.Add(this.xContainer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yContainer;
        private System.Windows.Forms.TextBox xContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox heightContainer;
        private System.Windows.Forms.TextBox widthContainer;
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
        private System.Windows.Forms.TextBox rotateAngle;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton drawSquare;
        private System.Windows.Forms.RadioButton rectangleDraw;
        private System.Windows.Forms.RadioButton drawTriangle;
        private System.Windows.Forms.RadioButton drawCircle;
    }
}

