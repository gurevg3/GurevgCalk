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
            AdderClass adderClass = new AdderClass();
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text =adderClass.Calculate(first,second).ToString();
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            SubClass subClass = new SubClass();
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = subClass.Calculate(first,second).ToString();
        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {
            MultiClass multiClass = new MultiClass();
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = multiClass.Calculate(first,second).ToString();
        }

        private void Devision_Click(object sender, EventArgs e)
        {
            DevisClass devisClass = new DevisClass();
            double first = Convert.ToDouble(Operand1.Text);
            double second = Convert.ToDouble(Operand2.Text);
            Result.Text = devisClass.Calculate(first,second).ToString();
        }

    }
}
