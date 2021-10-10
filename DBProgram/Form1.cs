using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonComboBoxCalculate_Click(object sender, EventArgs e)
        {
            string oper1 = textBoxComboCalc_oper1.Text;
            string oper2 = textBoxComboCalc_oper2.Text;
            string oper = "";

            switch (comboBoxComboCalc_operater.SelectedIndex)
            {
                case 0: oper = Convert.ToString(Convert.ToInt32(oper1) + Convert.ToInt32(oper2)); break;
                case 1: oper = Convert.ToString(Convert.ToInt32(oper1) - Convert.ToInt32(oper2)); break;
                case 2: oper = Convert.ToString(Convert.ToInt32(oper1) * Convert.ToInt32(oper2)); break;
                case 3: oper = Convert.ToString(Convert.ToInt32(oper1) / Convert.ToInt32(oper2)); break;
            }
            textBoxComboCalc_result.Text = oper;
        }

        private void buttonRadioCalculate_Click(object sender, EventArgs e)
        {
            string oper1 = textBoxRadioCalc_oper1.Text;
            string oper2 = textBoxRadioCalc_oper2.Text;
            string oper = "";
            if (radioButtonCalc_1.Checked) oper = Convert.ToString(Convert.ToInt32(oper1) + Convert.ToInt32(oper2)); 
            if (radioButtonCalc_2.Checked) oper = Convert.ToString(Convert.ToInt32(oper1) - Convert.ToInt32(oper2));
            
            textBoxRadioCalc_result.Text = oper;
        }

       
    }
}
