using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LINQ_Research
{
    public partial class Research : Form
    {
        int[] size = new int[10];
        string[] array = new string[10];
        List<string> list = new List<string>();
        long[] linq = new long[10], c_sharp = new long[10];
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        long start, end;

        public Research()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
                size[i] = (i + 1) * 1000;

            ResearchChart.BackColor = Color.FromArgb(32, 32, 32);
            ResearchChart.ForeColor = Color.White;
            ResearchChart.BackSecondaryColor = Color.FromArgb(32, 32, 32);
            ResearchChart.ChartAreas[0].BackColor = Color.FromArgb(50, 50, 50);

            ResearchChart.ChartAreas[0].AxisX.LineColor = Color.White;
            ResearchChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            ResearchChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            ResearchChart.ChartAreas[0].AxisY.LineColor = Color.White;
            ResearchChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            ResearchChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            ResearchChart.ChartAreas[0].AxisY.Title = "Time (ticks)";
            ResearchChart.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            ResearchChart.ChartAreas[0].AxisX.Title = "Size";
            ResearchChart.ChartAreas[0].AxisX.TitleForeColor = Color.White;


            ResearchChart.Series.Add(new Series());
            ResearchChart.Series[0].ChartType = SeriesChartType.Line;
            ResearchChart.Series[1].ChartType = SeriesChartType.Line;
            ResearchChart.Series[0].Color = Color.Yellow;
            ResearchChart.Series[1].Color = Color.Magenta;
            ResearchChart.Series[0].Name = "LINQ";
            ResearchChart.Series[1].Name = "C#";
            ResearchChart.Legends[ResearchChart.Series[0].Legend].BackColor = Color.FromArgb(32, 32, 32);
            ResearchChart.Legends[ResearchChart.Series[1].Legend].BackColor = Color.FromArgb(32, 32, 32);

            ResearchChart.Legends[ResearchChart.Series[0].Legend].ForeColor = Color.White;
            ResearchChart.Legends[ResearchChart.Series[1].Legend].ForeColor = Color.White;

            ResearchGridView.ColumnCount = 3;
            ResearchGridView.RowCount = 10;
            ResearchGridView.Columns[0].Name = "Size";
            ResearchGridView.Columns[1].Name = "LINQ";
            ResearchGridView.Columns[2].Name = "C#";
            ResearchButton_Click(new object(), new EventArgs());
        }

        private void OutputList(int[] size, long[] linq, long[] c_sharp)
        {
            ResearchGridView.EnableHeadersVisualStyles = false;
            ResearchGridView.BorderStyle = BorderStyle.None;

            for (int i = 0; i < 10; i++)
            {
                int j = 0;
                ResearchGridView[j++, i].Value = size[i];
                ResearchGridView[j++, i].Value = linq[i];
                ResearchGridView[j++, i].Value = c_sharp[i];
            }
        }

        private void ResearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                array = new string[size[i]];
                for (int j = 0; j < size[i]; j++)
                {
                    int length = random.Next(5, 10);
                    array[j] = "";
                    for (int h = 0; h < length; h++)
                    {
                        array[j] += chars[random.Next(chars.Length)];
                    }
                }

                start = Stopwatch.GetTimestamp();
                list = array.Where(x => x.Length > 5).ToList();
                end = Stopwatch.GetTimestamp();
                list.Clear();

                start = Stopwatch.GetTimestamp();
                list = array.Where(x => x.Length > 5).ToList();
                end = Stopwatch.GetTimestamp();
                linq[i] = end - start;
                list.Clear();

                start = Stopwatch.GetTimestamp();
                foreach (string el in array)
                {
                    if (el.Length > 5)
                        list.Add(el);
                }
                end = Stopwatch.GetTimestamp();
                c_sharp[i] = end - start;
                list.Clear();
            }

            ResearchChart.Series[0].Points.DataBindXY(size, linq);
            ResearchChart.Series[1].Points.DataBindXY(size, c_sharp);

            OutputList(size, linq, c_sharp);
        }
    }
}
