using laba16;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace laba16Form
{
    public partial class search : Form
    {
        public search(Form1 form1, Font font)
        {
            InitializeComponent();
            this.Font = font;
            this.form1 = form1;
        }
        Form1 form1;
        List<string> fileList = new List<string>();
        List<MyFile> myFileList = new List<MyFile>();
        string searchPattern = "*.txt";
        string directoryPath = "";
        public void FindFiles(string searchPattern)
        {
            
            // Открываем диалоговое окно для выбора директории
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    listBox1.Items.Clear();
                    fileList.Clear();
                    myFileList.Clear();
                    directoryPath = dialog.SelectedPath;
                    try
                    {
                        DirectoryInfo directory = new DirectoryInfo(directoryPath);

                        // Проверяем, что директория существует
                        if (directory.Exists)
                        {
                            Catalog.Text = directoryPath;
                            // Получаем все файлы в заданном каталоге с заданным шаблоном
                            FileInfo[] files = directory.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

                            // Добавляем названия файлов в список
                            foreach (FileInfo file in files)
                            {
                                string fileContent = File.ReadAllText(file.FullName, Encoding.UTF8);
                                fileList.Add(file.Name);
                                myFileList.Add(new MyFile(directoryPath +"\\" + file.Name, fileContent));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Directory does not exist: " + directoryPath);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error finding files: " + e.Message);
                    }
                }
            }
        }


        private void searchCatalog(string searchPattern)
        {
            listBox1.Items.Clear();
            fileList.Clear();
            myFileList.Clear();
            try
            {
                DirectoryInfo directory = new DirectoryInfo(directoryPath);

                // Проверяем, что директория существует
                if (directory.Exists)
                {
                    Catalog.Text = directoryPath;
                    // Получаем все файлы в заданном каталоге с заданным шаблоном
                    FileInfo[] files = directory.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

                    // Добавляем названия файлов в список
                    foreach (FileInfo file in files)
                    {
                        string fileContent = File.ReadAllText(file.FullName, Encoding.UTF8);
                        fileList.Add(file.Name);
                        myFileList.Add(new MyFile(directoryPath + "\\" + file.Name, fileContent));
                    }
                }
                else
                {
                    Console.WriteLine("Directory does not exist: " + directoryPath);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error finding files: " + e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(pattern.Text != "")
            {
                FindFiles(searchPattern);
            }
            else
            {
                FindFiles(searchPattern);
            }
            foreach(var value in myFileList)
            {
                listBox1.Items.Add(value.shortName);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (pattern.Text != "")
            {
                searchCatalog(pattern.Text);
            }
            else
            {
                searchCatalog(searchPattern);
            }
           
            foreach (var value in myFileList)
            {
                listBox1.Items.Add(value.shortName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = Sort.Text;
            if(name == "по имени файла")
            {
                MyFile.SortByNames(ref myFileList);
            }
            if(name == "по количеству символов в файле")
            {
                MyFile.SortBySymbols(ref myFileList);
            }
            if(name == "по количеству слов в файле")
            {
                MyFile.SortByWordsLength(ref myFileList);
            }
            listBox1.Items.Clear();
            foreach (var value in myFileList)
            {
                listBox1.Items.Add(value.shortName);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                form1.openFileSelected = true;
                MyFile file = myFileList.Find(x => x.shortName == selectedItem);
                form1.fileSelected = file;
                form1.isSaving = true;
               
                Close();
            }
        }

        
    }
}
