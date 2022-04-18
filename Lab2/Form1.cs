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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadMatr1_Click(object sender, EventArgs e)
        {
            TryFillMatr(matrGridView1);
        }

        private void loadMatr2_Click(object sender, EventArgs e)
        {
            TryFillMatr(matrGridView2);
        }

        public bool TryFillMatr(DataGridView matr)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string firstline = reader.ReadLine();
                    string[] row = firstline.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int columnCount = row.Length;
                    matr.ColumnCount = columnCount;
                    matr.Rows.Add(row);

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        row = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        if (columnCount != row.Length)
                        {
                            int lineNum = matr.Rows.Count + 1;
                            matr.Rows.Clear();
                            matr.Columns.Clear();
                            MessageBox.Show("Error line " + lineNum + " in " + openFileDialog1.FileName);
                            return false;
                        }
                        matr.Rows.Add(row);
                    }
                }
            }
            return true;
        }

        private bool TryParseMatr(DataGridView grid, out int[,] matr)
        {
            matr = new int[grid.RowCount, grid.ColumnCount];
            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    try
                    {
                        matr[i, j] = Convert.ToInt32(grid[i, j].Value);
                    }
                    catch 
                    {
                        MessageBox.Show("Bad data in cell " + (i+1) + (j+1));
                        grid[i, j].Selected = true;
                        return false;
                    }
                }
            }
            return true;
        }

        private void task1_Click(object sender, EventArgs e)
        {
            clear(matrGridView1);
            clear(matrGridView2);

            if (TryParseMatr(matrGridView1, out var matr1)
                && TryParseMatr(matrGridView2, out var matr2))
            { 
                int m1 = matr1.GetLength(0);
                int n1 = matr2.GetLength(0);
                int m2 = matr1.GetLength(1);
                int n2 = matr2.GetLength(1);

                if (m1 != m2 || n1 != n2)
                {
                    MessageBox.Show("Матриці мають різні розмірності", "Error");
                        return;
                }

                for (int i = 0; i < m1; i++)
                    for (int j = 0; j < n1; j++)
                    {
                         if (matr1[i, j] > matr2[i, j])
                        {
                            matrGridView1[i, j].Style.BackColor = Color.RoyalBlue;
                        }
                    }
            }
        }

        private void clear(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                for (int i = 0; i < grid.ColumnCount; i++)
                { 
                    row.Cells[i].Style.BackColor= Color.White;
                }
            }
        }

        private void task2_Click(object sender, EventArgs e)
        {
            TryParseMatr(matrGridView1, out var matr1);
            TryParseMatr(matrGridView2, out var matr2);
            DiagramForm df = new DiagramForm(matr1,matr2);
            df.Show();
        }
    }
}