
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

namespace study_practice
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
            InitChart();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void InitChart()
        {
            chart1.Series.Clear();

            var analyticSeries = new Series("Аналитический")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.MediumSeaGreen
            };

            var monteCarloSeries = new Series("Монте-Карло")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue
            };

            chart1.Series.Add(analyticSeries);
            chart1.Series.Add(monteCarloSeries);

            chart1.ChartAreas[0].AxisX.Title = "№";
            chart1.ChartAreas[0].AxisY.Title = "Площадь";

            var db = new DatabaseService();
            var adapter = db.GetAllResultsAdapter();

            var table = new DataTable();
            adapter.Fill(table);

            //MessageBox.Show($"Количество строк: {table.Rows.Count}");

            int index = 1;

            foreach (DataRow row in table.Rows)
            {
                string method = row["Method"].ToString().Trim().ToLower();
                double area = Convert.ToDouble(row["Area"]);

                if (method == "аналитический")
                {
                    analyticSeries.Points.AddXY(index, area);
                }
                else if (method == "монте-карло")
                {
                    monteCarloSeries.Points.AddXY(index, area);
                }

                index++;
            }
        }

    }
}
