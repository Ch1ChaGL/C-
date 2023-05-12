using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _7_Задание_13Вариант.ComputerGame;

namespace _7_Задание_13Вариант
{
    public partial class Form2 : Form
    {
        string fileName = "games.dat";
        
        public void updateDataGridView(List<ComputerGame> gameList = null)
        {
            if(gameList == null)
                gameList = ComputerGame.LoadFromBinaryFile(fileName);
            // создание таблицы
            DataTable table = new DataTable();
            table.Columns.Add("Название");
            table.Columns.Add("Жанр игры");
            table.Columns.Add("Объем памяти");
            table.Columns.Add("Частота CPU");

            // добавление данных из List<ComputerGame> в таблицу
            foreach (ComputerGame game in gameList)
            {
                DataRow row = table.NewRow();
                row["Название"] = game.name;
                row["Жанр игры"] = game.gameType.ToString();
                row["Объем памяти"] = game.Memory;
                row["Частота CPU"] = game.CPU;
                table.Rows.Add(row);
            }

            // установка таблицы в DataGridView
            dataGridView1.DataSource = table;

            // установка названий колонок
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Жанр игры";
            dataGridView1.Columns[2].HeaderText = "Объем памяти";
            dataGridView1.Columns[3].HeaderText = "Частота CPU";
        }

        public Form2()
        {
            InitializeComponent();
            updateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = gameName.Text;

            for (int i = name.Length; i < 20; i++)
            {
                name += " ";
            }
            if (!ComputerGame.DeleteRecord(fileName, ComputerGame.FindByName(fileName, name))) MessageBox.Show("Такой игры нет");
            updateDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                string gameType = row.Cells[1].Value.ToString();
                double Memory = double.Parse(row.Cells[2].Value.ToString());
                double CPU = double.Parse(row.Cells[3].Value.ToString());

                Form1 f = (Form1)Owner;
                f.NameGame = name;
                f.type = gameType;
                f.Mem= Memory;
                f.CPU= CPU; 
            }
        }

        private void byCPU_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var list = LoadFromBinaryFile(fileName);
            if (rb.Name == "byName")
            {
                list.Sort(new SortByName());
            }
            if(rb.Name == "byGenre")
            {
                list.Sort(new SortByGenre());
            }
            if(rb.Name == "byMemory")
            {
                list.Sort(new SortByMemory());
            }
            if(rb.Name == "byCPU")
            {
                list.Sort(new SortByCPU());
            }
            updateDataGridView(list);
        }

        private void searchByGenre_Click(object sender, EventArgs e)
        {
 
            GameType gameType;
            if (genre.Text == "RPG")
                gameType = GameType.RPG;
            else if (genre.Text == "Shooter")
                gameType = GameType.Shooter;
            else if (genre.Text == "Simulator")
                gameType = GameType.Simulator;
            else gameType = GameType.Strategy;

            var listPosition = FindByGameType(fileName, gameType);

            var list = ReadGamesFromFile(fileName,listPosition);

            updateDataGridView(list);   
        }

        private void searchByName_Click(object sender, EventArgs e)
        {

            var name = gameName.Text;
            for (int i = name.Length; i < 20; i++)
            {
                name += " ";
            }
            var list = ReadGamesFromFile(fileName, FindByName(fileName, name));
            updateDataGridView(list);
         
        }

        private void searchByMemory_Click(object sender, EventArgs e)
        {
            double start = double.Parse(startMemory.Text);
            double end = double.Parse(endMemory.Text);

            var listPosition = FindByMemoryDiapazon(fileName, start, end);

            var list = ReadGamesFromFile(fileName, listPosition);
            updateDataGridView(list);
        }

        private void searchByCPU_Click(object sender, EventArgs e)
        {
            double start = double.Parse(startCPU.Text);
            double end = double.Parse(endCPU.Text);

            var listPosition = FindByCPUDiapazon(fileName, start, end);

            var list = ReadGamesFromFile(fileName, listPosition);
            updateDataGridView(list);
        }
    }
}
