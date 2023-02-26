using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace laba14
{
    public partial class Graph : Form
    {

        public Graph(string nameSeries, List<double> xValues, List<double> yValues, string format)
        {
            InitializeComponent();
            InitializeSeries(nameSeries,xValues, yValues);
            CreateGraph(xValues,yValues, nameSeries);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = format;
        }
        private void InitializeSeries(string nameSeries,List<double> xValues, List<double> yValues)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = -100;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            Series series1 = new Series(nameSeries)
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 4,
            };
            chart1.Series.Add(series1);
        }
        
        private void CreateGraph(List<double> x, List<double> y, string nameSeries)
        {
            chart1.Series[nameSeries].Points.DataBindXY(x, y);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                this.chart1.SaveImage(fs, ChartImageFormat.Png);
                fs.Close();
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settigns settigns = new Settigns(chart1);
            Visible = false;
            settigns.ShowDialog();
            Visible = true;
        }
        
        
    }
}
