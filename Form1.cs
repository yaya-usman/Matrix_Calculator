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
    public partial class Form1 : Form
    {
        //FIELDS
        public static bool add = false;
        public static bool sub = false;
        public static bool mult = false;

        //METHODS
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1.add = true;
            Form1.sub = false;
            BasicOp add = new BasicOp();
            this.Hide();
            add.ShowDialog();
            this.Show();
            
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            Form1.sub = true;
            Form1.add = false;
            Form1.mult = false;
            BasicOp add = new BasicOp();
            this.Hide();
            add.ShowDialog();
            this.Show();
           
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            Form1.sub = false;
            Form1.add = false;
            Form1.mult = true;
            BasicOp add = new BasicOp();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void DetBtn_Click(object sender, EventArgs e)
        {
            Determinant Det = new Determinant();
            this.Hide();
            Det.ShowDialog();
            this.Show();
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            Transpose Trans = new Transpose();
            this.Hide();
            Trans.ShowDialog();
            this.Show();
        }
    }
}
