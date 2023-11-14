namespace lb5
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
            this.components = new System.ComponentModel.Container();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SiginIn = new System.Windows.Forms.Button();
            this.Captha = new System.Windows.Forms.PictureBox();
            this.textCaptha = new System.Windows.Forms.TextBox();
            this.GenerateCaptha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Captha)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(217, 147);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(376, 31);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(217, 237);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(268, 31);
            this.Password.TabIndex = 1;
            // 
            // ShowPassword
            // 
            this.ShowPassword.Location = new System.Drawing.Point(501, 237);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(92, 31);
            this.ShowPassword.TabIndex = 2;
            this.ShowPassword.Text = "Просмотреть";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseDown);
            this.ShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(212, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // SiginIn
            // 
            this.SiginIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiginIn.Location = new System.Drawing.Point(217, 296);
            this.SiginIn.Name = "SiginIn";
            this.SiginIn.Size = new System.Drawing.Size(376, 38);
            this.SiginIn.TabIndex = 5;
            this.SiginIn.Text = "Войти";
            this.SiginIn.UseVisualStyleBackColor = true;
            this.SiginIn.Click += new System.EventHandler(this.SiginIn_Click);
            // 
            // Captha
            // 
            this.Captha.Location = new System.Drawing.Point(721, 192);
            this.Captha.Name = "Captha";
            this.Captha.Size = new System.Drawing.Size(155, 68);
            this.Captha.TabIndex = 6;
            this.Captha.TabStop = false;
            // 
            // textCaptha
            // 
            this.textCaptha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCaptha.Location = new System.Drawing.Point(721, 266);
            this.textCaptha.Name = "textCaptha";
            this.textCaptha.Size = new System.Drawing.Size(282, 31);
            this.textCaptha.TabIndex = 7;
            // 
            // GenerateCaptha
            // 
            this.GenerateCaptha.Location = new System.Drawing.Point(892, 192);
            this.GenerateCaptha.Name = "GenerateCaptha";
            this.GenerateCaptha.Size = new System.Drawing.Size(111, 68);
            this.GenerateCaptha.TabIndex = 8;
            this.GenerateCaptha.Text = "Перегенерировать";
            this.GenerateCaptha.UseVisualStyleBackColor = true;
            this.GenerateCaptha.Click += new System.EventHandler(this.GenerateCaptha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(718, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите капчу";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(217, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenerateCaptha);
            this.Controls.Add(this.textCaptha);
            this.Controls.Add(this.Captha);
            this.Controls.Add(this.SiginIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Логин";
            ((System.ComponentModel.ISupportInitialize)(this.Captha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SiginIn;
        private System.Windows.Forms.PictureBox Captha;
        private System.Windows.Forms.TextBox textCaptha;
        private System.Windows.Forms.Button GenerateCaptha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

