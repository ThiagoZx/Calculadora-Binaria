using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calc {
    class Operations {

        private string evenStr(string str, int even_limit) {
       
            int strLength = str.Length;
            
            for (int i = 0; i < even_limit - strLength; i++) {
                str = "0" + str;
            }
            return stringReverse(str);
        }

        private string stringReverse(string str) {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);            
        }

        private void carry(char[] array, int index) {
            switch (array[index]) {
                case '0':
                    array[index] = '0';
                    break;

                case '1':
                    array[index] = '1';
                    break;

                case '2':
                    array[index] = '0';
                    array[index + 1] = '1';
                    break;

                case '3':
                    array[index] = '1';
                    array[index + 1] = '1';
                    break;

                default:
                    break;
            }
        }


        //Operações

        public string operation_Sum(string a, string b) {

            int even_limit = a.Length >= b.Length ? even_limit = a.Length : even_limit = b.Length;

            a = evenStr(a, even_limit);
            b = evenStr(b, even_limit);

            char[] num_1 = a.ToCharArray();
            char[] num_2 = b.ToCharArray();
            char[] num_result = new char[num_1.Length + 1];

            for (int i = 0; i < num_result.Length; i++) {
                num_result[i] = '0';
            }

            for (int i = 0; i < num_1.Length; i++) {
                int sum_a = num_1[i] - '0';
                int sum_b = num_2[i] -'0';
                int sum_c = num_result[i] -'0';
                num_result[i] = Convert.ToChar(sum_a + sum_b + sum_c + 48);
                carry(num_result, i);
            }

            Array.Reverse(num_result);
            string result = new string(num_result);

            while (result[0] == '0' && result.Length != 1) {
                result = result.Substring(1);
            }

            return result;

        }

        public string operation_Multiplication(string a, string b) {

            string[] partialResults = new string[b.Length];

            string result = "0";
            char[] multiplicandChar = a.ToCharArray();
            char[] multiplierChar = b.ToCharArray();

            Array.Reverse(multiplicandChar);           
            Array.Reverse(multiplierChar);

            for (int i = 0; i < b.Length; i++) {
                int numberChar_1 = Convert.ToInt32(multiplierChar[i]) - '0';
                char[] pResults = new char[multiplicandChar.Length];
                Array.Copy(multiplicandChar, pResults, pResults.Length);

                for (int j = 0; j < a.Length; j++) { 
                    int numberChar_2 = Convert.ToInt32(pResults[j]) - '0';
                    pResults[j] = Convert.ToChar(numberChar_1 * numberChar_2 + 48);
                }

                Array.Reverse(pResults);
                partialResults[i] = new string(pResults);

                for (int k = 0; k < i; k++) {
                    partialResults[i] = partialResults[i] + "0";
                }

                result = operation_Sum(result, partialResults[i]);
            }

            return result;
        }

    }
}