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

namespace Lab2
{
    public partial class DiagramForm : Form
    {
        private int[,] matr1, matr2;
        private int maxEl = -1;
        private int counw = 0;
        public DiagramForm(int[,] matr1, int[,] matr2)
        {
            this.matr1 = matr1;
            this.matr2 = matr2;
            InitializeComponent();
            maxMatrElem(matr1);
            maxMatrElem(matr2);
            matrCheck(matr1, "Матриця1");
            matrCheck(matr2, "Матриця2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void maxMatrElem(int[,] matr) 
        {
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                {

                    if (matr[i, j] != matr[i, j]+1 )
                    {
                        counw += 1;
                        Console.WriteLine(counw);
                    }
                    if (maxEl < matr[i, j])
                    { 
                        maxEl = matr[i, j]+1;
                    }
                }
        }

        public void matrCheck(int [,]matr, string name)
        {
            int count = 0;
            Dictionary<int,int> chartDat = new Dictionary<int, int>();
            for (int n = 1; n < maxEl; n++)
            {
                count = 0;
                for (int i = 0; i < matr.GetLength(1); i++)
                    for (int j = 0; j < matr.GetLength(0); j++)
                    {
                        if (n == matr[i, j]) 
                        {
                            count++;
                        }
                    }
                chartDat.Add(n, count);
            }
            addSeries(chartDat, name);
        }

        public void addSeries(Dictionary<int,int> matrix, string name)
        {
            var series = new Series { ChartType = SeriesChartType.Line, BorderWidth = 5, Name = name };

            for (int i = 1; i <= matrix.Count; i++)
            {
                series.Points.AddXY(i, matrix[i]);
            }
            chart1.Series.Add(series);
        }
    }
}
