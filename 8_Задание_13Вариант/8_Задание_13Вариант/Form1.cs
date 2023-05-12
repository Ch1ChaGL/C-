using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _8_Задание_13Вариант.FlightFrequency;
using static _8_Задание_13Вариант.PlaneTypes;

namespace _8_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\Практика c#\\8_Задание_13Вариант\\8_Задание_13Вариант\\Airport.mdf\";Integrated Security=True;Connect Timeout=30";
        private void LoadDataToComboboxAirplaneType(string q, ComboBox cmb)
        {
            try
            {
                cmb.Items.Clear();
                SqlConnection myConnection = new SqlConnection(connString);
                // создание соединения с БД
                myConnection.Open();    // открываем соединение
                SqlCommand cmd = new SqlCommand(q, myConnection);
                // создание SQL команды с запросом
                SqlDataAdapter da = new SqlDataAdapter(cmd);    // выполнение команды
                DataTable tb = new DataTable(); // создание таблицы
                da.Fill(tb);        // загрузка данных в таблицу
                cmb.DataSource = tb;  // привязка полученной таблицы к компоненту comboBox1
                cmb.DisplayMember = "PlaneTypeName"; // значения для вывода
                cmb.ValueMember = "PlaneTypeID";   // фактические значения
                cmb.SelectedIndex = -1;
                myConnection.Close(); // разрываем соединение с БД
            }
            catch
            {
                MessageBox.Show("Список категорий загрузить не удалось!");
            }
        }
        private void LoadDataToComboboxPeriodicity(string q, ComboBox cmb)
        {
            try
            {
                cmb.Items.Clear();
                SqlConnection myConnection = new SqlConnection(connString);
                // создание соединения с БД
                myConnection.Open();    // открываем соединение
                SqlCommand cmd = new SqlCommand(q, myConnection);
                // создание SQL команды с запросом
                SqlDataAdapter da = new SqlDataAdapter(cmd);    // выполнение команды
                DataTable tb = new DataTable(); // создание таблицы
                da.Fill(tb);        // загрузка данных в таблицу
                cmb.DataSource = tb;  // привязка полученной таблицы к компоненту comboBox1
                cmb.DisplayMember = "FlightFrequency"; // значения для вывода
                cmb.ValueMember = "FlightFrequencyId";   // фактические значения
                cmb.SelectedIndex = -1;
                myConnection.Close(); // разрываем соединение с БД
            }
            catch
            {
                MessageBox.Show("Список категорий загрузить не удалось!");
            }
        }



        private void LoadData(string q, DataGridView dgv)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(connString);
                myConnection.Open();    //Открываем соединение
                SqlCommand cmd = new SqlCommand(q, myConnection);
                // создание SQL команды с запросом
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // выполнение команды
                DataTable tb = new DataTable(); // создание таблицы
                da.Fill(tb);    // загрузка данных в таблицу
                dgv.DataSource = tb;  // привязка полученной таблицы к компоненту
                this.ActiveControl = dgv;   // активация компонента таблица
                //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //if (dgv.Rows.Count > 0)
                //{
                //    dgv.Rows[0].Selected = true;
                //}
                myConnection.Close(); // разрываем соединение с БД
            }
            catch
            {
                MessageBox.Show("Данные не найдены!");
            }
        }

        public void updatePictureBox(int id)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = SQLstring.GetImageTypeAirplane(id);
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    byte[] imageBytes = (byte[])command.ExecuteScalar();
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        public Form1()
        {
            InitializeComponent();

            try
            {
                LoadDataToComboboxAirplaneType(SQLstring.GetInfoQueryPlaneTypes, airplaneType);
                LoadDataToComboboxPeriodicity(SQLstring.GetNameFlightFrequency, periodicity);
                LoadData(SQLstring.getAll, dataGridView1);
            }
            catch
            {
                MessageBox.Show("Конекшона не было");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int FlightID = int.Parse(row.Cells[0].Value.ToString());
                int PlaneId = int.Parse( row.Cells[1].Value.ToString());
                int NumberOfSeats = int.Parse(row.Cells[2].Value.ToString());

                string PlaneTypeName = row.Cells[3].Value.ToString();
                string DestinationPortName = row.Cells[4].Value.ToString();

                DateTime DepartureTime = DateTime.Parse(row.Cells[5].Value.ToString());
                DateTime ArrivalTime = DateTime.Parse(row.Cells[6].Value.ToString());

                double FlightDuration = double.Parse(row.Cells[7].Value.ToString());
                string FlightFrequency = row.Cells[8].Value.ToString();


                raceNumber.Text = FlightID.ToString();
                raceNumber2.Text = FlightID.ToString();

                airplaneType.Text = PlaneTypeName;

                countPasanger.Text = NumberOfSeats.ToString();

                airport.Text = DestinationPortName.ToString();

                dateStart.Text = DepartureTime.ToString();
                dateEnd.Text = ArrivalTime.ToString();

                timeStart.Text = DepartureTime.TimeOfDay.ToString();
                timeEnd.Text = ArrivalTime.TimeOfDay.ToString();

                periodicity.Text = FlightFrequency.ToString();

                updatePictureBox(FlightID);
            }
        }
    }
}
