using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _7_Задание_16Вариант
{
    public partial class Form1 : Form
    {
        string fileName = "hospitals.dat";
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        public string FullName
        {
            set
            {
                fullName.Text = value;
            }
        }
        public DateTime Birthday
        {
            set
            {
                birthday.Value = value;
            }
        }
        public DateTime VizitDay
        {
            set
            {
                vizitTime.Value = value;
            }
        }
        public string Diagnoz
        {
            set
            {
                diagnoz.Text = value;
            }
        }
        public int Unit
        {
            set
            {
                unitNum.Text = value.ToString();
            }
        }
        private void View_Click(object sender, EventArgs e)
        {
            
            form2.Owner = this;
            form2.Show();
          
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string FullName = fullName.Text;
            for (int i = FullName.Length; i < 40; i++)
            {
                FullName += " ";
            }

            var pos = Hospital.FindByName(fileName, FullName);
            var hospital = new Hospital(fullName.Text, birthday.Value, vizitTime.Value, diagnoz.Text, int.Parse(unitNum.Text));

            if (pos >= 0)
            {
                hospital.CorrectResult(fileName, pos);
            }
            else
            {
                hospital.SaveResult(fileName);
            }
            form2.updateDataGridView();
        }
    }
}
