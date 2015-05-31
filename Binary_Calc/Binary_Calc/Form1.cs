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
        Operations a = new Operations();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = a.operation_Subtraction("11011", "1011");
            label1.Text = b;
        }
    }
}
