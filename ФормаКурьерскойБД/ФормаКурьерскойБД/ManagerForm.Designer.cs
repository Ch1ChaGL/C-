namespace ФормаКурьерскойБД
{
    partial class ManagerForm
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
            this.CreateOrderBtn = new System.Windows.Forms.Button();
            this.AboutOrder = new System.Windows.Forms.Button();
            this.ListOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateOrderBtn
            // 
            this.CreateOrderBtn.Location = new System.Drawing.Point(370, 77);
            this.CreateOrderBtn.Name = "CreateOrderBtn";
            this.CreateOrderBtn.Size = new System.Drawing.Size(209, 74);
            this.CreateOrderBtn.TabIndex = 1;
            this.CreateOrderBtn.Text = "Создать заказ";
            this.CreateOrderBtn.UseVisualStyleBackColor = true;
            this.CreateOrderBtn.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // AboutOrder
            // 
            this.AboutOrder.Location = new System.Drawing.Point(370, 196);
            this.AboutOrder.Name = "AboutOrder";
            this.AboutOrder.Size = new System.Drawing.Size(209, 74);
            this.AboutOrder.TabIndex = 2;
            this.AboutOrder.Text = " Заказы подразделения";
            this.AboutOrder.UseVisualStyleBackColor = true;
            this.AboutOrder.Click += new System.EventHandler(this.AboutOrder_Click);
            // 
            // ListOrder
            // 
            this.ListOrder.Location = new System.Drawing.Point(370, 325);
            this.ListOrder.Name = "ListOrder";
            this.ListOrder.Size = new System.Drawing.Size(209, 69);
            this.ListOrder.TabIndex = 3;
            this.ListOrder.Text = "Поступающие заказы";
            this.ListOrder.UseVisualStyleBackColor = true;
            this.ListOrder.Click += new System.EventHandler(this.ListOrder_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 528);
            this.Controls.Add(this.ListOrder);
            this.Controls.Add(this.AboutOrder);
            this.Controls.Add(this.CreateOrderBtn);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateOrderBtn;
        private System.Windows.Forms.Button AboutOrder;
        private System.Windows.Forms.Button ListOrder;
    }
}