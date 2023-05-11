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

        private void SaveFile_Click(object sender, EventArgs e)
        {
            ComputerGame computerGame = new ComputerGame("CS GO", GameType.Shooter, 100, 10);
            ComputerGame computerGame1 = new ComputerGame("Dota 2", GameType.RPG, 1000, 1000);
            computerGame1.SaveResult("games.dat");

            computerGame.CPU = 100;
            string game_name = "CS GO";
            for (int i = game_name.Length; i < 20; i++)
            {
                game_name += " ";
            }
            computerGame.CorrectResult("games.dat", ComputerGame.FindByName("games.dat", game_name));
            
        }

        private void View_Click(object sender, EventArgs e)
        {
            var game = ComputerGame.LoadFromBinaryFile("games.dat");

            MessageBox.Show(game[1].name + game[1].gameType.ToString() + game[1].CPU.ToString() + game[1].Memory.ToString());
        }
    }
}
