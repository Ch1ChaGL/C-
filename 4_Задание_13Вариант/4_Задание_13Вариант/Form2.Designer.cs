namespace _4_Задание_13Вариант
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TrackBar();
            this.vertically = new System.Windows.Forms.RadioButton();
            this.horizontally = new System.Windows.Forms.RadioButton();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Скорость фигуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Движение фигуры по:";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(9, 28);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(255, 45);
            this.speed.TabIndex = 11;
            this.speed.Value = 1;
            this.speed.Scroll += new System.EventHandler(this.speed_Scroll);
            // 
            // vertically
            // 
            this.vertically.AutoSize = true;
            this.vertically.Location = new System.Drawing.Point(9, 118);
            this.vertically.Name = "vertically";
            this.vertically.Size = new System.Drawing.Size(79, 17);
            this.vertically.TabIndex = 10;
            this.vertically.TabStop = true;
            this.vertically.Text = "Вертикали";
            this.vertically.UseVisualStyleBackColor = true;
            this.vertically.CheckedChanged += new System.EventHandler(this.vertically_CheckedChanged_1);
            // 
            // horizontally
            // 
            this.horizontally.AutoSize = true;
            this.horizontally.Location = new System.Drawing.Point(9, 94);
            this.horizontally.Name = "horizontally";
            this.horizontally.Size = new System.Drawing.Size(93, 17);
            this.horizontally.TabIndex = 9;
            this.horizontally.TabStop = true;
            this.horizontally.Text = "Горизонтали ";
            this.horizontally.UseVisualStyleBackColor = true;
            this.horizontally.CheckedChanged += new System.EventHandler(this.vertically_CheckedChanged_1);
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(189, 94);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(75, 23);
            this.color1.TabIndex = 8;
            this.color1.Text = "Цвет 1";
            this.color1.UseVisualStyleBackColor = true;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(189, 123);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(75, 23);
            this.color2.TabIndex = 7;
            this.color2.Text = "Цвет 2";
            this.color2.UseVisualStyleBackColor = true;
            this.color2.Click += new System.EventHandler(this.color1_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(114, 209);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 265);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.vertically);
            this.Controls.Add(this.horizontally);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.color2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.RadioButton vertically;
        private System.Windows.Forms.RadioButton horizontally;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Save;
    }
}