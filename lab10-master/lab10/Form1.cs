using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10_14_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] arr = new int[15];
            int summ = 0;
            Random r = new Random();
            txtArray.Text = "Массив: ";
            for (int i = 0;i < arr.Length;i++)
            {
                arr[i] = r.Next(20);
                summ += arr[i];
            }
            Array.Sort(arr);
            for (int i = 0;i < arr.Length;i++)
            {
                txtArray.Text += arr[i].ToString() + " ";
            }
            txtArray.Text += "\r\nСумма массива: " + summ.ToString();
            txtArray.Text += "\r\nСреднее арифметическое значение: " + (summ/arr.Length).ToString();
            txtArray.Text += "\r\nМаксимальное число " + (arr.Max()).ToString();
            txtArray.Text += "\r\nМинимальное число " + (arr.Min()).ToString();







        }
    }
}
