using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calc {
    class Operations {

        //Funções complementares as operações

        private string evenStr(string str, int even_limit, string operation) {
       
            int strLength = str.Length;
            
            for (int i = 0; i < even_limit - strLength; i++) {
                str = "0" + str;
            }

            if (operation == "sum") {
                return stringReverse(str);
            } else {
                return str;
            }
        }

        private string adjustStr(string str) {
            while (str[0] == '0' && str.Length != 1) {
                str = str.Substring(1);
            }

            return str;
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

        private string complementNumber(string number) {
            char[] numberChar = number.ToCharArray();
            
            for (int i = 0; i < number.Length; i++) {
                if (numberChar[i] == '0') {
                    numberChar[i] = '1';
                } else { numberChar[i] = '0'; }
            }

            string result = new string(numberChar);
            result = operation_Sum(result, "1");

            return result;
        }

        private bool divCheck(string a, string b) {

            int limit = a.Length > b.Length ? limit = a.Length : limit = b.Length;

            a = evenStr(a, limit, "subtr"); //ex. 110 --> 110
            b = evenStr(b, limit, "subtr"); //ex.   1 --> 001

            bool isFirstBigger = Convert.ToInt32(a[0]) >= Convert.ToInt32(b[0]) ? isFirstBigger = true : isFirstBigger = false;
            return isFirstBigger;

        }

        //Operações

        public string operation_Sum(string a, string b) {

            int even_limit = a.Length >= b.Length ? even_limit = a.Length : even_limit = b.Length;

            a = evenStr(a, even_limit, "sum");
            b = evenStr(b, even_limit, "sum");

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

            return adjustStr(result);

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

        public string operation_Subtraction(string a, string b) {

            int limit = a.Length > b.Length ? limit = a.Length : limit = b.Length;

            a = evenStr(a, limit, "subtr"); //ex. 110 --> 110
            b = evenStr(b, limit, "subtr"); //ex.   1 --> 001

            bool isFirstBigger = Convert.ToInt32(a[0]) >= Convert.ToInt32(b[0]) ? isFirstBigger = true : isFirstBigger = false;

            if (isFirstBigger) {
                string complementedNumber = complementNumber(b);
                string partialResult = operation_Sum(a, complementedNumber);
                partialResult = partialResult.Substring(1);
                string result = adjustStr(partialResult);
                return result;
            } else {
                string complementedNumber = complementNumber(a);
                string partialResult = operation_Sum(b, complementedNumber);
                partialResult = partialResult.Substring(1);
                string result = "-" + adjustStr(partialResult);
                return result;
            }
        }

        public string operation_Division(string a, string b, string result) { 

            string c = operation_Subtraction(a, b);

            if(Convert.ToInt32(c) >= 0){
                result = operation_Sum(result, "1");
                return operation_Division(c, b, result);
            } else {
                result = operation_Sum(result, "1");
                return result;
            }
        }
    }
}