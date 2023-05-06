using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _5_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        List<City> сities = new List<City>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("district", "Название района:");
            dataGridView1.Columns.Add("people", "Число человек:");
            dataGridView1.Columns.Add("area", "Площадь населения км^2:");
            dataGridView1.Columns.Add("populationDensity", "Плотность населения:");
            chart1.Series.Clear();
        }
        string СityName { get { return cityName.Text; } }
        string DistrictName {  get { return districtName.Text; } }
        int countPeople { get { return int.Parse(countPeopleTbx.Text); } }
        double areaDistrict { get { return double.Parse(areaTxb.Text); } }

        private void addInformation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < сities.Count; i++)
            {
                if (сities[i].Name == СityName)
                {
                    
                        if(countPeopleTbx.Text == "" || areaTxb.Text == "") { MessageBox.Show("Отсутвует количество людей или площадь");  return; }
                        сities[i].addinformation(DistrictName, countPeople, areaDistrict);
                        districtName.Items.Add(DistrictName);
                        
                        return;
                   
                    

                }
            }
            if (СityName == "") { MessageBox.Show("Город не введен, куда ты хочешь добавить район"); return; }
            City sity = new City(СityName);
            сities.Add(sity);
            cityName.Items.Add(sity.Name);
            cityTableComboBox.Items.Add(sity.Name);
            cityDiagramComboBox.Items.Add(sity.Name);
            if (DistrictName == "") return;
            sity.addinformation(DistrictName,countPeople, areaDistrict);
            districtName.Items.Add(DistrictName);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(dataPath, "cities.txt");

            File.WriteAllText(filePath, string.Empty);

            // Создаем папку Data, если ее нет
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }


            // Записываем список городов в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (City city in сities)
                {
                    writer.WriteLine(city.GetInformationAboutCity()); 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(dataPath, "cities.txt");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                City сity = new City("Город без названия");
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Название города:"))
                    {
                        сity = new City(Name = line.Substring(17));
                        line = reader.ReadLine();
                        сities.Add(сity);
                    }
                    else if (line.StartsWith("Название района:"))
                    {
                        // Получаем название района
                        string districtName = line.Substring(17);

                        //Площадь района
                        line = reader.ReadLine();
                        double area = double.Parse(line.Substring(15));

                        //Количество людей
                        line = reader.ReadLine();
                        int countPeople = int.Parse(line.Substring(18));

                        сity.AddRegion(districtName, area, countPeople);
                    }
                }
            }


            foreach(var city in сities)
            {
                cityName.Items.Add(city.Name);
                cityTableComboBox.Items.Add(city.Name);
                cityDiagramComboBox.Items.Add(city.Name);
            }
        }

        private void cityName_SelectedIndexChanged(object sender, EventArgs e)
        {

            City city = null;
            districtName.Items.Clear();
            districtName.Text = "";
            foreach(var item in сities)
            {
                if(item.Name == СityName)
                {
                    city = item;
                }
            }
            if (city == null) return;
            foreach (var item in city.region) 
            {
                districtName.Items.Add(item.Name);
            }
        }

        private void cityName_TextChanged(object sender, EventArgs e)
        {
            districtName.Text = "";
            districtName.Items.Clear();
        }

        private void districtName_SelectedIndexChanged(object sender, EventArgs e)
        {
            City city = null;
            foreach (var item in сities)
            {
                if (item.Name == СityName)
                {
                    city = item;
                }
            }
            if (city == null) return;
            foreach (var item in city.region)
            {
               if(item.Name == DistrictName)
               {
                    countPeopleTbx.Text = item.countPeople.ToString();
                    areaTxb.Text = item.Area.ToString();
               }
            }
        }

        private void districtName_TextChanged(object sender, EventArgs e)
        {
            countPeopleTbx.Text = "";
            areaTxb.Text = "";
        }

        private void deleteDistrict_Click(object sender, EventArgs e)
        {
            if (СityName == "") { MessageBox.Show("Город не выбран"); return; }
            City city = null;
            foreach (var item in сities)
            {
                if (item.Name == СityName)
                {
                    city = item;
                }
            }
            if (city == null) return;
            for (int i = 0; i < city.region.Count; i++)
            {
                if (city.region[i].Name == DistrictName)
                {
                    city.RemoveRegion(city.region[i].Name);
                    districtName.Items.RemoveAt(i);
                    districtName.Text = "";
                    countPeopleTbx.Text = "";
                    areaTxb.Text = "";
                }
            }
        }

        private void deleteSity_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < сities.Count; i++)
            {
                if (сities[i].Name == СityName)
                {
                    сities.RemoveAt(i);
                    cityName.Items.RemoveAt(i);
                    districtName.Text = "";
                    return;
                }
            }
        }

        private void cityTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in сities)
            {
                if(item.Name == cityTableComboBox.Text) 
                {

                    var district = item.region;
                    dataGridView1.RowCount = district.Count;
                    for(int i =0; i< district.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = district[i].Name;
                        dataGridView1.Rows[i].Cells[1].Value = district[i].countPeople;
                        dataGridView1.Rows[i].Cells[2].Value = district[i].Area;
                        dataGridView1.Rows[i].Cells[3].Value = district[i].PopulationDensity;
                    }
                }
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)| *.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                    {
                        string line;
                        City сity = new City("Город без названия");
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("Название города:"))
                            {
                                сity = new City(Name = line.Substring(17));
                                line = reader.ReadLine();
                                сities.Add(сity);
                                cityName.Items.Add(сity.Name);
                                cityTableComboBox.Items.Add(сity.Name);
                                cityDiagramComboBox.Items.Add(сity.Name);
                            }
                            else if (line.StartsWith("Название района:"))
                            {
                                // Получаем название района
                                string districtName = line.Substring(17);

                                //Площадь района
                                line = reader.ReadLine();
                                double area = double.Parse(line.Substring(15));

                                //Количество людей
                                line = reader.ReadLine();
                                int countPeople = int.Parse(line.Substring(18));

                                сity.AddRegion(districtName, area, countPeople);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Входной файл имел не верный формат");
                }
                
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }

        private void Unload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (City city in сities)
                        {
                            writer.WriteLine(city.GetInformationAboutCity());
                        }
                    }
                }
            }

        }

        private void cityDiagramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Очистить диаграмму.
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            // Добавить и форматировать заголовок.
            chart1.Titles.Add($"Плотоность населения районов города: {cityDiagramComboBox.Text}");
            chart1.Titles[0].Font = new Font("Utopia", 16);

            // Установить вид диаграммы.
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Плотность населения") { ChartType = SeriesChartType.Column });

            City city = null;
            // Загрузить данные диаграммы.
            for (int i = 0; i < сities.Count; i++)
            {
                if (cityDiagramComboBox.Text == сities[i].Name)
                {
                    city = сities[i];
                    break;
                }
            }

            string[] xValues = new string[city.countRegion];
            double[] yValues = new double[city.countRegion];

            var district = city.region;
            for (int i = 0; i < district.Count; i++)
            {
                xValues[i] = district[i].Name;
                yValues[i] = district[i].PopulationDensity;
            }

            chart1.Series["Плотность населения"].Points.DataBindXY(xValues, yValues);
            Legend legend = new Legend("Regions");
            chart1.Legends.Add(legend);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TabControl tabControl = (TabControl)sender;
            //if(tabControl.SelectedTab == tabPage3)
            //{
            //    chart1.Series.Clear();
            //}
        }
    }
}
