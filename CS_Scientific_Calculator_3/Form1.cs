using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Scientific_Calculator_3
{
    public partial class Form1 : Form
    {
        double result;
        string aritmeticOperator;
        double firstNumber;
        bool isOperatorClick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScientificTextBoksHaHa.Text ="0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ScientificTextBoksHaHa.Text = "0";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int index = ScientificTextBoksHaHa.Text.Length;
            index--;
            ScientificTextBoksHaHa.Text = ScientificTextBoksHaHa.Text.Remove(index);
            if (ScientificTextBoksHaHa.Text  == string.Empty)
            {
                ScientificTextBoksHaHa.Text = "0";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            result = double.Parse(ScientificTextBoksHaHa.Text);
            result = result * -1;
            ScientificTextBoksHaHa.Text = result.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            firstNumber =double.Parse (ScientificTextBoksHaHa.Text);
            Button btn = (Button)sender;
            aritmeticOperator = btn.Text;
            isOperatorClick = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            switch(aritmeticOperator)
            {
                case "+":
                    ScientificTextBoksHaHa.Text = (firstNumber + double.Parse(ScientificTextBoksHaHa.Text)).ToString();
                    break;
                case "-":
                    ScientificTextBoksHaHa.Text = (firstNumber - double.Parse(ScientificTextBoksHaHa.Text)).ToString();
                    break;
                case "*":
                    ScientificTextBoksHaHa.Text = (firstNumber * double.Parse(ScientificTextBoksHaHa.Text)).ToString();
                    break;
                case "/":
                    ScientificTextBoksHaHa.Text = (firstNumber / double.Parse(ScientificTextBoksHaHa.Text)).ToString();
                    break;
                case "EXP": // exp calculation
                    double pow = double.Parse(ScientificTextBoksHaHa.Text);
                    double ans = Math.Exp(pow*Math.Log(firstNumber * 4));
                    ScientificTextBoksHaHa.Text = ans.ToString();
                    break;                                              // EXP Formula is right here4
                case "MOD":
                    ScientificTextBoksHaHa.Text = (firstNumber % double.Parse(ScientificTextBoksHaHa.Text)).ToString(); 
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (ScientificTextBoksHaHa.Text == "0" || isOperatorClick)
                ScientificTextBoksHaHa.Clear();
            isOperatorClick = false;

            Button button = (Button)sender;
            if( button.Text == ".")
            {
                if (!ScientificTextBoksHaHa.Text.Contains("."))
                ScientificTextBoksHaHa.Text += button.Text;
            }
            else
            {
                ScientificTextBoksHaHa.Text += button.Text;
            }
            
            



        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            this.Text = "Scientific Calculator by Mustafa Alparslan Pamuk";
            TitleLabel.Text = string.Empty;
            this.Width = 584;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 584;
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 911;
        }

        private void multiplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1238;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = string.Empty;
            double val = Math.PI;
            ScientificTextBoksHaHa.Text = val.ToString();
            TitleLabel.Text = "PI";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "LOG (" + val + ")";
            val = Math.Log10(val);
            ScientificTextBoksHaHa.Text = val.ToString();
            
        }

        private void button44_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "Square root (" + val + ")";
            val = Math.Sqrt(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = val + " ^ 2";
            val = Math.Pow(val, 2);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "SinH (" + val + ")";
            val = Math.Sinh(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "Sin (" + val + ")"; 
            val = Math.Sin(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(ScientificTextBoksHaHa.Text);
                TitleLabel.Text = "DECIMAL (" + ScientificTextBoksHaHa.Text + ")"; 
                ScientificTextBoksHaHa.Text = System.Convert.ToString(a, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = " ^ 3 (" + val + ")";
            val = Math.Pow(val, 3);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "CosH (" + val + ")";
            val = Math.Cosh(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "Cos (" + val + ")"; 
            val = Math.Cos(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(ScientificTextBoksHaHa.Text);
                TitleLabel.Text = "HEXADECIMAL (" + ScientificTextBoksHaHa.Text + ")";
                ScientificTextBoksHaHa.Text = System.Convert.ToString(a, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            val = 1 / val;
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "TanH (" + val + ")";
            val = Math.Tanh(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "Tan (" + val + ")";
            val = Math.Tan(val);
            ScientificTextBoksHaHa.Text = val.ToString();
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(ScientificTextBoksHaHa.Text);
                TitleLabel.Text = "BINARY (" + ScientificTextBoksHaHa.Text + ")";
                ScientificTextBoksHaHa.Text = System.Convert.ToString(a, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "ln (" + val + ")";
            val = Math.Log(val);
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(ScientificTextBoksHaHa.Text);
                TitleLabel.Text = "OCTAL (" + ScientificTextBoksHaHa.Text + ")";
                ScientificTextBoksHaHa.Text = System.Convert.ToString(a, 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double val = double.Parse(ScientificTextBoksHaHa.Text);
            TitleLabel.Text = "PERCENTAGE (" + val + ")";
            val = val / 100;
            ScientificTextBoksHaHa.Text = val.ToString();
        }

        private void MultiplyTableButton_Click(object sender, EventArgs e)
        {
            TableRichTextBox.Clear();
            float number = 0f;
            if (NumberTableTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter any number to calculate Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                number = Convert.ToSingle(NumberTableTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                TableRichTextBox.Text += number + " * " + i + " = " + number * i + "\n"; 
            }
        }

        private void ResetTableButton_Click(object sender, EventArgs e)
        {
            TableRichTextBox.Clear();
            NumberTableTextBox.Clear();
            NumberTableTextBox.Focus();
        }

        private void CeltoFahRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TemperatureConvertButton_Click(object sender, EventArgs e)
        {
            ConversionTextBox.Clear();
            float number = 0f;
            if (TemperatureTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a temperature value that you wish to convert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                number = Convert.ToSingle(TemperatureTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CeltoFahRadioButton.Checked)
            {
                ConversionTextBox.Text = ((number * 9  / 5) + 32).ToString();
            }
            if (FahtoCelRadioButton.Checked)
            {
                ConversionTextBox.Text = ((number - 32) * 5 / 9).ToString();
            }
            if (KeltoCelRadioButton.Checked)
            {
                ConversionTextBox.Text = (number - 273.15).ToString();
            }
            if (KeltoFahRadioButton.Checked)
            {
                ConversionTextBox.Text = ((number - 273.15) * 9 / 5 + 32).ToString();
            }
        }

        private void ResetTemperatureButton_Click(object sender, EventArgs e)
        {
            ConversionTextBox.Clear();
            TemperatureTextBox.Clear();
            TemperatureTextBox.Focus();
        }

        private void ScientificTextBoksHaHa_TextChanged(object sender, EventArgs e)
        {
            Common.history.Add(ScientificTextBoksHaHa.Text);
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void KeltoFahRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {

                MessageBox.Show("This part will be yours soon! :)", "We are sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
