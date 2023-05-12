using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string NameGame
        {
            set
            {
                gameName.Text = value;
            }
        }
        public string type
        {
            set { TypeGame.Text = value; }
        }
        public double CPU
        {
            set => CPUsize.Text = value.ToString();
        }
        public double Mem
        {
            set => MemorySize.Text = value.ToString(); 
        }



        string fileName = "games.dat";
        Form2 form2 = new Form2();
        private void SaveFile_Click(object sender, EventArgs e)
        {
            string typeGame = TypeGame.Text;
            GameType gameType = GameType.RPG;
            if (typeGame == "RPG")
                gameType = GameType.RPG;
            if (typeGame == "Shooter")
                gameType = GameType.Shooter;
            if (typeGame == "Simulator")
                gameType = GameType.Simulator;
            if (typeGame == "Strategy")
                gameType = GameType.Strategy;
            string name = gameName.Text;
            for (int i = gameName.Text.Length; i < 20; i++)
            {
                name += " ";                
            }
            var pos = ComputerGame.FindByName(fileName, name);

            var game = new ComputerGame(gameName.Text, gameType, double.Parse(MemorySize.Text), double.Parse(CPUsize.Text));
            
            if (pos >= 0)
            {
                game.CorrectResult(fileName,pos);
            }
            else
            {
                game.SaveResult(fileName);
            }
            form2.updateDataGridView();
        }

        private void View_Click(object sender, EventArgs e)
        {

            form2 = new Form2();
            form2.Owner = this;
            form2.Show();

            //var game = ComputerGame.LoadFromBinaryFile(fileName);

            //MessageBox.Show(game[1].name + game[1].gameType.ToString() + game[1].CPU.ToString() + game[1].Memory.ToString());
        }
    }
}
