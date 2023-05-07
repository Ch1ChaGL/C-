using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        long count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        string mainVocabularyName = "russian.txt";
        List<string> txtFiles = new List<string>();
        List<Slovar> slovars = new List<Slovar>();
        string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        Slovar currentSlovar;
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var file in Directory.GetFiles(dataPath, "*.txt"))
            {
                txtFiles.Add(Path.GetFileName(file));
                listDict.Items.Add(Path.GetFileName(file));
                slovars.Add(new Slovar(dataPath, Path.GetFileName(file)));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < slovars.Count; i++)
            {
                if (slovars[i].fileName == listDict.Text)
                {
                    currentSlovar = slovars[i];
                    break;
                }
            }

            countWords.Text = $"Количество слов: {currentSlovar.words.Count}";

        }

        private void add_Click(object sender, EventArgs e)
        {
            currentSlovar.addWords(Word.Text);
            countWords.Text = $"Количество слов: {currentSlovar.words.Count}";
        }

        private void save_Click(object sender, EventArgs e)
        {
            currentSlovar.save();
        }

        private void unLoad_Click(object sender, EventArgs e)
        {
            currentSlovar.unload();
        }

        private void del_Click(object sender, EventArgs e)
        {
            currentSlovar.deleteWords(Word.Text);
            countWords.Text = $"Количество слов: {currentSlovar.words.Count}";
        }

        private void see_Click(object sender, EventArgs e)
        {
            wordsList.Items.Clear();
            var output = currentSlovar.see(Word.Text);
            foreach (var word in output)
            {
                wordsList.Items.Add(word);
            }
            
        }

        private void search_Click(object sender, EventArgs e)
        {
           var list =  currentSlovar.search(Word.Text);
            wordsList.Items.Clear();
            foreach (var word in list)
            {
                wordsList.Items.Add(word);
            }
        }

        private void zadanie_Click(object sender, EventArgs e)
        {
            var list = currentSlovar.searchConsonants(int.Parse(CountConsonants.Text), where.SelectedIndex);
            listZadanie.Items.Clear();
            foreach(var consonant in list)
            {
                listZadanie.Items.Add(consonant);
            }
            toolStripStatusLabel1.Text = $"Количество найденных слов: {list.Count}";

        }
    }
}
