using System.Security.AccessControl;

namespace calculator
{
    public partial class calculator : Form
    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public calculator()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput;
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput;
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            display.Text = "0";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            // Plus
            if (function=='+')
            {
                result = firstNum + secondNum;
                display.Text = result.ToString();
            }
            // Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                display.Text = result.ToString();

            }
            // Divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    display.Text = "Not dividable";
                }
                else
                {
                    result = firstNum / secondNum;
                    display.Text = result.ToString();


                }
            }
            // Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                display.Text = result.ToString();

            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput;
        }
    }
}