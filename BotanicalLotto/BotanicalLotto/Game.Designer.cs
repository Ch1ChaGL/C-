namespace BotanicalLotto
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.State = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TimerText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hintText = new System.Windows.Forms.Label();
            this.Skip = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(330, 12);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(0, 13);
            this.State.TabIndex = 4;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(23, 390);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(35, 13);
            this.Question.TabIndex = 5;
            this.Question.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(913, 268);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(130, 73);
            this.Next.TabIndex = 8;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(768, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 213);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Варианты Ответов";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 154);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.Location = new System.Drawing.Point(765, 401);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(0, 13);
            this.TimerText.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hintText
            // 
            this.hintText.Location = new System.Drawing.Point(299, 79);
            this.hintText.Name = "hintText";
            this.hintText.Size = new System.Drawing.Size(463, 262);
            this.hintText.TabIndex = 11;
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(768, 268);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(129, 73);
            this.Skip.TabIndex = 12;
            this.Skip.Text = "Пропустить";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // hint
            // 
            this.hint.Location = new System.Drawing.Point(462, 370);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(151, 53);
            this.hint.TabIndex = 13;
            this.hint.Text = "Подсказка";
            this.hint.UseVisualStyleBackColor = true;
            this.hint.Click += new System.EventHandler(this.hint_Click);
            this.hint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hint_MouseDown);
            this.hint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hint_MouseUp);
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.hintText);
            this.Controls.Add(this.TimerText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.State);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label TimerText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hintText;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button hint;
    }
}