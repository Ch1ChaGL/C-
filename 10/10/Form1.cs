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


namespace _10
{
    
    public partial class Form1 : Form
    {

        string fullrichtext = "";
        int count = 0;
        double hightProcent = double.MinValue;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textOnRichTextBox = richTextBox1.Text;
            count++;
            string name = comboBox1.Text;
            double countPeople = double.Parse(textBox2.Text);
            int countCrime = int.Parse(textBox3.Text);
            double procent = Math.Round((countCrime / countPeople) * 100,2);
            if(procent > hightProcent)
            {
                hightProcent = procent;
            }
            richTextBox1.Text = textOnRichTextBox + $"{count} Name of the region: {name}, Number of people: {countPeople}, Number of crimes: {countCrime}, Percent: {procent}%\n"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            count = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fullrichtext = richTextBox1.Text;
            string textOnRichTextBox = richTextBox1.Text;
            string[] list = (richTextBox1.Text).Split('\n');
            string serchlist = "";
            foreach(var prop in list)
            {   if (prop.Length < 2) return;
                int index = prop.IndexOf("Percent: ");
                string a = prop.Substring(index+9);
                int lenght = a.Length - 1;
                a = a.Remove(lenght);

                double procent = Convert.ToDouble(a);
                if(procent == Math.Round(hightProcent,2))
                {
                    serchlist = serchlist + prop + "\n";
                    richTextBox1.Text = serchlist;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = fullrichtext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt"; 
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                fullrichtext = richTextBox1.Text;
                string path = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write(fullrichtext);
                bw.Dispose();                               
            }

        }
    }
}
