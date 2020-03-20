/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLİŞİM SİSTEMLERİ  MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI: 1
**				ÖĞRENCİ ADI: YAYA USMAN ADAIZA
**				ÖĞRENCİ NUMARASI: B181200557
**              DERSİN ALINDIĞI GRUP: A
****************************************************************************/﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix3X3
{
    public partial class BasicOp : Form
    {

        //FILEDS
        double[,] matrix1 = new double[3, 3];
        double[,] matrix2 = new double[3, 3];
        double[,] result = new double[3, 3];
        //METHODS
        public BasicOp()
        {
            InitializeComponent();
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BasicOp_Load(object sender, EventArgs e)
        {
            if (Form1.add)
            {
                this.Text = "ADDITION";
                labelOp.Text = "+";
            }

            if (Form1.sub)
            {
                this.Text = "SUBTRACTION";
                labelOp.Text = "-";
            }

            if(Form1.mult)
            {
                this.Text = "MULTIPLICATION";
                labelOp.Text = "x";
            }
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            //var

            //code
            try
            {
                #region READ DATA
                //read the data from the user and save it in a matrix
                matrix1[0, 0] = Convert.ToDouble(A11.Text);
                matrix1[0, 1] = Convert.ToDouble(A12.Text);
                matrix1[0, 2] = Convert.ToDouble(A13.Text);
                matrix1[1, 0] = Convert.ToDouble(A21.Text);
                matrix1[1, 1] = Convert.ToDouble(A22.Text);
                matrix1[1, 2] = Convert.ToDouble(A23.Text);
                matrix1[2, 0] = Convert.ToDouble(A31.Text);
                matrix1[2, 1] = Convert.ToDouble(A32.Text);
                matrix1[2, 2] = Convert.ToDouble(A33.Text);

                matrix2[0, 0] = Convert.ToDouble(B11.Text);
                matrix2[0, 1] = Convert.ToDouble(B12.Text);
                matrix2[0, 2] = Convert.ToDouble(B13.Text);
                matrix2[1, 0] = Convert.ToDouble(B21.Text);
                matrix2[1, 1] = Convert.ToDouble(B22.Text);
                matrix2[1, 2] = Convert.ToDouble(B23.Text);
                matrix2[2, 0] = Convert.ToDouble(B31.Text);
                matrix2[2, 1] = Convert.ToDouble(B32.Text);
                matrix2[2, 2] = Convert.ToDouble(B33.Text);
                #endregion

                // sum of the matrix
                if (Form1.add)
                    result = Matrix.Addition(matrix1, matrix2, 3);
                if (Form1.sub)
                    result = Matrix.Subtraction(matrix1, matrix2, 3);
                if (Form1.mult)
                    result = Matrix.Multiplication(matrix1, matrix2, 3, 3);

                #region WRITE DATA
                // show out the result matrix 

                C11.Text = result[0, 0].ToString();
                C12.Text = result[0, 1].ToString();
                C13.Text = result[0, 2].ToString();

                C21.Text = result[1, 0].ToString();
                C22.Text = result[1, 1].ToString();
                C23.Text = result[1, 2].ToString();

                C31.Text = result[2, 0].ToString();
                C32.Text = result[2, 1].ToString();
                C33.Text = result[2, 2].ToString();
                #endregion
            }
            catch(System.FormatException)
            {
                MessageBox.Show("ALL THE COLUMNS SHOULD BE FILLED", "TYPE ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
