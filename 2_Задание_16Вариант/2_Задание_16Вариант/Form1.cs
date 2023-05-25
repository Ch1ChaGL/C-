using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Задание_16Вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int naturalNumber;
        int targetSystem;
        private void NaturalNumber_TextChanged(object sender, EventArgs e)
        {
            if(system.Text == "") translateFromFile.Enabled = false;
            else translateFromFile.Enabled = true;
            if (system.Text == "" || NaturalNumber.Text == "")
            {
                translate.Enabled = false;
            }
            else
            {
                translate.Enabled = true;
            }
        }

        private void NaturalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

      
            if (e.KeyChar == '0' && NaturalNumber.Text.Length < 1)
            {
                MessageBox.Show("Натуральное число не может начинаться с нуля");
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void translate_Click(object sender, EventArgs e)
        {
            try
            {
                result.Rows.Clear();
                naturalNumber = int.Parse(NaturalNumber.Text);
                targetSystem = int.Parse(system.Text);
                result.RowCount = 1;
                result.ColumnCount = 1;
                result.Rows[0].Cells[0].Value = translateToTargetSystem(naturalNumber, targetSystem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка {ex.Message}");
            }
        }

        private void system_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private string translateToTargetSystem(int natural, int target)
        {
            if (target < 2 || target > 36)
            {
                throw new ArgumentException("Недопустимое основание системы счисления.");
            }

            if (natural == 0)
            {
                return "0";
            }

            string convertedNumber = string.Empty;
            while (natural > 0)
            {
                int remainder = natural % target;
                char digit = (char)(remainder < 10 ? remainder + '0' : remainder - 10 + 'A');
                convertedNumber = digit + convertedNumber;
                natural /= target;
            }

            return convertedNumber;
        }

        private void translateFromFile_Click(object sender, EventArgs e)
        {
            targetSystem = int.Parse(system.Text);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<int> numbers = new List<int>();

                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            numbers.Add(number);
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                }
                List<string> targetNums = new List<string>();
                foreach (int number in numbers) 
                {
                    targetNums.Add(translateToTargetSystem(number, targetSystem));
                }
                result.Rows.Clear();
                result.ColumnCount = targetNums.Count;
                
                for (int i = 0; i < targetNums.Count; i++)
                {
                    result.Rows[0].Cells[i].Value = targetNums[i];
                }
            }
        }
    }
}
