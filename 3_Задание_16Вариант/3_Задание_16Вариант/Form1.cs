using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_16Вариант
{

    public partial class Form1 : Form
    {
        Triangle myTriangle1 = new Triangle();
        bool triangle1Exist = false;
        Triangle myTriangle2 = new Triangle();
        bool triangle2Exist = false;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void tAX_TextChanged(object sender, EventArgs e)
        {
            if(tAX.Text != "" && tAY.Text != "" && tBX.Text != "" && tBY.Text != "" && tCX.Text != "" && tCY.Text != "")
            {
                createT1.Enabled = true;
            }
            else
            {
                createT1.Enabled = false;
            }
        }

        private void t2AX_TextChanged(object sender, EventArgs e)
        {
            if (t2AX.Text != "" && t2AY.Text != "" && t2BX.Text != "" && t2BY.Text != "" && t2CX.Text != "" && t2CY.Text != "")
            {
                createT2.Enabled = true;
            }
            else
            {
                createT2.Enabled = false;
            }
        }

        private void directionT1_TextChanged(object sender, EventArgs e)
        {
            if(directionT1.Text != "" && distanceT1.Text != "")
            {
                moveT1.Enabled = true;
            }
            else
            {
                moveT1.Enabled = false;
            }
        }

        private void distanceT2_TextChanged(object sender, EventArgs e)
        {
            if (directionT2.Text != "" && distanceT2.Text != "")
            {
                moveT2.Enabled = true;
            }
            else
            {
                moveT2.Enabled = false;
            }
        }

        private void createT1_Click(object sender, EventArgs e)
        {
            try
            {
                int AX = int.Parse(tAX.Text);
                int AY = int.Parse(tAY.Text);

                int BX = int.Parse(tBX.Text);
                int BY = int.Parse(tBY.Text);

                int CX = int.Parse(tCX.Text);
                int CY = int.Parse(tCY.Text);

                myTriangle1 = new Triangle(triangle1, new Point(AX, AY), new Point(BX, BY), new Point(CX, CY));
                myTriangle1.Draw();
                triangle1Exist = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void createT2_Click(object sender, EventArgs e)
        {
            try
            {
                int AX = int.Parse(t2AX.Text);
                int AY = int.Parse(t2AY.Text);

                int BX = int.Parse(t2BX.Text);
                int BY = int.Parse(t2BY.Text);

                int CX = int.Parse(t2CX.Text);
                int CY = int.Parse(t2CY.Text);

                myTriangle2 = new Triangle(triangle2, new Point(AX, AY), new Point(BX, BY), new Point(CX, CY));
                myTriangle2.Draw();
                triangle2Exist = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void moveT1_Click(object sender, EventArgs e)
        {
            if (!triangle1Exist) return;
            try
            {
                int distance = int.Parse(distanceT1.Text);
                if (directionT1.SelectedIndex == 0)
                {
                    myTriangle1.moveTriangle(distance, 1);
                }
                else if (directionT1.SelectedIndex == 1)
                {
                    myTriangle1.moveTriangle(distance, 2);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void moveT2_Click(object sender, EventArgs e)
        {
            if (!triangle2Exist) return;
            try
            {
                int distance = int.Parse(distanceT2.Text);
                if (directionT2.SelectedIndex == 0)
                {
                    myTriangle2.moveTriangle(distance, 1);
                }
                else if (directionT2.SelectedIndex == 1)
                {
                    myTriangle2.moveTriangle(distance, 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowStringT1_Click(object sender, EventArgs e)
        {
            if (!triangle1Exist) return;
            MessageBox.Show(myTriangle1.ToString());
        }

        private void ShowStringT2_Click(object sender, EventArgs e)
        {
            if (!triangle2Exist) return;
            MessageBox.Show(myTriangle2.ToString());
        }

        private void compare_Click(object sender, EventArgs e)
        {
            if (!triangle2Exist || !triangle1Exist) return;
            if(myTriangle1 > myTriangle2)
            {
                MessageBox.Show("Треугольник 1 > Треугольник 2");
            }
            if (myTriangle1 < myTriangle2)
            {
                MessageBox.Show("Треугольник 1 < Треугольник 2");
            }
            if (myTriangle1 == myTriangle2)
            {
                MessageBox.Show("Треугольник 1 == Треугольник 2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!triangle1Exist) return;
            MessageBox.Show(((double)myTriangle1).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!triangle2Exist) return;
            MessageBox.Show(((double)myTriangle2).ToString());
        }
    }
}
