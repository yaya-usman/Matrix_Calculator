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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix3X3
{
    static class Matrix
    {
        public static double[,] Addition(double[,] matrix1,double[,] matrix2,int r)
        {
            //var
            double[,] Add = new double[3,3];
            //code
            for(int i=0;i<r; i++)
            {
                for(int j=0;j<r;j++)
                {
                    Add[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return Add;
        }

        public static double[,] Subtraction(double[,] matrix1, double[,] matrix2,int r)
        {
            //var
            double[,] Sub = new double[3, 3];
            //code
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j<r; j++)
                {
                    Sub[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return Sub;
        }

        public static double[,] Multiplication(double[,] matrix1 , double[,] matrix2,int r,int c)
        {
            //var
            double[,] Mult = new double[r,c];
            double sum;
            //code
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    sum = 0;
                    for (int k = 0; k < r; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    Mult[i, j] = sum;
                }
            }

            return Mult;
        }


        public static double Det33(double [,] matrix)
        {
            //var
            double det=0;
            //code

            det = ((matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                (matrix[1, 0] * matrix[2, 1] * matrix[0, 2]) +
                (matrix[2, 0] * matrix[0, 1])) - ((matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) +
                                            (matrix[1, 2] * matrix[2, 1] * matrix[0, 0]) +
                                             (matrix[2, 2] * matrix[0, 1]));
            return det;
        }

        public static double[,] Transpose(double[,] matrix,int r,int c)
        {
            //var
            double[,] transpose = new double[r, c];
            //code
            for(int i=0;i<r;i++)
            {
                for (int j = 0; j < c; j++)
                    transpose[i, j] = matrix[j, i];
            }

            return transpose;
        }
    }
}
