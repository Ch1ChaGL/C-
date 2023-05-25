using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Задание_16Вариант
{
    public partial class Form1 : Form
    {
        const int LEFT_BORDERS = 0;
        const int RIGHT_BORDERS = 1;
        public Form1()
        {
            InitializeComponent();
            //calc.Enabled = false;
        }
        int rowLong;
        /// <summary>
        /// Ограничение на доступность кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accuracy_TextChanged(object sender, EventArgs e)
        {
            if (accuracy.Text != "" && argumentX.Text != "") { calc.Enabled = true; }
            else calc.Enabled = false;
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

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                var x = double.Parse(argumentX.Text);
                var ep = double.Parse(accuracy.Text);
                if (ep <= LEFT_BORDERS || ep >= RIGHT_BORDERS) throw new Exception("Точность введена неверно");
                var sum = rowSum(x, ep, out rowLong);
                CosLb.Text = "Cos(x) = " + Math.Cos(x);
                sumRow.Text = $"Сумма ряда = {sum}";
                CountRow.Text = $"Количество членов ряда = {rowLong}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private double rowSum(double x, double e, out int rowLong)
        {
            double U = ((x * x )/ (1 * 2));
            double Up = 0; 
            rowLong = 0;
            double S = 0;
            double z = -1;

            for (int i = 2; (Math.Abs(U - Up) > e); i+=2)
            {
                S += z * U;
                Up = U;
                rowLong++;

                U = U * (x * x) / ((i + 1) * (i + 2));
                z *= -1;
            }
            return (1 + S);
        }
    }
}
