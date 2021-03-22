using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Calculator
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<string> operations = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddFirstDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "1";
            }
            else
            {
                number.Text = "1";
            }
        }

        private void AddSecondDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "2";
            }
            else
            {
                number.Text = "2";
            }
        }

        private void AddThirdDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "3";
            }
            else
            {
                number.Text = "3";
            }
        }

        private void AddFourthDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "4";
            }
            else
            {
                number.Text = "4";
            }
        }

        private void AddFifthDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "5";
            }
            else
            {
                number.Text = "5";
            }
        }

        private void AddSixthDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "6";
            }
            else
            {
                number.Text = "6";
            }
        }

        private void AddSeventhDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "7";
            }
            else
            {
                number.Text = "7";
            }
        }

        private void AddEightDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "8";
            }
            else
            {
                number.Text = "8";
            }
        }

        private void AddNinthDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "9";
            }
            else
            {
                number.Text = "9";
            }
        }

        private void ClearNumber(object sender, EventArgs e)
        {
            number.Text = "0";
        }

        private void AddZeroDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + "0";
            }
        }

        private void InvertNumber(object sender, EventArgs e)
        {
            if (number.Text[0] == '-')
            {
                number.Text = number.Text.Substring(1, number.Text.Length-1);
            } else
            {
                number.Text = number.Text + '-';
            }
        }

        private void AddComma(object sender, EventArgs e)
        {
            if (!number.Text.Contains(','))
            {
                number.Text = number.Text + ',';
            }
        }

        private void AddOperation(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToInt32(number.Text));
            operations.Add((sender as Button).Text);
            if (expression.Text == "")
            {
                expression.Text = number.Text + (sender as Button).Text + expression.Text;
            } else
            {
                expression.Text = expression.Text + number.Text + (sender as Button).Text;
            }
            number.Text = "0";
        }

        private void ClearExpression(object sender, EventArgs e)
        {
            expression.Text = "";
            number.Text = "0";
            numbers = new List<int>();
            operations = new List<string>();
        }

        private void CalcExpression(object sender, EventArgs e)
        {
            List<int> tempNumbers = new List<int>();
            List<string> tempOperations = new List<string>();
            expression.Text = expression.Text + number.Text;
            numbers.Add(Convert.ToInt32(number.Text));
            
            for(int i = 0; i < operations.Count; i++)
            {
                if ( (operations[i] == "/") || (operations[i] == "*") )
                {
                    if (operations[i] == "/")
                    {
                        tempNumbers.Add(numbers[i] / numbers[i + 1]);
                    } else
                    {
                        tempNumbers.Add(numbers[i] * numbers[i + 1]);
                    }
                } else
                {
                    if (i > 0)
                    {
                        if (!((operations[i-1] == "/") || (operations[i-1] == "*")))
                        {
                            tempNumbers.Add(numbers[i]);
                        }
                    }
                    tempNumbers.Add(numbers[i]);
                    tempOperations.Add(operations[i]);
                }
            }

            int result = 0;
            for(int i = 0; i < operations.Count; i++)
            {
                if (operations[i] == "+")
                {
                    result = result + tempNumbers[i] + tempNumbers[i + 1];
                }
                if (operations[i] == "-")
                {
                    result = result + tempNumbers[i] - tempNumbers[i + 1];
                }
            }
            expression.Text = "";
            number.Text = result.ToString();

        }
    }
}
