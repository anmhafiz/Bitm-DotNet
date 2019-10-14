using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class MCalculator : Form
    {
        public MCalculator()
        {
            InitializeComponent();
        }

        Math math = new Math();


        public void Add_Click(object sender, EventArgs e)
        {
             
            string f = firstNumberTextBox.Text;
            string s = secondNumberTextBox.Text;
          
            math.Set(Convert.ToDouble(f), Convert.ToDouble(s));

            double result =  math.GetAdd();
            resultTextBox.Text = result.ToString();



        }

        private void substractTextBox_Click(object sender, EventArgs e)
        {
            string f = firstNumberTextBox.Text;
            string s = secondNumberTextBox.Text;

            math.Set(Convert.ToDouble(f), Convert.ToDouble(s));

            double result = math.GetSub();
            resultTextBox.Text = result.ToString();
        }

        private void multipicationTextBox_Click(object sender, EventArgs e)
        {
            string f = firstNumberTextBox.Text;
            string s = secondNumberTextBox.Text;
            math.Set(Convert.ToDouble(f), Convert.ToDouble(s));
            double result = math.GetMulti();
            resultTextBox.Text = result.ToString();

        }

        private void divisionTextBox_Click(object sender, EventArgs e)
        {

            string f = firstNumberTextBox.Text;
            string s = secondNumberTextBox.Text;
            math.Set(Convert.ToDouble(f), Convert.ToDouble(s));
            double result = math.GetDiv();
            resultTextBox.Text = result.ToString();



        }
    }
}
