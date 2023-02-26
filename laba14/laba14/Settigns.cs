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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba14
{
    public partial class Settigns : Form
    {
        private Chart _chart;
        private Color ChartColor = Color.Blue;
        private Color BackgroundColor = Color.White;
        public Settigns(Chart chart)
        {
            _chart = chart;
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            check();
            setWidth();
            setColor();
            changeChartType();
        }
        private void check()
        {
            var series = _chart.Series[0]; // предположим, что нужно получить название первой серии
            var seriesName = series.Name; // получаем название серии
            if (checkBox1.Checked)
            {
                _chart.Series[0].IsVisibleInLegend = true;
            }
            else
            {
                _chart.Series[0].IsVisibleInLegend = false;
            }
            if (checkBox2.Checked)
            {
                bool hasTitle = false;
                foreach (var title in _chart.Titles)
                {
                    if (title.Text == seriesName)
                    {
                        hasTitle = true;
                        break;
                    }
                }
                if (!hasTitle)
                {
                    _chart.Titles.Add(seriesName);
                    _chart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
                }
            }
            else
            {
                _chart.Titles.Clear();
            }
        }
        private void setWidth()
        { 
            if (trackBar1.Value == 0)
            {
                _chart.Series[0].BorderWidth = 1;
            }
            else
            {
                _chart.Series[0].BorderWidth = trackBar1.Value;
            }

            // Обновляем график
            _chart.Invalidate();
        }
        private void setColor()
        {
            _chart.Series[0].Color = ChartColor;
            _chart.BackColor = BackgroundColor;
        }

        private void colorLine_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ChartColor = colorDialog1.Color;
                colorLine.BackColor = colorDialog1.Color;
            }
        }

        private void colorGraph_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackgroundColor = colorDialog1.Color;
                _chart.BackColor = BackgroundColor;
                colorGraph.BackColor = BackgroundColor;
                foreach (var chartArea in _chart.ChartAreas)
                {
                    chartArea.BackColor = BackgroundColor;
                }
            }
        }
        private void changeChartType()
        {
            string chartType = typeGraph.Text;
            Series series = _chart.Series.FirstOrDefault();
            if (series != null)
            {
                // В зависимости от выбранного типа графика меняем его вид
                if (chartType == "Линейный")
                {
                    series.ChartType = SeriesChartType.Line;
                }
                else if (chartType == "Точечный")
                {
                    series.ChartType = SeriesChartType.Point;
                }
                else if (chartType == "Сплайн")
                {
                    series.ChartType = SeriesChartType.Spline;
                }
            }
        }
    }
}
