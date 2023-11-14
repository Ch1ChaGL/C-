namespace lb5.ModalForm
{
    partial class LoginForm
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Passport_n = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Passport_s = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 85);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(169, 20);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 205);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(169, 20);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Зарегестрировать пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // CreateUser
            // 
            this.CreateUser.Location = new System.Drawing.Point(12, 238);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(169, 30);
            this.CreateUser.TabIndex = 5;
            this.CreateUser.Text = "Зарегестрировать";
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ФИО";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(12, 46);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(169, 20);
            this.FullName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер паспорта";
            // 
            // Passport_n
            // 
            this.Passport_n.Location = new System.Drawing.Point(12, 127);
            this.Passport_n.Name = "Passport_n";
            this.Passport_n.Size = new System.Drawing.Size(169, 20);
            this.Passport_n.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Серия паспорта";
            // 
            // Passport_s
            // 
            this.Passport_s.Location = new System.Drawing.Point(12, 166);
            this.Passport_s.Name = "Passport_s";
            this.Passport_s.Size = new System.Drawing.Size(169, 20);
            this.Passport_s.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 288);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Passport_s);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Passport_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Passport_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Passport_s;
    }
}