using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BotanicalLotto
{
    public partial class Game : Form
    {
        string fileName;
        double totalQuestions = 10;
        double countQuestion = 0;
        double countTrueQuestion = 0;
        string state = "";
        Random rnd = new Random();
        int answer = 0;
        int min = 0;
        int sec = 0;
        private List<string> plantNames = new List<string>();
        private List<string> questionList = new List<string>();
        string aPath;
        public Game()
        {
            InitializeComponent();
            FindImages();
            generateQuestionList();
            generateQuestion();
            timer1.Start();
        }

        private void generateQuestionList()
        {
            Shuffle(plantNames);
            for (int i = 0; i< totalQuestions; i++)
            {
                questionList.Add(plantNames[i]);
            }
            Shuffle(questionList);
        }

        private void FindImages()
        {
            plantNames.Clear();
            groupBox1.Visible = false;
            aPath = Application.StartupPath + "\\Images\\";  //путь к изображениям
            DirectoryInfo di = new DirectoryInfo(aPath);   // получение директории
            FileInfo[] fi = di.GetFiles("*.jpg");  // поиск графических файлов
            foreach (FileInfo fc in fi)                                      // foreach (FileInfo fc in fi)
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
            var colection = groupBox1.Controls;

 

            string answerText = questionList.First();
            questionList.RemoveAt(0);

            plantNames.RemoveAt(plantNames.IndexOf(answerText));
            answer = rnd.Next(colection.Count);

            Shuffle(plantNames);
            colection.Owner.Visible = true;


            for (int i = 0; i < colection.Count; i++)
            {
                if (i == answer)
                {
                    colection[i].Text = answerText;
                    colection[i].Visible = true;
                }
                else
                {
                    colection[i].Text = plantNames[i];
                    colection[i].Visible = true;
                }
            }

            plantNames.Add(answerText);
            Question.Text = $"Что это за цветок";
            fileName = colection[answer].Text;
            pictureBox1.Image = new Bitmap(aPath + fileName + ".jpg");

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
            if (min == 3) { timer1.Stop(); CalculationOfResults(); }
        }

        private void Next_click(object sender, EventArgs e)
        {
            var colection = groupBox1.Controls;
            countQuestion += 1;
            StateCheck(colection);
            if (countQuestion == totalQuestions)
                CalculationOfResults();
            else
                generateQuestion();
        }
        private void StateCheck(Control.ControlCollection colection)
        {
            for (int i = 0; i < colection.Count; i++)
            {
                if (((System.Windows.Forms.RadioButton)colection[i]).Checked == true)
                {
                    if (i == answer) { state = "Правильно"; countTrueQuestion += 1; }
                    else state = "Неправильно";
                    break;
                }
                state = "Неправильно";
            }
            if (state == "Правильно") { State.ForeColor = Color.Green; State.Text = state; }
            else { State.ForeColor = Color.Red; State.Text = state; }
        }
        private void Skip_Click(object sender, EventArgs e)
        {
            countQuestion += 1;
            if (countQuestion == totalQuestions)
                CalculationOfResults();
            else
                generateQuestion();
        }      

        private void hint_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(Application.StartupPath + $"\\Hint\\{fileName}.txt", Encoding.UTF8);
                hintText.Text = sr.ReadToEnd();
            }
            catch (Exception err)
            {
                hintText.Text = err.Message;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void hint_MouseUp(object sender, MouseEventArgs e)
        {
            hintText.Text = "";
        }
    }
}
