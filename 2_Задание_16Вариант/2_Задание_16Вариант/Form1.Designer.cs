namespace _2_Задание_16Вариант
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
            this.system = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NaturalNumber = new System.Windows.Forms.TextBox();
            this.translate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.translateFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.result = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // system
            // 
            this.system.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.system.FormattingEnabled = true;
            this.system.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.system.Location = new System.Drawing.Point(21, 96);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(221, 32);
            this.system.TabIndex = 0;
            this.system.TextChanged += new System.EventHandler(this.NaturalNumber_TextChanged);
            this.system.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.system_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Целевая система счисления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Натуральное число";
            // 
            // NaturalNumber
            // 
            this.NaturalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NaturalNumber.Location = new System.Drawing.Point(21, 204);
            this.NaturalNumber.Name = "NaturalNumber";
            this.NaturalNumber.Size = new System.Drawing.Size(180, 29);
            this.NaturalNumber.TabIndex = 3;
            this.NaturalNumber.TextChanged += new System.EventHandler(this.NaturalNumber_TextChanged);
            this.NaturalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NaturalNumber_KeyPress);
            // 
            // translate
            // 
            this.translate.Enabled = false;
            this.translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translate.Location = new System.Drawing.Point(21, 272);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(144, 46);
            this.translate.TabIndex = 4;
            this.translate.Text = "Перевести";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translateFromFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // translateFromFile
            // 
            this.translateFromFile.Enabled = false;
            this.translateFromFile.Name = "translateFromFile";
            this.translateFromFile.Size = new System.Drawing.Size(119, 20);
            this.translateFromFile.Text = "Перевод из файла";
            this.translateFromFile.Click += new System.EventHandler(this.translateFromFile_Click);
            // 
            // result
            // 
            this.result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.ColumnHeadersVisible = false;
            this.result.Location = new System.Drawing.Point(354, 204);
            this.result.Name = "result";
            this.result.RowHeadersVisible = false;
            this.result.Size = new System.Drawing.Size(402, 31);
            this.result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.NaturalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.system);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Перевод натурального числа в n-ую систему счисления";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox system;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NaturalNumber;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem translateFromFile;
        private System.Windows.Forms.DataGridView result;
    }
}

