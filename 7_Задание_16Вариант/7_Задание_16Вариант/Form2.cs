using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Задание_16Вариант
{
    public partial class Form2 : Form
    {
        string fileName = "hospitals.dat";
        public Form2()
        {
            InitializeComponent();
            updateDataGridView();
        }
        public void updateDataGridView(List<Hospital> HospitalList = null)
        {
            if (HospitalList == null)
                HospitalList = Hospital.LoadFromBinaryFile(fileName);
            // создание таблицы
            DataTable table = new DataTable();
            table.Columns.Add("ФИО");
            table.Columns.Add("День рождения");
            table.Columns.Add("День визита");
            table.Columns.Add("Диагноз");
            table.Columns.Add("Номер отделения");
            // добавление данных из List<ComputerGame> в таблицу
            foreach (Hospital hospital in HospitalList)
            {
                DataRow row = table.NewRow();
                row["ФИО"] = hospital.fullname;
                row["День рождения"] = hospital.birthday.ToString();
                row["День визита"] = hospital.vizitHospital.ToString();
                row["Диагноз"] = hospital.diagnoz;
                row["Номер отделения"] = hospital.unitNumber;
                table.Rows.Add(row);
            }

            // установка таблицы в DataGridView
            dataGridView1.DataSource = table;

            // установка названий колонок
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "День рождения";
            dataGridView1.Columns[2].HeaderText = "День визита";
            dataGridView1.Columns[3].HeaderText = "Диагноз";
            dataGridView1.Columns[4].HeaderText = "Номер отделения";
        }

        private void byFullName_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var list = Hospital.LoadFromBinaryFile(fileName);
            if (rb.Name == "byFullName")
            {
                list.Sort(new Hospital.SortByFullName());
            }
            if (rb.Name == "byBirthday")
            {
                list.Sort(new Hospital.SortByBirthDay());
            }
            if (rb.Name == "byVizit")
            {
                list.Sort(new Hospital.SortByVizit());
            }
            if (rb.Name == "byUnitId")
            {
                list.Sort(new Hospital.SortByUnitNumber());
            }
            updateDataGridView(list);
        }

        private void searchByFullName_Click(object sender, EventArgs e)
        {
            try
            {
                var name = fullName.Text;
                for (int i = name.Length; i < 40; i++)
                {
                    name += " ";
                }
                var list = Hospital.ReadGamesFromFile(fileName, Hospital.FindByName(fileName, name));
                updateDataGridView(list);
            }
            catch
            {
                MessageBox.Show("Поиск не дал результатов");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = fullName.Text;

            for (int i = name.Length; i < 40; i++)
            {
                name += " ";
            }
            if (!Hospital.DeleteRecord(fileName, Hospital.FindByName(fileName, name))) MessageBox.Show("Такого пациента нет");
            updateDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string fullname = row.Cells[0].Value.ToString();
                DateTime birthday = DateTime.Parse(row.Cells[1].Value.ToString());
                DateTime vizit = DateTime.Parse(row.Cells[2].Value.ToString()); 
                string diagnoz = row.Cells[3].Value.ToString();
                int unitId = int.Parse(row.Cells[4].Value.ToString());

                Form1 f = (Form1)Owner;
                f.FullName = fullname;
                f.Birthday = birthday;
                f.VizitDay = vizit;
                f.Diagnoz = diagnoz;
                f.Unit = unitId;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var start = dateTimePicker1.Value;
                var end = dateTimePicker2.Value;
               
                var list = Hospital.ReadGamesFromFile(fileName, Hospital.FindByBithdayDiapazon(fileName, start, end));
                updateDataGridView(list);
            }
            catch
            {
                MessageBox.Show("Поиск не дал результатов");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var start = dateTimePicker3.Value;
                var end = dateTimePicker4.Value;

                var list = Hospital.ReadGamesFromFile(fileName, Hospital.FindByVizitDiapazon(fileName, start, end));
                updateDataGridView(list);
            }
            catch
            {
                MessageBox.Show("Поиск не дал результатов");
            }
        }
    }
}
