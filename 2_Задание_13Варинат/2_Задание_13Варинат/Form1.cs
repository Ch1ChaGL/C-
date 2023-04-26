using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2_Задание_13Варинат
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {         
            if (!char.IsDigit(e.KeyChar)  && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                if (!(num > 0 && num % 1 == 0)) return;
                int naturalNumber = int.Parse(textBox1.Text);
                int result = digitalRadical.CalculateDigitalRadical(naturalNumber);
                label3.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void вычислитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
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
                    string filePath = openFileDialog.FileName;
                    List<int> numbers = Array.ConvertAll(File.ReadAllText(filePath).Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse).ToList();
                    List<string> res = new List<string>();
                    foreach(var num in numbers)
                    {
                        res.Add(digitalRadical.CalculateDigitalRadical(num).ToString()); 
                    }
                    label3.Text = $"Результат: {string.Join(",", res)}";
                    textBox1.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                               
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }
    }
}
