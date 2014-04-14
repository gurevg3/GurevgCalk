using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GurevgCalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adder_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = (first + second).ToString();
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = (first - second).ToString();
        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = (first * second).ToString();
        }

        private void Devision_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = (first / second).ToString();
        }

    }
}
