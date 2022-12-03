using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        private double[] _array = new double[10];
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 12;
            dataGridView1.RowCount = 1;
            dataGridView1.ReadOnly = false;

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillFromDataGrid(double[] arr, DataGridView dataGridView)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                try { 
              _array[i] = double.Parse(dataGridView.Rows[0].Cells[i].Value.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Введены некоретные данные");
                    dataGridView1.Columns.Clear();
                    throw;
                }
            }
        }
        private void FillRandomDoubles(double[] arr)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var columnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = columnCount;
            _array = new double[columnCount];
            for(int i =0; i<columnCount; i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == radioButton1)
            {
                if (!radioButton1.Checked) return;
                dataGridView1.ReadOnly = false;
            }
            if(sender == radioButton2)
            {
                if (!radioButton2.Checked) return;
                dataGridView1.ReadOnly = true;
                FillRandomDoubles(_array);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].Name = i.ToString();
                    dataGridView1.Rows[0].Cells[i].Value = _array[i];
                }
            }
        }
        public double GetY(double[] arr)
        {
            var y = 0.0;
            var power = 1;
            for (int i = 0; i < arr.Length; i++)
                if (i < arr.Length - 1)
                    y += Math.Pow(-1, power++ + 1) * arr[i] + Math.Pow(-1, power++ + 1)*arr[++i];
            if (arr.Length % 2 != 0) y += arr[arr.Length - 1];
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var y = 0.0;
            try
            {
                if (radioButton1.Checked)
                    FillFromDataGrid(_array, dataGridView1);
                y = GetY(_array);
                label1.Text = $"Для формулы Y = (-1)^(n+1)*Xn ; Y= {y}";
                
            }
            catch
            {
                return;
            }
        }
    }
}
