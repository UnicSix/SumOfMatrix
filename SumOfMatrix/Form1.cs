using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string inputFile = "matrix.txt";
            int[,] A = new int[2,2];
            int[,] B = new int[2,2];
            System.IO.StreamReader inputData = new System.IO.StreamReader(inputFile);
            InitializeComponent();
            string mt1 = "";
            string[] crd1;
            mt1 = inputData.ReadLine();
            crd1 = mt1.Split(',');
            string mt2 = "";
            string[] crd2;
            mt2 = inputData.ReadLine();
            crd2 = mt2.Split(',');
            dataGridView1.Rows.Add("");
            dataGridView1.Rows[0].Cells[0].Value = crd1[0];
            dataGridView1.Rows[0].Cells[1].Value = crd1[1];
            dataGridView1.Rows[1].Cells[0].Value = crd2[0];
            dataGridView1.Rows[1].Cells[1].Value = crd2[1];
            A[0,0] = int.Parse(crd1[0]);
            A[0,1] = int.Parse(crd1[1]);
            A[1,0] = int.Parse(crd2[0]);
            A[1,1] = int.Parse(crd2[1]);

            mt1 = inputData.ReadLine();
            crd1 = mt1.Split(',');
            mt2 = inputData.ReadLine();
            crd2 = mt2.Split(',');
            dataGridView2.Rows.Add("");
            dataGridView2.Rows[0].Cells[0].Value = crd1[0];
            dataGridView2.Rows[0].Cells[1].Value = crd1[1];
            dataGridView2.Rows[1].Cells[0].Value = crd2[0];
            dataGridView2.Rows[1].Cells[1].Value = crd2[1];
            B[0,0] = int.Parse(crd1[0]);
            B[0,1] = int.Parse(crd1[1]);
            B[1,0] = int.Parse(crd2[0]);
            B[1,1] = int.Parse(crd2[1]);

            dataGridView3.Rows.Add("");
            dataGridView3.Rows[0].Cells[0].Value = A[0,0]+B[0,0];
            dataGridView3.Rows[0].Cells[1].Value = A[0,1]+B[0,1];
            dataGridView3.Rows[1].Cells[0].Value = A[1,0]+B[1,0];
            dataGridView3.Rows[1].Cells[1].Value = A[1,1]+B[1,1];

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 50;
                dataGridView2.Rows[i].Height = 50;
                dataGridView3.Rows[i].Height = 50;
            }
        }
    }
}
