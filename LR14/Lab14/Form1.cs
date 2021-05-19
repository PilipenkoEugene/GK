using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Лабораторная Работа №14";
            CenterToScreen();
            toolStripComboBoxA.SelectedIndex = 0;
            toolStripComboBoxB.SelectedIndex = 0;
            currentCheckedItem = toolStripMenuItemEquation1;
            currentCheckedItem.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(toolStripTextBoxX.Text);
                double y = Convert.ToDouble(toolStripTextBoxY.Text);
                double z = Convert.ToDouble(toolStripTextBoxZ.Text);
                double a = Convert.ToDouble(toolStripComboBoxA.Text);
                double b = Convert.ToDouble(toolStripComboBoxB.Text);

                double val = (a*z + b*y + Math.Sin(z)) / (a + b);
                this.Text = String.Format("Результат = {0:0.000}", val);
                MessageBox.Show(String.Format("Результат = {0:0.000}", val));
            }
            catch
            {
                MessageBox.Show("ERROR!", "Введите корректные значения!!!");
            }

        }
        ToolStripMenuItem currentCheckedItem;


        private void toolStripMenuItemEquation1_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            currentCheckedItem = toolStripMenuItemEquation2;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemEquation2_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            currentCheckedItem = toolStripMenuItemEquation2;
            currentCheckedItem.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double x = e.X;
            double y = e.Y;


            if (currentCheckedItem == toolStripMenuItemEquation1)
            {
                double ans = Math.Sqrt(Math.Abs(x*x*x - y*y));
                toolStripStatusLabelState.Text = String.Format("№1. Результат = {0:0.000}", ans);
            }
            if (currentCheckedItem == toolStripMenuItemEquation2)
            {
                double ans = Math.Sin(x);
                toolStripStatusLabelState.Text = String.Format("№2. Результат = {0:0.000}", ans);
            }
        }
    }
}
