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
        Converter b = new Converter();

        public Form1()
        {
            InitializeComponent();
        }

        private void numberBtn_Click(object sender, EventArgs e) {
            Button button = sender as Button;
            Input.Text += button.Text;
        }
    }
}
