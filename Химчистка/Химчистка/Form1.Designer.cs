namespace Химчистка
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
            this.createOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(277, 83);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(312, 81);
            this.createOrder.TabIndex = 0;
            this.createOrder.Text = "Создать заказ";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактирование таблиц";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выдать заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

