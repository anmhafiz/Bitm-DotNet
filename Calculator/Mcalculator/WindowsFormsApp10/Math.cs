using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    
   public class Math

    {
        public double firstNumberTextBox;
        public double secondNumberTextBox;
        public double resultTextBox;
       
        public void Set(double n1,double n2)
        {
            firstNumberTextBox = n1;
            secondNumberTextBox = n2;
        }
        public double GetAdd()
        {

            resultTextBox = firstNumberTextBox + secondNumberTextBox;
            return resultTextBox;


        }

        public double GetSub()
        {

            resultTextBox = firstNumberTextBox - secondNumberTextBox;
            return resultTextBox;

        }

        public double GetMulti()
        {

            resultTextBox = firstNumberTextBox * secondNumberTextBox;
            return resultTextBox;

        }


        public double GetDiv()
        {

            resultTextBox = firstNumberTextBox / secondNumberTextBox;
            return resultTextBox;

        }



    }
}
