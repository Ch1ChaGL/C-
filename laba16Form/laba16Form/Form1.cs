
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba16;

namespace laba16Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;
        }
        public bool openFileSelected;
        public MyFile fileSelected;
        MyFile file = null;
        bool fileExists = false;
        string lastAction = "";
        public bool isSaving = true;
        private void newFile_Click(object sender, EventArgs e)
        {

            if (!isSaving)
            {
                showDialogSave();
            }
            richTextBox1.Text = "";
            richTextBox1.Enabled = true;
            file = new MyFile();
            fileExists = true;
            lastAction = "Создание нового файла";
            statusBar();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            isSaving = true;
            file.Text = richTextBox1.Text;
            file.SaveFile();
            lastAction = "Сохранение";
            statusBar();

        }

        private void open_Click(object sender, EventArgs e)
        {
           
            file = new MyFile();
            if(file.OpenFile() == 1)
            {
                fileExists = true;
                richTextBox1.Text = file.Text;
                lastAction = "Открытие файла из папки";
                statusBar();
            }
            if (!isSaving)
            {
                showDialogSave();
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            if (!isSaving)
            {
                showDialogSave();
            }
            Application.Exit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (file.Delete() == 1) {
                richTextBox1.Text = "";
                richTextBox1.Enabled = false;
                fileExists = false;
                lastAction = "Удаление файла";
                statusBar();
            }
            
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (fileExists) { 
                file.PrintResult(new Font("Arial", 24, FontStyle.Bold));
                lastAction = "Печать на принтер";
            } 
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            isSaving = true;
            if (fileExists) {
                file.Text = richTextBox1.Text;
                if (file.SaveFileAs() == 1)
                {
                    richTextBox1.Enabled = true;
                    fileExists = true;
                    lastAction = "Сохранение в выбранный путь";
                    statusBar();
                }
            }
            
            
        }

        private void statusBar()
        {
            SymbolsCount.Text = $"Количество символов: {file.SymbolsCount()}";
            LineCount.Text = $"Количество строк: {file.LineCount()}";
            LastAction.Text = $"Последнее действие {lastAction}";
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void showDialogSave()
        {
            DialogResult result = MessageBox.Show("Сохранить последний добавленный файл", "Предупреждение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                file.SaveFile();
            }
        }

        private void поискКоличестваСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(file is null)
            {
                MessageBox.Show($"Файл не создан");
            }
            else
            {
                MessageBox.Show($"Количество слов в тексте {file.Words()}");
            }          
        }

        private void проверкаМатематическогоВыраженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file is null)
            {
                MessageBox.Show($"Файл не создан");
            }
            else
            {
                if (file.CheckBrackets())
                {
                    MessageBox.Show("Скобки расставлена правильно");
                }
                else
                {
                    MessageBox.Show("Скобки расставлена неправильно");
                } 
               
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            file.Text = richTextBox1.Text;
            lastAction = "Набор текста";
            isSaving = false;
            statusBar();
        }

        private void поискФайловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!isSaving)
            {
                showDialogSave();
            }
           
            Visible = false;
            openFileSelected = false;
            fileSelected = null;
            search sh = new search(this);
            sh.ShowDialog();
            Visible = true;

            if(openFileSelected == true)
            {
                file = fileSelected;
               
                if (MyFile.OpenFile(file) == 1)
                {
                   
                    fileExists = true;
                    richTextBox1.Enabled = true;
                    richTextBox1.Text = file.Text;
                    isSaving = true;
                    lastAction = "Выбор файла из поиска";
                    statusBar();
                }
               
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaving)
            {
                showDialogSave();
            }
        }
    }
}
