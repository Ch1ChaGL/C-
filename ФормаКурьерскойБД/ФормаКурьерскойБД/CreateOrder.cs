using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Dadata;
using Dadata.Model;


namespace ФормаКурьерскойБД
{
    public partial class CreateOrder : Form
    {

        int _idDepartment;
        string sql;
        SqlDataReader reader;
        deliveryServiceDatabase database;
        public CreateOrder(int idDepartment)
        {
            InitializeComponent();
            _idDepartment = idDepartment;
           
        }
        
        private void CreateOrder_Load(object sender, EventArgs e)
        {
            sql = $"SELECT CONCAT(City, ', ', Street, ', ', House) FROM Departments where idDepartment = '{_idDepartment}'";

            database = new deliveryServiceDatabase();
            try
            {
                reader = database.ExecuteReader(sql, CommandType.Text);
                reader.Read();

                from.Text = reader.GetString(0);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            sql = $"Select idDepartment, CONCAT(City, ', ', Street, ', ', House) as Адрес from Departments";
           
            var dataTable = database.ExecuteQuery(sql, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                var idDepartment = row["idDepartment"].ToString();
                var address = row["Адрес"].ToString();
                departmentReceiv.Items.Add(new KeyValuePair<string, string>(idDepartment, address));
            }

            sql = $"select * from AdditionalServices";
            dataTable = database.ExecuteQuery(sql, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                var idService = row["idService"].ToString();
                var Name = row["Name"].ToString();
                additionalService.Items.Add(new KeyValuePair<string, string>(idService, Name));
            }

            sql = $"select * from CargoTypes";
            dataTable = database.ExecuteQuery(sql, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                var idService = row["idCargoType"].ToString();
                var Name = row["Name"].ToString();
                cargoType.Items.Add(new KeyValuePair<string, string>(idService, Name));
            }
        }

        private async void calculateDistance_Click(object sender, EventArgs e)
        {
            var token = "27daefbd917dc02c543b8c6e5207e61610355de4";
            var secret = "7b062d9739d2b95ad81edf359c9da9a7354329c2";
            var api = new CleanClientAsync(token, secret);
            var addressFrom = await api.Clean<Address>(from.Text);
            var addressTo = await api.Clean<Address>(to.Text);

            //Координаты широта и долгота точки отправления
            string latFrom = addressFrom.geo_lat;
            string lonFrom = addressFrom.geo_lon;

            //Координаты широта и долгота точки отправления
            string latTo = addressTo.geo_lat;
            string lonTo = addressTo.geo_lon;


            double dist = calcDistance(latFrom, lonFrom, latTo, lonTo);
            // Создаем объект класса deliveryServiceDatabase
           



            // Выполняем функцию и получаем id базовой стоимости
            int idBaseCost = database.ExecuteScalar<int>($"select dbo.GetBaseCostKey({(int)dist})" , CommandType.Text);

            // Выполняем запрос и получаем стоимость
            decimal cost = database.ExecuteScalar<decimal>($"SELECT Cost FROM BaseCosts WHERE IdBaseCost = {idBaseCost}", CommandType.Text);
            baseCostTextBox.Text = cost.ToString();    


            distance.Text = $"Расстояние между точками: {dist:0.##} км";
        }


        private double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        private double calcDistance(string latFrom, string lonFrom, string latTo, string lonTo)
        {
            const double earthRadiusKm = 6371.0;

            if (!double.TryParse(latFrom, NumberStyles.Float, CultureInfo.InvariantCulture, out double latFromNum))
                throw new ArgumentException("Incorrect latitude for addressFrom: " + latFrom);
            if (!double.TryParse(lonFrom, NumberStyles.Float, CultureInfo.InvariantCulture, out double lonFromNum))
                throw new ArgumentException("Incorrect longitude for addressFrom: " + lonFrom);
            if (!double.TryParse(latTo, NumberStyles.Float, CultureInfo.InvariantCulture, out double latToNum))
                throw new ArgumentException("Incorrect latitude for addressTo: " + latTo);
            if (!double.TryParse(lonTo, NumberStyles.Float, CultureInfo.InvariantCulture, out double lonToNum))
                throw new ArgumentException("Incorrect longitude for addressTo: " + lonTo);

            double dLat = ToRadians(latToNum - latFromNum);
            double dLon = ToRadians(lonToNum - lonFromNum);

            double lat1 = ToRadians(latFromNum);
            double lat2 = ToRadians(latToNum);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthRadiusKm * c;
        }

        private void departmentReceiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDepartment = (KeyValuePair<string, string>)departmentReceiv.SelectedItem;
            to.Text = selectedDepartment.Value;
        }
    }




}
