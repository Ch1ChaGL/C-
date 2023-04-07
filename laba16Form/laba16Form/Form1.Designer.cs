namespace laba16Form
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SymbolsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.парметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискКоличестваСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаМатематическогоВыраженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newFile = new System.Windows.Forms.ToolStripButton();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.print = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.SaveAs = new System.Windows.Forms.ToolStripButton();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SymbolsCount,
            this.LineCount,
            this.LastAction});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SymbolsCount
            // 
            this.SymbolsCount.Name = "SymbolsCount";
            this.SymbolsCount.Size = new System.Drawing.Size(133, 17);
            this.SymbolsCount.Text = "Количество символов:";
            // 
            // LineCount
            // 
            this.LineCount.Name = "LineCount";
            this.LineCount.Size = new System.Drawing.Size(109, 17);
            this.LineCount.Text = "Количество строк:";
            // 
            // LastAction
            // 
            this.LastAction.Name = "LastAction";
            this.LastAction.Size = new System.Drawing.Size(125, 17);
            this.LastAction.Text = "Последнее действие: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 327);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.парметрыToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // парметрыToolStripMenuItem
            // 
            this.парметрыToolStripMenuItem.Name = "парметрыToolStripMenuItem";
            this.парметрыToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.парметрыToolStripMenuItem.Text = "Парметры";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискКоличестваСловToolStripMenuItem,
            this.проверкаМатематическогоВыраженияToolStripMenuItem,
            this.поискФайловToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискКоличестваСловToolStripMenuItem
            // 
            this.поискКоличестваСловToolStripMenuItem.Name = "поискКоличестваСловToolStripMenuItem";
            this.поискКоличестваСловToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.поискКоличестваСловToolStripMenuItem.Text = "Поиск количества слов";
            this.поискКоличестваСловToolStripMenuItem.Click += new System.EventHandler(this.поискКоличестваСловToolStripMenuItem_Click);
            // 
            // проверкаМатематическогоВыраженияToolStripMenuItem
            // 
            this.проверкаМатематическогоВыраженияToolStripMenuItem.Name = "проверкаМатематическогоВыраженияToolStripMenuItem";
            this.проверкаМатематическогоВыраженияToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.проверкаМатематическогоВыраженияToolStripMenuItem.Text = "Проверка математического выражения";
            this.проверкаМатематическогоВыраженияToolStripMenuItem.Click += new System.EventHandler(this.проверкаМатематическогоВыраженияToolStripMenuItem_Click);
            // 
            // поискФайловToolStripMenuItem
            // 
            this.поискФайловToolStripMenuItem.Name = "поискФайловToolStripMenuItem";
            this.поискФайловToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.поискФайловToolStripMenuItem.Text = "Поиск файлов";
            this.поискФайловToolStripMenuItem.Click += new System.EventHandler(this.поискФайловToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.open,
            this.Delete,
            this.print,
            this.Save,
            this.SaveAs,
            this.Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 57);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newFile
            // 
            this.newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFile.Image = global::laba16Form.Properties.Resources.new_file_40454;
            this.newFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(54, 54);
            this.newFile.Text = "Создать файл";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // open
            // 
            this.open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open.Image = global::laba16Form.Properties.Resources._3643772_archive_archives_document_folder_open_113445;
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(54, 54);
            this.open.Text = "Открыть Файл";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = global::laba16Form.Properties.Resources.crosscirclehd_106118;
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(54, 54);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // print
            // 
            this.print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print.Image = global::laba16Form.Properties.Resources.print_printer_tool_with_printed_paper_outlined_symbol_icon_icons_com_57772;
            this.print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(54, 54);
            this.print.Text = "Printer";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = global::laba16Form.Properties.Resources.Save_37110;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(54, 54);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs.Image = global::laba16Form.Properties.Resources.diskette_save_saveas_1514;
            this.SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(54, 54);
            this.SaveAs.Text = "Сохранить как";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Exit
            // 
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = global::laba16Form.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 54);
            this.Exit.Text = "Выйти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SymbolsCount;
        private System.Windows.Forms.ToolStripStatusLabel LineCount;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newFile;
        private System.Windows.Forms.ToolStripMenuItem парметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripButton print;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton SaveAs;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.ToolStripStatusLabel LastAction;
        private System.Windows.Forms.ToolStripMenuItem поискКоличестваСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаМатематическогоВыраженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискФайловToolStripMenuItem;
    }
}

