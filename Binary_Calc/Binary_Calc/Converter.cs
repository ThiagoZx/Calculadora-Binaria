using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calc
{
    class Converter
    {
        public string Cvtr_binToDec(string number) {
           
            char[] dec_number = number.ToCharArray();
            Array.Reverse(dec_number);

            double result = 0;

            for ( int i = 0 ; i < dec_number.Length ; i++ ) {
                int number_int = Convert.ToInt32(dec_number[i] - '0');
                result = result + number_int * (Math.Pow(2, i));
            }

            return result.ToString();
        }
    }
}
