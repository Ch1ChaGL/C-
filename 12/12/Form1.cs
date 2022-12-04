using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace _12
{
    public partial class Form1 : Form
    {
        private double[,] _array = new double[5,5];
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            dataGridView1.ReadOnly = false;
        }
        private void FillRandomDoubles(double[,] arr)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j<arr.GetLength(1);j++)
                    if (rnd.NextDouble() > 0.5) {
                        arr[i, j] = Math.Round(rnd.NextDouble() * 100, 2)  * -1;
                    }
                    else
                    {
                        arr[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
                    }
                    
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var Count = (int)numericUpDown1.Value;
            dataGridView1.ColumnCount = Count;
            dataGridView1.RowCount = Count;          
            _array = new double[Count, Count];

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
                for(int i = 0; i<dataGridView1.ColumnCount; i++)
                {
                    for(int j =0; j<dataGridView1.RowCount; j++)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = _array[i,j];
                    }
                }
            }
            if(sender == radioButton3)
            {

            }
        }


        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-')&&(e.KeyChar != '\b') && (e.KeyChar != ',') ))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                { e.Handled = true; }
            }

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        private void FillFromDataGrid(double[,] arr, DataGridView dataGridView)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {        
                for(int j = 0; j < arr.GetLength(1); j++)
                    _array[i,j] = double.Parse(dataGridView.Rows[i].Cells[j].Value.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FillFromDataGrid(_array, dataGridView1);
            double min = int.MaxValue;
            double sum = 0;
            int row = 0;
            for(int i = 0; i<_array.GetLength(0); i++)
            {
                for(int j = 0; j<_array.GetLength(1); j++)
                {
                    sum += _array[i,j];
                }
                if (sum <= min)
                {                   
                    min = sum;
                    row = i;
                }
                sum = 0;
            }
            double[] arrayTemp = new double[_array.GetLength(1)];
            for (int j = 0; j < _array.GetLength(1); j++)
            {               
                arrayTemp[j] = _array[row, j];
                _array[row, j] = _array[j, row];
                _array[j, row] = arrayTemp[j];
            }
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = _array[i, j];
                }
            }
            label2.Text = $"Строка с наименьшей суммой = {min}, {row}";
        }
    }
}
