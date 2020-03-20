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
****************************************************************************/
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
    public partial class Determinant : Form
    {
        //FIELDS
        double[,] matrix = new double[3, 3];
        double det;

        //METHODS
        public Determinant()
        {
            InitializeComponent();
        }

        private void Determinant_Load(object sender, EventArgs e)
        {

        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region READ DATA
                matrix[0, 0] = Convert.ToDouble(A11.Text);
                matrix[0, 1] = Convert.ToDouble(A12.Text);
                matrix[0, 2] = Convert.ToDouble(A13.Text);
                matrix[1, 0] = Convert.ToDouble(A21.Text);
                matrix[1, 1] = Convert.ToDouble(A22.Text);
                matrix[1, 2] = Convert.ToDouble(A23.Text);
                matrix[2, 0] = Convert.ToDouble(A31.Text);
                matrix[2, 1] = Convert.ToDouble(A32.Text);
                matrix[2, 2] = Convert.ToDouble(A33.Text);
                #endregion
            } catch(System.FormatException)
            {

                MessageBox.Show("ALL THE COLUMNS SHOULD BE FILLED", "TYPE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            det = Matrix.Det33(matrix);
            Det.Text = det.ToString();
               
        }
    }
}
