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

namespace WhoWantsToBeAMillionaire.Forms
{
    public partial class ChartDialog : Form
    {
        public ChartDialog(int correct)
        {
            InitializeComponent();
            CreateChart(correct);
        }

        private void CreateChart(int correct)
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("chartArea");
            chart.ChartAreas.Add(chartArea);

            chart.Series.Add("Answers");
            chart.Series["Answers"].ChartType = SeriesChartType.Column;

            Random random = new Random();
            List<string> answers = new List<string> { "A", "B", "C", "D" };

            int total = 0;
            for (int i = 0; i < answers.Count; i++)
            {
                int y;
                if (i + 1 == correct)
                {
                    y = random.Next(50, 100);
                }
                else
                {
                    y = random.Next(1, 50);
                }
                total += y;
                chart.Series["Answers"].Points.AddXY(answers[i], y);
            }

            if (total != 100)
            {
                double factor = 100.0 / total;
                foreach (var point in chart.Series["Answers"].Points)
                {
                    point.YValues[0] *= factor;
                }
            }

            Controls.Add(chart);
        }
    }
}
