using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BotanicalLotto
{
    public partial class Game : Form
    {
        Form menu1;
        double totalQuestions = 10;
        double countQuestion = 0;
        double countTrueQuestion = 0;
        string state = "";
        Random rnd = new Random();
        int answer = 0;
        int min = 0;
        int sec = 0;
        List<string> plantNames =  new List<string>();
        string aPath;
        public Game(Form menu)
        {   
            menu1 = menu;
            InitializeComponent();
            FindImages();
            generateQuestion();
            timer1.Start();
        }

        private void Game_Load(object sender, EventArgs e)
        {

            
        }
        private void FindImages()
        {   plantNames.Clear();
            groupBox1.Visible = false;
            aPath = Application.StartupPath + "\\Images\\";  //путь к изображениям
            DirectoryInfo di = new DirectoryInfo(aPath);   // получение директории
            FileInfo[] fi = di.GetFiles("*.jpg");  // поиск графических файлов
            foreach(FileInfo fc in fi)                                      // foreach (FileInfo fc in fi)
            {
                int x = fc.Name.IndexOf('.');
                string s = fc.Name.Remove(x, fc.Name.Length - x);// обрежем имя файла до точки
                plantNames.Add(s);    // добавление имён файлов в список
            }
        }

        private void CalculationOfResults()
        {
            timer1.Stop();
            if (countTrueQuestion != 0)
            {
                double a = Properties.Settings.Default.record2;
                if (Properties.Settings.Default.record2 < (countTrueQuestion / totalQuestions))
                {
                    Properties.Settings.Default.record2 = countTrueQuestion / totalQuestions;
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show($"Ваш текущий результат {((countTrueQuestion / totalQuestions) * 100)}%\n" +
                    $"Ваш лучший результат {Properties.Settings.Default.record2 * 100}% ");
                Close();
            }
            else
            {
                MessageBox.Show($"Ваш текущий результат {0} " +
                   $"Ваш лучший результат {Properties.Settings.Default.record2 * 100}%");
                Close();
            }

        }
        private void generateQuestion()
        {   
            Shuffle(plantNames);
            var colection = groupBox1.Controls;
            colection.Owner.Visible = true;
            for (int i = 0; i < colection.Count; i++)
            {
                colection[i].Text = plantNames[i];
                colection[i].Visible = true;
            }
            answer = rnd.Next(colection.Count);
            Question.Text = $"Что это за цветок";
            var fileName = colection[answer].Text + ".jpg";
            pictureBox1.Image = new Bitmap(aPath + fileName);

        }



        private void Shuffle<T>(List<T> list)
        {
            Random rand = new Random();

            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1;      
            if (sec == 60)
            {
                min += 1;
                sec = 0;
            }
            TimerText.Text = $"Игра идет {min} мин и {sec} сек";
            if (min == 1) { timer1.Stop(); CalculationOfResults(); }
        }

        private void Next_click(object sender, EventArgs e)
        {
            var colection = groupBox1.Controls;
            countQuestion += 1;
            for (int i = 0; i< colection.Count; i++)
            {
                if(((System.Windows.Forms.RadioButton)colection[i]).Checked == true)
                {
                    if (i == answer) { state = "Правильно"; countTrueQuestion += 1; }
                    else state = "Неправильно";
                    break;
                }
                state = "Неправильно";
            }
            if(state == "Правильно") { State.ForeColor = Color.Green; State.Text = state; }
            else { State.ForeColor = Color.Red; State.Text = state; }
            
            if(countQuestion == totalQuestions)            
                CalculationOfResults();
            else
                generateQuestion();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu1.Visible = true;
        }
    }
}

