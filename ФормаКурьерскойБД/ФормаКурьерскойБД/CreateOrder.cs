using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
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
        double dist;
        decimal BaseCost;
        int idBaseCost;
        int cargoTypeId;
        decimal CostCoefficient;
        decimal additionalSum;
        string idServiceList;
        int idDepartmentReceiv;
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
                var idCargoType = row["idCargoType"].ToString();
                var Name = row["Name"].ToString();
                cargoType.Items.Add(new KeyValuePair<string, string>(idCargoType, Name));
            }
        }

        private async void calculateDistance_Click(object sender, EventArgs e)
        {
        

            dist = int.Parse(distance.Text);
                      
            // Выполняем функцию и получаем id базовой стоимости
            idBaseCost = database.ExecuteScalar<int>($"select dbo.GetBaseCostKey({(int)dist})" , CommandType.Text);

            // Выполняем запрос и получаем базовую стоимость
            BaseCost = database.ExecuteScalar<decimal>($"SELECT Cost FROM BaseCosts WHERE IdBaseCost = {idBaseCost}", CommandType.Text);
            baseCostTextBox.Text = BaseCost.ToString();    


            distance.Text = $"Расстояние между точками: {dist:0.##} км";
            calcTotalCost();
        }

        
        private void calcTotalCost()
        {
            List<int> serviceIds = new List<int>();
            foreach (var item in additionalService.CheckedItems)
            {
                int id = int.Parse(((KeyValuePair<string, string>)item).Key);
                serviceIds.Add(id);
            }
            cargoTypeId = int.Parse(((KeyValuePair<string, string>)cargoType.SelectedItem).Key);
            idDepartmentReceiv = int.Parse(((KeyValuePair<string, string>)departmentReceiv.SelectedItem).Key);
            CostCoefficient = database.ExecuteScalar<decimal>($"SELECT CostCoefficient FROM CargoTypes WHERE IdCargoType = {cargoTypeId}", CommandType.Text);
            idServiceList = string.Join(",", serviceIds);
            additionalSum = database.ExecuteScalar<decimal>($"SELECT SUM(Price) FROM AdditionalServices WHERE IdService IN({idServiceList})", CommandType.Text);
            TotalCost.Text = ((BaseCost * CostCoefficient) + additionalSum).ToString();
        }          

        private void departmentReceiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedDepartment = (KeyValuePair<string, string>)departmentReceiv.SelectedItem;
            //to.Text = selectedDepartment.Value;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            bool doorTodoor = false;
            string deliveryAddress = null;
            if (idServiceList.Contains("3"))
            {
                doorTodoor = true;
                if(to.Text != "")
                {
                    deliveryAddress = to.Text;
                }
            }
            SqlParameter resultParameter = new SqlParameter("@Result", SqlDbType.Int);
            resultParameter.Direction = ParameterDirection.Output;
            try
            {
                database.ExecuteNonQuery("dbo.CreateOrder", CommandType.StoredProcedure,
                                   new SqlParameter("@Date", DateTime.Now),
                                   new SqlParameter("@SenderId", int.Parse(ClientSender.Text)),
                                   new SqlParameter("@DepartureDepartmentId", _idDepartment),
                                   new SqlParameter("@ReceiverId", int.Parse(ClientReciev.Text)),
                                   new SqlParameter("@DestinationDepartmentId", idDepartmentReceiv),
                                   new SqlParameter("@CargoType", cargoTypeId),
                                   new SqlParameter("@BaseCostId", idBaseCost),
                                   new SqlParameter("@DoorToDoor", doorTodoor),
                                   new SqlParameter("@DeliveryAddress", deliveryAddress),
                                   new SqlParameter("@AdditionalServices", idServiceList), resultParameter);
                int idOrder = (int)resultParameter.Value;
                if (idOrder != 0)
                {
                    MessageBox.Show($"Заказ успешно создан: {idOrder}", "Успех", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Заказ не был создан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }                        
        }

        private void EmailSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Clients where Email = '{emailTB.Text}'", CommandType.Text);
        }

        private void департаментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery("select * from Departments", CommandType.Text);
        }

        private void базоваяСтоимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery("select * from BaseCosts", CommandType.Text);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery("select * from AdditionalServices", CommandType.Text);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery("select * from Clients", CommandType.Text);
        }
    }




}
