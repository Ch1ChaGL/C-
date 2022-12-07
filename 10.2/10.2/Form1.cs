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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _10._2
{
   
    public partial class Form1 : Form
    {
        List<Place> list = new List<Place>();
        string fullrichtext = "";
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || (e.KeyChar.Equals(',')) && (!textBox2.Text.Contains(',') && textBox2.Text.Length != 0));
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string textOnRichTextBox = richTextBox1.Text;       
                string name = comboBox1.Text;
                double countPeople = double.Parse(textBox2.Text);                
                int countCrime = int.Parse(textBox3.Text);
                count++;
                Place place = new Place(name, countPeople, countCrime);
                list.Add(place);
                richTextBox1.Text = textOnRichTextBox + count + " " + place.ToString();
            }
            catch
            {
                MessageBox.Show("Не все поля были введены");
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            count = 0;
            list.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {   int count = 1;
            string serchlist = "";
            double hightProcnet = double.MinValue;
            fullrichtext = richTextBox1.Text;
            foreach(var prop in list)
            {
               if(prop._procent > hightProcnet)
               {
                    hightProcnet = prop._procent;
               }
            }
            foreach (var prop in list)
            {
                if (prop._procent == hightProcnet)
                {   
                    serchlist = serchlist +count+" "+prop.ToString();
                    richTextBox1.Text = serchlist;  
                }
                count++;
            }
            button4.Enabled = true;
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = fullrichtext;
            button4.Enabled = false;
            button3.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
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
