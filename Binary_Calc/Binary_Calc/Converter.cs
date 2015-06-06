using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calc
{
    class Converter
    {
        private string adjustStr(string str) {
            while (str[0] == '0' && str.Length != 1) {
                str = str.Substring(1);
            }

            return str;
        }
        private string returnHex(char[] chr, int block){

            int power = 0;
            double[] chr_char = new double[4];

            for(int i = (4 * block) - 4; i < 4 * block; i++){
                try {
                    int number_int = Convert.ToInt32(chr[i] - '0');
                    chr_char[power] = number_int * (Math.Pow(2, power));
                    power++;
                } catch {
                }
           }

            double result = chr_char.Sum();

            switch ((int)result) {
                    case 10: return "A";
                    case 11: return "B";
                    case 12: return "C";
                    case 13: return "D";
                    case 14: return "E";
                    case 15: return "F";
                    default: return result.ToString();
                }
        }

        public string Cvtr_binToDec(string number) {

            bool isNegative = false;

            if (number[0] == '-') {
                number = number.Substring(1);
                isNegative = true;
            }

            char[] dec_number = number.ToCharArray();
            Array.Reverse(dec_number);

            double result = 0;

            for ( int i = 0 ; i < dec_number.Length ; i++ ) {
                int number_int = Convert.ToInt32(dec_number[i] - '0');
                result = result + number_int * (Math.Pow(2, i));
            }

            string strResult = result.ToString();

            if (isNegative) {
               strResult = "-" + strResult;
            }

            return strResult;
        }

        public string Cvtr_binToHex(string number) {
            bool isNegative = false;

            if (number[0] == '-') {
                number = number.Substring(1);
                isNegative = true;
            }

            int limit = number.Length % 4;

            for (int i = 0; i < 4 - limit; i++) {
                number = "0" + number;
            }

            char[] hex_char = number.ToCharArray();
            Array.Reverse(hex_char);
            string result = "";

            for(int i = 1; i < (number.Length + limit / 4) + 1; i++){
                result = returnHex(hex_char, i) + result;
            }

            if (isNegative) {
                result = "-" + result;
            }

            result = adjustStr(result);
            return result;
        }
    }
}
