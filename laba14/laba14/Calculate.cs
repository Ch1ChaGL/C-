using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba14
{
    public partial class Calculate : Form
    {
        private List<double> xValue = new List<double>();
        private List<double> yValue = new List<double>();     
        private delegate double Fun(double x, double a);
        private Dictionary<string, Fun> mapFun;
       
       

        private double firstFunction(double x, double a)
        {
            return Math.Cos(a*x) * Math.Pow(Math.E,x);
        }
        private double secondFunction(double x, double a)
        {
            return -1*firstFunction(x,a);
        }
        private double thirdFunction(double x, double a)
        {
            return -1 * Math.Sin(a * x) * Math.Pow(Math.E, x); 
        }
        private void pointСalculation(Fun F, double Xn, double Xk, double dX,double a)
        {
            xValue.Clear();
            yValue.Clear();
            double startValue = Xn * Math.PI;
            double endValue = Xk * Math.PI;
            double step = dX * Math.PI;
            while (startValue <= endValue)
            {
                xValue.Add(Math.Round(startValue,2));
                yValue.Add(Math.Round(F(startValue, a),2));
                startValue += step;
            }
        }


        public Calculate()
        {
            InitializeComponent();            
            mapFun = new Dictionary<string, Fun>()
            {
                { "Cos(ax) * e^x", firstFunction},
                { "-Cos(ax) * e^x", secondFunction},
                { "-Sin(ax) * e^x", thirdFunction},

            };

            

        }

        private void buildAGraph_Click(object sender, EventArgs e)
        {
            try
            {
                var f1 = mapFun[collectionFunction.Text];
                
                pointСalculation(
                    f1, double.Parse(startValue.Text), 
                    double.Parse(endValue.Text), double.Parse(step.Text),
                    double.Parse(aValue.Text)
                );
                initializationDataGridView(xValue.Count);
                Graph graph = new Graph(collectionFunction.Text,xValue,yValue);
                graph.ShowDialog();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        private void initializationDataGridView(int rowsCount)
        {
            dataGridView1.Visible = true;
            dataGridView1.Columns.Clear(); // Удаление столбцов
            dataGridView1.Rows.Clear(); // Удаление строк
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = rowsCount;
            dataGridView1.RowHeadersVisible = false; // Скрытие заголовков строк
            dataGridView1.ColumnHeadersVisible = false; // Скрытие заголовков столбцов
            dataGridView1.ScrollBars = ScrollBars.None; // Убрать прокрутку
            dataGridView1.DefaultCellStyle.BackColor = Color.White; // Установка белого фона ячеек
            dataGridView1.ReadOnly = true; // Запрет редактирования ячеек
            dataGridView1.AllowUserToResizeRows = false; // Запрет изменения размера строк
            dataGridView1.AllowUserToResizeColumns = false; // Запрет изменения размера столбцов
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Заполнение всего пространства ячейки содержимым
            for (int i = 0; i < rowsCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = xValue[i];
                dataGridView1.Rows[i].Cells[1].Value = yValue[i];
            }
            DataGridViewRow headerRow = new DataGridViewRow();
            headerRow.CreateCells(dataGridView1);
            headerRow.Cells[0].Value = "x";
            headerRow.Cells[1].Value = "y";
            dataGridView1.Rows.Insert(0, headerRow);

            dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
        }
    }
}
