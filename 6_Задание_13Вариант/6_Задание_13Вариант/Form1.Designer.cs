namespace _6_Задание_13Вариант
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.unLoad = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wordsList = new System.Windows.Forms.ListBox();
            this.listDict = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.see = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountConsonants = new System.Windows.Forms.TextBox();
            this.where = new System.Windows.Forms.ComboBox();
            this.zadanie = new System.Windows.Forms.Button();
            this.listZadanie = new System.Windows.Forms.ListBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.see);
            this.tabPage1.Controls.Add(this.unLoad);
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Controls.Add(this.search);
            this.tabPage1.Controls.Add(this.del);
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.Word);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.wordsList);
            this.tabPage1.Controls.Add(this.listDict);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Словарь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // unLoad
            // 
            this.unLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.unLoad.Location = new System.Drawing.Point(217, 301);
            this.unLoad.Name = "unLoad";
            this.unLoad.Size = new System.Drawing.Size(158, 58);
            this.unLoad.TabIndex = 10;
            this.unLoad.Text = "Выгрузить изменения";
            this.unLoad.UseVisualStyleBackColor = true;
            this.unLoad.Click += new System.EventHandler(this.unLoad_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save.Location = new System.Drawing.Point(27, 301);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 58);
            this.save.TabIndex = 9;
            this.save.Text = "Сохранить изменения";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.ForeColor = System.Drawing.Color.Blue;
            this.search.Location = new System.Drawing.Point(27, 228);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(158, 58);
            this.search.TabIndex = 8;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.del.Location = new System.Drawing.Point(217, 147);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(158, 58);
            this.del.TabIndex = 7;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.ForestGreen;
            this.add.Location = new System.Drawing.Point(27, 147);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(158, 58);
            this.add.TabIndex = 6;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word.Location = new System.Drawing.Point(191, 97);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(219, 29);
            this.Word.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите слово";
            // 
            // wordsList
            // 
            this.wordsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsList.FormattingEnabled = true;
            this.wordsList.ItemHeight = 25;
            this.wordsList.Location = new System.Drawing.Point(416, 32);
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(371, 379);
            this.wordsList.TabIndex = 3;
            // 
            // listDict
            // 
            this.listDict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listDict.FormattingEnabled = true;
            this.listDict.Location = new System.Drawing.Point(191, 32);
            this.listDict.Name = "listDict";
            this.listDict.Size = new System.Drawing.Size(219, 32);
            this.listDict.TabIndex = 2;
            this.listDict.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите словарь";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countWords});
            this.statusStrip1.Location = new System.Drawing.Point(3, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countWords
            // 
            this.countWords.Name = "countWords";
            this.countWords.Size = new System.Drawing.Size(104, 17);
            this.countWords.Text = "Количество слов:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.listZadanie);
            this.tabPage2.Controls.Add(this.zadanie);
            this.tabPage2.Controls.Add(this.where);
            this.tabPage2.Controls.Add(this.CountConsonants);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа со словарем";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Создать словарь";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // see
            // 
            this.see.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.see.ForeColor = System.Drawing.Color.Blue;
            this.see.Location = new System.Drawing.Point(217, 228);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(158, 58);
            this.see.TabIndex = 11;
            this.see.Text = "Просмотреть";
            this.see.UseVisualStyleBackColor = true;
            this.see.Click += new System.EventHandler(this.see_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(796, 448);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Справка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество согласных";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Где";
            // 
            // CountConsonants
            // 
            this.CountConsonants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountConsonants.Location = new System.Drawing.Point(237, 45);
            this.CountConsonants.Name = "CountConsonants";
            this.CountConsonants.Size = new System.Drawing.Size(121, 29);
            this.CountConsonants.TabIndex = 2;
            // 
            // where
            // 
            this.where.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.where.FormattingEnabled = true;
            this.where.Items.AddRange(new object[] {
            "В начале",
            "В конце"});
            this.where.Location = new System.Drawing.Point(65, 93);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(121, 32);
            this.where.TabIndex = 3;
            this.where.Text = "В начале";
            // 
            // zadanie
            // 
            this.zadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zadanie.ForeColor = System.Drawing.Color.ForestGreen;
            this.zadanie.Location = new System.Drawing.Point(19, 156);
            this.zadanie.Name = "zadanie";
            this.zadanie.Size = new System.Drawing.Size(158, 58);
            this.zadanie.TabIndex = 7;
            this.zadanie.Text = "Найти";
            this.zadanie.UseVisualStyleBackColor = true;
            this.zadanie.Click += new System.EventHandler(this.zadanie_Click);
            // 
            // listZadanie
            // 
            this.listZadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listZadanie.FormattingEnabled = true;
            this.listZadanie.ItemHeight = 25;
            this.listZadanie.Location = new System.Drawing.Point(400, 23);
            this.listZadanie.Name = "listZadanie";
            this.listZadanie.Size = new System.Drawing.Size(371, 379);
            this.listZadanie.TabIndex = 8;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(3, 423);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(790, 22);
            this.statusStrip2.TabIndex = 9;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(161, 17);
            this.toolStripStatusLabel1.Text = "Количество найденых слов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Словарь";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox listDict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countWords;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox wordsList;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button unLoad;
        private System.Windows.Forms.Button see;
        private System.Windows.Forms.ListBox listZadanie;
        private System.Windows.Forms.Button zadanie;
        private System.Windows.Forms.ComboBox where;
        private System.Windows.Forms.TextBox CountConsonants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

