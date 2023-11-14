namespace lb5.Cashier
{
    partial class CashierMainPage
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
            this.Currency = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.choseClient = new System.Windows.Forms.Button();
            this.ClientCurrency = new System.Windows.Forms.ComboBox();
            this.TargetCurrency = new System.Windows.Forms.ComboBox();
            this.ClientCurrencyCount = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Currency
            // 
            this.Currency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Currency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Currency.Location = new System.Drawing.Point(506, 44);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(422, 195);
            this.Currency.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(502, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о валютах";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 71);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(502, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Данные о выбранном пользователе";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(806, 594);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 33);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RegisterUser
            // 
            this.RegisterUser.Location = new System.Drawing.Point(34, 30);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(189, 34);
            this.RegisterUser.TabIndex = 6;
            this.RegisterUser.Text = "Зарегестрировать";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // choseClient
            // 
            this.choseClient.Location = new System.Drawing.Point(34, 80);
            this.choseClient.Name = "choseClient";
            this.choseClient.Size = new System.Drawing.Size(189, 34);
            this.choseClient.TabIndex = 7;
            this.choseClient.Text = "Выбрать пользователя";
            this.choseClient.UseVisualStyleBackColor = true;
            this.choseClient.Click += new System.EventHandler(this.choseClient_Click);
            // 
            // ClientCurrency
            // 
            this.ClientCurrency.FormattingEnabled = true;
            this.ClientCurrency.Location = new System.Drawing.Point(34, 131);
            this.ClientCurrency.Name = "ClientCurrency";
            this.ClientCurrency.Size = new System.Drawing.Size(189, 21);
            this.ClientCurrency.TabIndex = 8;
            // 
            // TargetCurrency
            // 
            this.TargetCurrency.FormattingEnabled = true;
            this.TargetCurrency.Location = new System.Drawing.Point(34, 171);
            this.TargetCurrency.Name = "TargetCurrency";
            this.TargetCurrency.Size = new System.Drawing.Size(189, 21);
            this.TargetCurrency.TabIndex = 9;
            // 
            // ClientCurrencyCount
            // 
            this.ClientCurrencyCount.Location = new System.Drawing.Point(34, 245);
            this.ClientCurrencyCount.Name = "ClientCurrencyCount";
            this.ClientCurrencyCount.Size = new System.Drawing.Size(189, 20);
            this.ClientCurrencyCount.TabIndex = 10;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(34, 325);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(189, 35);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(37, 401);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(186, 46);
            this.CreateOrder.TabIndex = 14;
            this.CreateOrder.Text = "Создать заказ";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Количество валюты клиента";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(34, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Итого";
            // 
            // CashierMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ClientCurrencyCount);
            this.Controls.Add(this.TargetCurrency);
            this.Controls.Add(this.ClientCurrency);
            this.Controls.Add(this.choseClient);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Currency);
            this.Name = "CashierMainPage";
            this.Text = "CashierMainPage";
            ((System.ComponentModel.ISupportInitialize)(this.Currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Currency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.Button choseClient;
        private System.Windows.Forms.ComboBox ClientCurrency;
        private System.Windows.Forms.ComboBox TargetCurrency;
        private System.Windows.Forms.TextBox ClientCurrencyCount;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}