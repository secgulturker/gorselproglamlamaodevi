
namespace MauiApp6
{
    public partial class CalculatorPage : ContentPage
    {
        double currentNumber = 0;
        double firstNumber = 0;
        string operatorSelected = "";

        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void Number_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string pressed = button.Text;
            if (Display.Text == "0")
                Display.Text = "";
            Display.Text += pressed;
            currentNumber = double.Parse(Display.Text);
        }

        private void Operator_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            operatorSelected = button.Text;
            firstNumber = currentNumber;
            Display.Text = "0";
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            firstNumber = 0;
            currentNumber = 0;
            operatorSelected = "";
            Display.Text = "0";
        }

        private void Equal_Clicked(object sender, EventArgs e)
        {
            double result = 0;
            switch (operatorSelected)
            {
                case "+":
                    result = firstNumber + currentNumber;
                    break;
                case "-":
                    result = firstNumber - currentNumber;
                    break;
                case "*":
                    result = firstNumber * currentNumber;
                    break;
                case "/":
                    if (currentNumber != 0)
                        result = firstNumber / currentNumber;
                    break;
            }
            Display.Text = result.ToString();
            currentNumber = result;
        }

        private void Decimal_Clicked(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
                Display.Text += ".";
        }

        private void Negate_Clicked(object sender, EventArgs e)
        {
            currentNumber = -currentNumber;
            Display.Text = currentNumber.ToString();
        }

        private void Percent_Clicked(object sender, EventArgs e)
        {
            currentNumber = currentNumber / 100;
            Display.Text = currentNumber.ToString();
        }
    }
}
