using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
                //cmb.Items.Clear();
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

        private void LoadDataToComboboxPorts(string q, ComboBox cmb)
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
                cmb.DisplayMember = "DestinationPortName"; // значения для вывода
                cmb.ValueMember = "DestinationPortID";   // фактические значения
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

        public void updatePictureBox2(int typeId)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = SQLstring.GetImageType(typeId);
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
                LoadDataToComboboxPorts(SQLstring.GetNamePorts, airport);
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
                airplaneNumber.Text = PlaneId.ToString();

                updatePictureBox(FlightID);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int FlightID = int.Parse(raceNumber.Text);
                int PlaneId = int.Parse(airplaneNumber.Text);
                int NumberOfSeats = int.Parse(countPasanger.Text);

                int PlaneType = (int)airplaneType.SelectedValue;

                int DestinationPortId = (int)airport.SelectedValue;

                DateTime DepartureDate = dateStart.Value.Date;
                string DepartureTime = timeStart.Text;
                DateTime TimeD = DateTime.ParseExact(DepartureTime, "HH:mm", CultureInfo.InvariantCulture);
                int hoursD = TimeD.Hour;
                int minutesD = TimeD.Minute;
                DateTime DepartureDateTime = new DateTime(DepartureDate.Year, DepartureDate.Month, DepartureDate.Day, hoursD, minutesD, 0);
               
                DateTime ArrivalDate = dateEnd.Value.Date;
                string ArrivalTime = timeEnd.Text;
                DateTime TimeA = DateTime.ParseExact(ArrivalTime, "HH:mm", CultureInfo.InvariantCulture);
                int hoursA = TimeA.Hour;
                int minutesA = TimeA.Minute;
                DateTime ArrivalDateTime = new DateTime(ArrivalDate.Year, ArrivalDate.Month, ArrivalDate.Day, hoursA, minutesA, 0);

                int FlightFrequencyId = (int)periodicity.SelectedValue;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand(SQLstring.addFlight(FlightID, PlaneId, PlaneType,
                        DestinationPortId, DepartureDateTime, ArrivalDateTime, FlightFrequencyId), connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
            LoadData(SQLstring.getAll, dataGridView1);
        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                int FlightID = int.Parse(raceNumber.Text);
                int PlaneId = int.Parse(airplaneNumber.Text);
                int NumberOfSeats = int.Parse(countPasanger.Text);

                int PlaneType = (int)airplaneType.SelectedValue;

                int DestinationPortId = (int)airport.SelectedValue;

                DateTime DepartureDate = dateStart.Value.Date;
                string DepartureTime = timeStart.Text;
                DateTime TimeD = DateTime.ParseExact(DepartureTime, "HH:mm", CultureInfo.InvariantCulture);
                int hoursD = TimeD.Hour;
                int minutesD = TimeD.Minute;
                DateTime DepartureDateTime = new DateTime(DepartureDate.Year, DepartureDate.Month, DepartureDate.Day, hoursD, minutesD, 0);

                DateTime ArrivalDate = dateEnd.Value.Date;
                string ArrivalTime = timeEnd.Text;
                DateTime TimeA = DateTime.ParseExact(ArrivalTime, "HH:mm", CultureInfo.InvariantCulture);
                int hoursA = TimeA.Hour;
                int minutesA = TimeA.Minute;
                DateTime ArrivalDateTime = new DateTime(ArrivalDate.Year, ArrivalDate.Month, ArrivalDate.Day, hoursA, minutesA, 0);

                int FlightFrequencyId = (int)periodicity.SelectedValue;


                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand(SQLstring.updateFlight(FlightID, PlaneId, PlaneType, 
                        DestinationPortId, DepartureDateTime, ArrivalDateTime, FlightFrequencyId), connection)) 
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData(SQLstring.getAll, dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            airplaneType.SelectedIndexChanged += airplaneType_SelectedIndexChanged;
        }

        private void airplaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int PlaneType =airplaneType.SelectedValue == null ? 1 : (int)airplaneType.SelectedValue;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand($"select NumberOfSeats from PlaneTypes where PlaneTypeId = {PlaneType}", connection))
                    {
                        connection.Open();
                        var res = command.ExecuteScalar();

                        countPasanger.Text = res.ToString();
                    }
                    updatePictureBox2(PlaneType);
                }
            }
            catch(Exception ex) 
            {

            }
            
        }

        private void del_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand($"select * from Flights where FlightID = {int.Parse(raceNumber.Text)} ", connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (!reader.HasRows) throw new Exception("Данный рейс отсутсвует");
                    }
                }
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand($"delete from Flights where FlightID = {int.Parse(raceNumber.Text)} ", connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData(SQLstring.getAll, dataGridView1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            LoadData(SQLstring.getAll, dataGridView1);
        }

        private void search_Click(object sender, EventArgs e)
        {

            int FlightID = int.Parse(raceNumber.Text);
            int PlaneId = int.Parse(airplaneNumber.Text);
            int NumberOfSeats = int.Parse(countPasanger.Text);

            int PlaneType = (int)airplaneType.SelectedValue;

            int DestinationPortId = (int)airport.SelectedValue;

            DateTime DepartureDate = dateStart.Value.Date;
            string DepartureTime = timeStart.Text;
            DateTime TimeD = DateTime.ParseExact(DepartureTime, "HH:mm", CultureInfo.InvariantCulture);
            int hoursD = TimeD.Hour;
            int minutesD = TimeD.Minute;
            DateTime DepartureDateTime = new DateTime(DepartureDate.Year, DepartureDate.Month, DepartureDate.Day, hoursD, minutesD, 0);

            DateTime ArrivalDate = dateEnd.Value.Date;
            string ArrivalTime = timeEnd.Text;
            DateTime TimeA = DateTime.ParseExact(ArrivalTime, "HH:mm", CultureInfo.InvariantCulture);
            int hoursA = TimeA.Hour;
            int minutesA = TimeA.Minute;
            DateTime ArrivalDateTime = new DateTime(ArrivalDate.Year, ArrivalDate.Month, ArrivalDate.Day, hoursA, minutesA, 0);

            int FlightFrequencyId = (int)periodicity.SelectedValue;


            DataTable dt = new DataTable();
            dt = searchFn(SQLstring.getAllOne(FlightID, PlaneId, DestinationPortId, DepartureDateTime, ArrivalDateTime, FlightFrequencyId), dt);
            dt = searchFn(SQLstring.getAllSeven(FlightID), dt);
            dt = searchFn(SQLstring.getAllTwo(PlaneId, DestinationPortId, DepartureDateTime, ArrivalDateTime, FlightFrequencyId), dt);
            dt = searchFn(SQLstring.getAllTrhee(PlaneId), dt);
            dt = searchFn(SQLstring.getAllFour(DepartureDateTime, ArrivalDateTime), dt);
            dt = searchFn(SQLstring.getAllFive(DepartureDateTime), dt);
            dt = searchFn(SQLstring.getAllFive(ArrivalDate), dt);

            // представление для DataTable
            DataView view = new DataView(dt);

            // свойство Distinct, чтобы удалить дублирующиеся строки
            DataTable distinctTable = view.ToTable(true);

            dataGridView1.DataSource = distinctTable;
            dataGridView1.Refresh();
        }


        public DataTable searchFn(string sql, DataTable dataTable)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

           
        }

        private void newTypeAirplane_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            Visible = false;
            form.ShowDialog();
            Visible = true;
            LoadDataToComboboxAirplaneType(SQLstring.GetInfoQueryPlaneTypes, airplaneType);
        }

        private void airplaneType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
