using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;

namespace laba16
{
    public class MyFile : IComparable
    {
        private string path;
        public string shortName { get; private set; }
        private string text;

        private StreamReader streamToPrint;
        private Font printFont;


        private string ShortFileName()
        {
            int index = path.LastIndexOf('\\');
            return path.Remove(0, index + 1);
        }

        public MyFile()
        {   
            text = "";
            path = "noName.txt";
            shortName = "noName.txt";
            int filecount = 1;
            while (File.Exists(path))
            {
                path = $"noName ({filecount}).txt";
                shortName = path;
                filecount++;
            }
        }

        public MyFile(string _path)
        {
            path = _path;
            shortName = ShortFileName();
            text = "";
        }

        public MyFile(string _path, string _text)
        {
            path = _path;
            text = _text;
            shortName = ShortFileName();
        }


        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        public string Path
        {
            get
            {
                return path;
            }
        }






        /// <summary>
        /// Открытие файла
        /// </summary>
        public int OpenFile()
        {
            //StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251));
            //text = sr.ReadToEnd();
            //sr.Close();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding(1251)/*, Encoding.UTF8*/);
                path = openFileDialog.FileName;
                text = sr.ReadToEnd();
                sr.Close();
                return 1;
            }else
            {
                return 0;
            }
        }
        public static int OpenFile(MyFile file)
        {
            StreamReader sr = new StreamReader(file.Path, /*Encoding.GetEncoding(1251)*/ Encoding.UTF8);
            file.path = file.Path;
            file.text = sr.ReadToEnd();
            sr.Close();
            return 1;
        }
        public int Delete()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                return 1;
            }            
            else
            {
                // Если ни файл, ни папка не найдены по заданному пути, бросаем исключение
                return 0;
            }
        }

        /// <summary>
        /// Сохранение файла на диск
        /// </summary>
        public void SaveFile()
        {

           
            StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding(1251));
            //Создание нового выходного потока, установка кодировки
            sw.Write(this.text);
            sw.Close();
        }
        public int SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // задаем фильтр для сохранения в текстовом формате
            saveFileDialog.Title = "Save File As";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // сохраняем содержимое в выбранный файл
                
                path = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(text);
                sw.Close();
                return 1;
            }
            return 0;
        }

        public  bool CheckBrackets()
        {
            string expression = text;
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0) return false;
                    stack.Pop();                  
                }
            }

            return stack.Count == 0;
        }

        public static MyFile CheckBrackets(MyFile file)
        {
            string[] lines = file.Text.Split('\n');
            var invalidLines = new List<string>();
            var stack = new Stack<char>();

            foreach (var line in lines)
            {
                foreach (char c in line)
                {
                    if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        if (stack.Count == 0)
                        {
                            invalidLines.Add(line);
                            break;
                        }
                        stack.Pop();
                    }
                }
                if (stack.Count != 0)
                {
                    invalidLines.Add(line);
                }
                stack.Clear();
            }

            string pathWrong = file.path;
            string nameWrong = $"Файл с неправильными выражениями.txt";
            MyFile wrongFile = new MyFile(nameWrong, string.Join("\n", invalidLines));
            wrongFile.SaveFile();
            return wrongFile;
            
        }



        public bool PrintResult(Font pF)
        {
            try
            {
                streamToPrint = new StreamReader(path, Encoding.GetEncoding(1251));
                printFont = pF;
                PrintDocument pd = new PrintDocument();
                try
                {
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Document = pd;

                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    printPreviewDialog.ShowDialog();
                    pd.Print();
                    return true;
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch
            {
                return false;
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Чтобы вычислить количество строк на странице
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Печатаем каждую строку файла
            while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
            }

            // если строки не закончились, распечатаем еще одну страницу
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        public int Words()
        {
            if (string.IsNullOrWhiteSpace(this.text))
            {
                return 0;
            }
            string[] words = text.Split(new char[] { ' ', '\t', '\r', '\n', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is MyFile))
                return false;
            if (text.Length == ((MyFile)obj).text.Length)
                return true;
            else return false;

        }

        public override int GetHashCode()
        {
            return text.GetHashCode();
        }


        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is MyFile))
                throw new ArgumentException("Это не объект класса MyFile");
            if (text.Length > ((MyFile)obj).text.Length) return 1;
            if (text.Length < ((MyFile)obj).text.Length) return -1;
            return 0;
        }


        public static bool operator ==(MyFile obj1, MyFile obj2)
        {
            return obj1.Equals(obj2);
        }
        public static bool operator !=(MyFile obj1, MyFile obj2)
        {
            return !obj1.Equals(obj2);
        }

        public static bool operator >(MyFile obj1, MyFile obj2)
        {
            return obj1.CompareTo(obj2) > 0;
        }
        public static bool operator >=(MyFile obj1, MyFile obj2)
        {
            return obj1.CompareTo(obj2) >= 0;
        }
        public static bool operator <(MyFile obj1, MyFile obj2)
        {
            return obj1.CompareTo(obj2) < 0;
        }
        public static bool operator <=(MyFile obj1, MyFile obj2)
        {
            return obj1.CompareTo(obj2) <= 0;
        }

        public int SymbolsCount()
        {
            return text.Length;
        }
        public int LineCount()
        {
            return text.Split('\n').Length;
        }


        class MyFileNameComparer : IComparer<MyFile> // Вспомогательный класс
        {
            public int Compare(MyFile obj1, MyFile obj2)
            {
                return String.Compare(obj1.shortName, obj2.shortName);
            }
        }
        class MyFileSymbolsComparer : IComparer<MyFile>
        {
            public int Compare(MyFile obj1, MyFile obj2)
            {
                if (obj1.Text.Length > obj2.Text.Length) return 1;
                if(obj1.Text.Length < obj2.Text.Length) return -1;
                return 0;
            }
        }
        class MyFileWordsComparer : IComparer<MyFile>
        {
            public int Compare(MyFile obj1, MyFile obj2)
            {
                if (obj1.Words() > obj2.Words()) return 1;
                if(obj1.Words() < obj2.Words()) return -1;
                return 0;
            }
        }


        public static void SortByNames(ref List<MyFile> files)
        {
            files.Sort(new MyFileNameComparer());
        }
        public static void SortBySymbols(ref List<MyFile> files)
        {
            files.Sort(new MyFileSymbolsComparer());
        }

        public static void SortByWordsLength(ref List<MyFile> files)
        {
            files.Sort(new MyFileWordsComparer());
        }

        
    }
}
