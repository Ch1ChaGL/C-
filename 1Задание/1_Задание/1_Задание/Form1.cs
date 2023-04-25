using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rowCount;
        private void Form1_Load(object sender, EventArgs e)
        {
            calc.Enabled = false;
        }
        const int ODZ = 1;
        const int LEFT_BORDERS = 0;
        const int RIGHT_BORDERS = 1;
        /// <summary>
        /// Подсчет суммы ряда и количества элементов ряда
        /// </summary>
        /// <param name="x"></param>
        /// <param name="e"></param>
        /// <param name="rowLong"></param>
        /// <returns></returns>
        private double rowSum(double x, double e, out int rowLong)
        {
            double U = -(1 / x);
            double Up = 0;
            rowLong = 0;
            double S = U;
            int coef = 0;
            for (int i = 1; (Math.Abs(U - Up) > e); i++)
            {
                
                Up = U;
                rowLong++;
                double znam = (double)(2 + coef + 1) / (coef + 1) * (x * x);
                U = -1 * (U * (1 / znam));
                coef += 2;

                //U = Math.Pow(-1, (i + 1)) /( (2 * i + 1) * Math.Pow(x, 2 * i + 1));
                S += U;
               // if (!)) return (Math.PI/2) + S;
            }
            return (Math.PI / 2) + S;
        }
      
        /// <summary>
        /// Event на нажатие кнопки, вызывает функцию rowSum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calc_Click(object sender, EventArgs e)
        {
            double argX = 0;
            double acc = 0;
            try
            {
                argX = double.Parse(argumentX.Text);
                acc = double.Parse(accuracy.Text);
                if (!(argX > ODZ)) throw new Exception("Аргумент не подходит под одз");
                if(acc<=LEFT_BORDERS || acc>=RIGHT_BORDERS) throw new Exception("Точность введена неверно");
                double sum = rowSum(double.Parse(argumentX.Text), double.Parse(accuracy.Text), out rowCount);
                arctgLb.Text = $"Arctg(x) = {Math.Atan(double.Parse(argumentX.Text))}";
                rowSumLb.Text = $"Сумма ряда {sum}";
                countRow.Text = $"Количество членов ряда {rowCount}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        /// <summary>
        /// Ограничение на ввод только чисел и ','
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accuracy_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txb = sender as TextBox;
            
            if (txb.Text.Contains(",") && e.KeyChar == ',') { e.Handled = true; return; }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
           
            
        }
        /// <summary>
        /// Ограничение на доступность кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accuracy_TextChanged(object sender, EventArgs e)
        {
            if (accuracy.Text != "" && argumentX.Text != "") calc.Enabled = true;
            else calc.Enabled = false;
        }
    }
}
