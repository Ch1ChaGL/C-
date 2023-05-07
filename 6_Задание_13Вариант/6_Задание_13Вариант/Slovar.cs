using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Задание_13Вариант
{
    public class Slovar
    {
        private bool isMySlovar = false;
        public string fileName;
        public List<string> words = new List<string>();
        string filePath;
        public Slovar(string dataPath, string fileName) 
        {
            this.fileName = fileName;
            OpenFile(dataPath, fileName);
        }
        public Slovar(string dataPath, string fileName, bool isMySlovar)
        {
            this.fileName = fileName;
            this.isMySlovar = isMySlovar;
            OpenFile(dataPath, fileName);
        }
        private void OpenFile(string dataPath, string fileName)
        {
            filePath = Path.Combine(dataPath, fileName);
            try
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        words.Add(line);
                    }
                }
            }
            catch
            {
                throw new Exception("Ошибка доступа к файлу");
            }
        }

        public void addWords(string Word)
        {
            if (words.Contains(Word.Trim().ToLower())) { MessageBox.Show("Слово уже добавлено"); return; }
            int index = words.BinarySearch(Word);
            if (index < 0)
            {
                // Индекс, возвращаемый методом BinarySearch, может быть отрицательным,
                // если элемент не найден в списке. В этом случае нужно вставить элемент
                // на позицию, указанную возвращаемым индексом с обратным знаком.
                index = ~index;
            }
            words.Insert(index, Word.ToLower());
        }

        public void save()
        {

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(string.Join("\n", words));
            }

        }

        public void unload()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.WriteLine(string.Join("\n", words));
                }
            }
        }

        public void sort()
        {
            words.Sort();
        }

        public void deleteWords(string Word)
        {
            words.Remove(Word.Trim().ToLower());
        }

        public List<string> see(string substring)
        {
            List<string> newWords = new List<string>();
            int index = words.FindIndex(word => word.StartsWith(substring.ToLower()));

            if (index != -1)
            {
                int diapazon = 10_000;
                if(words.Count - index < diapazon)
                {
                    diapazon = words.Count - index;
                }
                newWords = words.GetRange(index, diapazon);
            }
            return newWords;
        }

        /// <summary>
        /// Список слов подходящих под расстояние Левенштайна = 3
        /// </summary>
        /// <param name="substring">Искомая подстрока</param>
        /// <returns></returns>
        public List<string> search(string substring)
        {
            List<string> foundWords = new List<string>();
            foreach (string word in words)
            {
                int distance = calculateLevenshteinDistance(substring.ToLower(), word);
                if (distance <= 3)
                {
                    foundWords.Add(word);
                }
            }
            var sortedWordsList = foundWords.OrderBy(word => calculateLevenshteinDistance(word, substring.ToLower()));

            return sortedWordsList.ToList();
        }

        private int levDistance(int i, int j, string s1, string s2, int[,] matrix)
        {
            if (i == 0 && j == 0) return 0;
            else if (j == 0 && i > 0) return i;
            else if (i == 0 && j > 0) return j;
            else
            {
                var m = s1[i-1] == s2[j-1] ? 0 : 1;
                return Math.Min(Math.Min(matrix[i, j - 1] + 1, matrix[i - 1, j] + 1), matrix[i - 1, j - 1] + m);
            }
        }
        /// <summary>
        /// Нахождения длины левенштейна
        /// </summary>
        /// <param name="s1">Слово 1</param>
        /// <param name="s2">Слово 2</param>
        /// <returns></returns>
        private int calculateLevenshteinDistance(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            int[,] matrix = new int[n+1,m+1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    matrix[i, j] = levDistance(i, j, s1, s2, matrix);
                }
            }

            return matrix[n, m];
        }



        public List<string> searchConsonants(int count, int where)
        {   
            List<string> list = new List<string>();
            string consonants = "бвгджзйклмнпрстфхцчшщ";
            int countSearch = 0;
            if (where == 0)
            {
                foreach (var word in words)
                {
                    countSearch = 0;
                    foreach (var letter in word)
                    {
                        if (consonants.Contains(letter))
                        {
                            countSearch++;
                            if (countSearch == count)
                            {
                                list.Add(word);
                                break;
                            }
                        }
                        else break;
                    }
                    
                }
                return list;
            }
            else if(where == 1)
            {
                foreach (var word in words)
                {
                    countSearch = 0;
                    foreach (var letter in word.Reverse())
                    {
                        if (consonants.Contains(letter))
                        {
                            countSearch++;
                            if (countSearch == count)
                            {
                                list.Add(word);
                                break;
                            }
                        }
                        else break;
                    }                  
                }
                return list;
            }
            throw new Exception("Направление выбрано не верно");
        }
    }
}
