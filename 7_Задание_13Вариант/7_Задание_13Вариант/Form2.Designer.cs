namespace _7_Задание_13Вариант
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.byName = new System.Windows.Forms.RadioButton();
            this.byGenre = new System.Windows.Forms.RadioButton();
            this.byMemory = new System.Windows.Forms.RadioButton();
            this.byCPU = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.searchByGenre = new System.Windows.Forms.Button();
            this.searchByName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startMemory = new System.Windows.Forms.TextBox();
            this.endMemory = new System.Windows.Forms.TextBox();
            this.searchByMemory = new System.Windows.Forms.Button();
            this.searchByCPU = new System.Windows.Forms.Button();
            this.startCPU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.endCPU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameName.Location = new System.Drawing.Point(12, 49);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(163, 29);
            this.gameName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название игры";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортировать по:";
            // 
            // byName
            // 
            this.byName.AutoSize = true;
            this.byName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byName.Location = new System.Drawing.Point(4, 177);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(143, 28);
            this.byName.TabIndex = 5;
            this.byName.TabStop = true;
            this.byName.Text = "по названию";
            this.byName.UseVisualStyleBackColor = true;
            this.byName.CheckedChanged += new System.EventHandler(this.byCPU_CheckedChanged);
            // 
            // byGenre
            // 
            this.byGenre.AutoSize = true;
            this.byGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byGenre.Location = new System.Drawing.Point(4, 211);
            this.byGenre.Name = "byGenre";
            this.byGenre.Size = new System.Drawing.Size(110, 28);
            this.byGenre.TabIndex = 6;
            this.byGenre.TabStop = true;
            this.byGenre.Text = "по жанру";
            this.byGenre.UseVisualStyleBackColor = true;
            this.byGenre.CheckedChanged += new System.EventHandler(this.byCPU_CheckedChanged);
            // 
            // byMemory
            // 
            this.byMemory.AutoSize = true;
            this.byMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byMemory.Location = new System.Drawing.Point(4, 245);
            this.byMemory.Name = "byMemory";
            this.byMemory.Size = new System.Drawing.Size(191, 28);
            this.byMemory.TabIndex = 7;
            this.byMemory.TabStop = true;
            this.byMemory.Text = "по объему памяти";
            this.byMemory.UseVisualStyleBackColor = true;
            this.byMemory.CheckedChanged += new System.EventHandler(this.byCPU_CheckedChanged);
            // 
            // byCPU
            // 
            this.byCPU.AutoSize = true;
            this.byCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byCPU.Location = new System.Drawing.Point(4, 279);
            this.byCPU.Name = "byCPU";
            this.byCPU.Size = new System.Drawing.Size(239, 28);
            this.byCPU.TabIndex = 8;
            this.byCPU.TabStop = true;
            this.byCPU.Text = "по частоте процессора";
            this.byCPU.UseVisualStyleBackColor = true;
            this.byCPU.CheckedChanged += new System.EventHandler(this.byCPU_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(816, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Найти по жанру:";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.FormattingEnabled = true;
            this.genre.Items.AddRange(new object[] {
            "RPG",
            "Shooter",
            "Simulator",
            "Strategy"});
            this.genre.Location = new System.Drawing.Point(820, 49);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(144, 32);
            this.genre.TabIndex = 10;
            // 
            // searchByGenre
            // 
            this.searchByGenre.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.searchByGenre.Location = new System.Drawing.Point(820, 87);
            this.searchByGenre.Name = "searchByGenre";
            this.searchByGenre.Size = new System.Drawing.Size(144, 40);
            this.searchByGenre.TabIndex = 11;
            this.searchByGenre.Text = "Найти";
            this.searchByGenre.UseVisualStyleBackColor = true;
            this.searchByGenre.Click += new System.EventHandler(this.searchByGenre_Click);
            // 
            // searchByName
            // 
            this.searchByName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.searchByName.Location = new System.Drawing.Point(93, 84);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(82, 32);
            this.searchByName.TabIndex = 12;
            this.searchByName.Text = "Найти";
            this.searchByName.UseVisualStyleBackColor = true;
            this.searchByName.Click += new System.EventHandler(this.searchByName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(816, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Найти по объему памяти:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(816, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "От:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(953, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "До:";
            // 
            // startMemory
            // 
            this.startMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMemory.Location = new System.Drawing.Point(853, 188);
            this.startMemory.Name = "startMemory";
            this.startMemory.Size = new System.Drawing.Size(94, 29);
            this.startMemory.TabIndex = 16;
            // 
            // endMemory
            // 
            this.endMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endMemory.Location = new System.Drawing.Point(991, 188);
            this.endMemory.Name = "endMemory";
            this.endMemory.Size = new System.Drawing.Size(94, 29);
            this.endMemory.TabIndex = 17;
            // 
            // searchByMemory
            // 
            this.searchByMemory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.searchByMemory.Location = new System.Drawing.Point(820, 233);
            this.searchByMemory.Name = "searchByMemory";
            this.searchByMemory.Size = new System.Drawing.Size(144, 40);
            this.searchByMemory.TabIndex = 19;
            this.searchByMemory.Text = "Найти";
            this.searchByMemory.UseVisualStyleBackColor = true;
            this.searchByMemory.Click += new System.EventHandler(this.searchByMemory_Click);
            // 
            // searchByCPU
            // 
            this.searchByCPU.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.searchByCPU.Location = new System.Drawing.Point(820, 376);
            this.searchByCPU.Name = "searchByCPU";
            this.searchByCPU.Size = new System.Drawing.Size(144, 40);
            this.searchByCPU.TabIndex = 24;
            this.searchByCPU.Text = "Найти";
            this.searchByCPU.UseVisualStyleBackColor = true;
            this.searchByCPU.Click += new System.EventHandler(this.searchByCPU_Click);
            // 
            // startCPU
            // 
            this.startCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startCPU.Location = new System.Drawing.Point(853, 331);
            this.startCPU.Name = "startCPU";
            this.startCPU.Size = new System.Drawing.Size(94, 29);
            this.startCPU.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(953, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "До:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(816, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "От:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(816, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Найти по частоте процессора:";
            // 
            // endCPU
            // 
            this.endCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endCPU.Location = new System.Drawing.Point(991, 329);
            this.endCPU.Name = "endCPU";
            this.endCPU.Size = new System.Drawing.Size(94, 29);
            this.endCPU.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 423);
            this.Controls.Add(this.endCPU);
            this.Controls.Add(this.searchByCPU);
            this.Controls.Add(this.startCPU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchByMemory);
            this.Controls.Add(this.endMemory);
            this.Controls.Add(this.startMemory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchByName);
            this.Controls.Add(this.searchByGenre);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.byCPU);
            this.Controls.Add(this.byMemory);
            this.Controls.Add(this.byGenre);
            this.Controls.Add(this.byName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Содержание файла";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.RadioButton byGenre;
        private System.Windows.Forms.RadioButton byMemory;
        private System.Windows.Forms.RadioButton byCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.Button searchByGenre;
        private System.Windows.Forms.Button searchByName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox startMemory;
        private System.Windows.Forms.TextBox endMemory;
        private System.Windows.Forms.Button searchByMemory;
        private System.Windows.Forms.Button searchByCPU;
        private System.Windows.Forms.TextBox startCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox endCPU;
    }
}