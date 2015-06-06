using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Calc
{
    public partial class Form1 : Form
    {
        Operations Operator = new Operations();
        Converter Converter = new Converter();

        private string inputNbr_1;
        private string inputNbr_2;

        private string operation = "";

        private string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void cleanCalc(bool every) {
            inputNbr_1 = "";
            inputNbr_2 = "";
            operation = "";
            result = "";
            Input.Text = "0";
            if (every) {
                BinResult.Text = "";
                DecResult.Text = "";
                HexResult.Text = "";
            }
        }

        private void numberBtn_Click(object sender, EventArgs e) {
            Button button = sender as Button;
            if (Input.Text.Length == 1 && Input.Text[0] == '0')
                Input.Text = "";
            Input.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e) {
            Button button = sender as Button;
            inputNbr_1 = Input.Text;
            Input.Text = "0";
            operation = button.Text;
        }

        private void Result_Click(object sender, EventArgs e) {
            inputNbr_2 = Input.Text;

            switch (operation) {
                case "+":
                    result = Operator.operation_Sum(inputNbr_1, inputNbr_2);
                    BinResult.Text = result;
                    DecResult.Text = Converter.Cvtr_binToDec(result);
                    HexResult.Text = Converter.Cvtr_binToHex(result);
                    break;
                case "-":
                    result = Operator.operation_Subtraction(inputNbr_1, inputNbr_2);
                    BinResult.Text = result;
                    DecResult.Text = Converter.Cvtr_binToDec(result);
                    HexResult.Text = Converter.Cvtr_binToHex(result);
                    break;
                case "/":
                    result = Operator.operation_Division(inputNbr_1, inputNbr_2, "0");
                    BinResult.Text = result;
                    DecResult.Text = Converter.Cvtr_binToDec(result);
                    HexResult.Text = Converter.Cvtr_binToHex(result);
                    break;
                case "x":
                    result = Operator.operation_Multiplication(inputNbr_1, inputNbr_2);
                    BinResult.Text = result;
                    DecResult.Text = Converter.Cvtr_binToDec(result);
                    HexResult.Text = Converter.Cvtr_binToHex(result);
                    break;
            }

            cleanCalc(false);
        }

        private void Clean_Click(object sender, EventArgs e) {
            cleanCalc(true);
        }
    }
}
