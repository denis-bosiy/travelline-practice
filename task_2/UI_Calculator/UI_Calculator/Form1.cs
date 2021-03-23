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

        private void ClearNumber(object sender, EventArgs e)
        {
            number.Text = "0";
        }

        private void AddDigit(object sender, EventArgs e)
        {
            if (number.Text != "0")
            {
                number.Text = number.Text + (sender as Button).Text;
            }
            else
            {
                number.Text = (sender as Button).Text;
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

        private void CalcTopPriorityOperation(ref List<int> newNumbers, int secondOperand, string operation)
        {
            var currNumber = newNumbers[newNumbers.Count - 1];
            newNumbers.RemoveAt(newNumbers.Count - 1);
            if (operation == "/")
            {
                newNumbers.Add(currNumber / secondOperand);
            }
            else
            {
                newNumbers.Add(currNumber * secondOperand);
            }
        }

        private void CalcTopPriorityOperations(ref List<int> oldNumbers, ref List<int> newNumbers, 
                                               ref List<string> oldOperations, ref List<string> newOperations)
        {
            for (int i = 0; i < oldOperations.Count; i++)
            {
                if (i > 0)
                {
                    if ((oldOperations[i - 1] == "+") || (oldOperations[i - 1] == "-"))
                    {
                        newNumbers.Add(oldNumbers[i]);
                    }
                }
                else
                {
                    newNumbers.Add(oldNumbers[i]);
                }
                if ((oldOperations[i] == "/") || (oldOperations[i] == "x"))
                {
                    CalcTopPriorityOperation(ref newNumbers, oldNumbers[i + 1], oldOperations[i]);
                }
                else
                {
                    newOperations.Add(oldOperations[i]);
                }
            }
            if ((oldOperations[oldOperations.Count - 1] == "+") || (oldOperations[oldOperations.Count - 1] == "-"))
            {
                newNumbers.Add(oldNumbers[oldNumbers.Count - 1]);
            }
        }

        private void CalcLowPriorityOperations(ref List<int> newNumbers, ref List<string> newOperations, ref int result)
        {
            result = newNumbers[0];
            for (int i = 0; i < newOperations.Count; i++)
            {
                if (newOperations[i] == "+")
                {
                    result = result + newNumbers[i + 1];
                }
                if (newOperations[i] == "-")
                {
                    result = result - newNumbers[i + 1];
                }
            }
        }

        private void CalcExpression(object sender, EventArgs e)
        {
            List<int> tempNumbers = new List<int>();
            List<string> tempOperations = new List<string>();
            expression.Text = expression.Text + number.Text;
            numbers.Add(Convert.ToInt32(number.Text));

            CalcTopPriorityOperations(ref numbers, ref tempNumbers, ref operations, ref tempOperations);
            int result = 0;
            CalcLowPriorityOperations(ref tempNumbers, ref tempOperations, ref result);

            expression.Text = "";
            number.Text = result.ToString();
            numbers = new List<int>();
            operations = new List<string>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
