using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        float e_2, arg_3, value_t, b, w;
        double v;

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value_t = System.Convert.ToSingle(textBoxF.Text);
                b = System.Convert.ToSingle(textBox2.Text);
                w = System.Convert.ToSingle(textBox1.Text);
                v = ComputeValue(e_2, arg_3, value_t, b, w);
                Text = GetStringResult(v);
            }
            catch
            {
                Text = "ERROR";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            e_2 = e.X;
            arg_3 = e.Y;
            v = ComputeValue(e_2, arg_3, value_t, b, w);
            Text = GetStringResult(v);

            textBoxH.Text = e.X.ToString();
            textBoxD.Text = e.Y.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        double ComputeValue(float e_2, float arg_3, float t, float b, float w)
        {
            double result = Math.Sqrt(Math.Abs((t * e_2) / Math.Pow(w, e_2))) + Math.Sqrt(Math.Abs(arg_3)) - Math.Abs(e_2*e_2 + Math.Cos(arg_3));
            return result;
        }

        string GetStringResult(double num)
        {
            if (Double.IsInfinity(num) || Double.IsNaN(num))
            {
                return "ERROR";
            }
            else
            {
                return string.Format("Z = {0:0.00}", num);
            }
        }
    } 
}
