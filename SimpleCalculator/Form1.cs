namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        Button? currentBtn;
        double x, y;
        string? operation;
        int opCount;
        bool noInput = true;

        public SimpleCalculator()
        {
            InitializeComponent();
            inputLabel.Text = "0";
            outputBox.Text = "0";
            opCount = 0;
        }

        // reset calculator to default values
        public void ResetCalculator()
        {
            inputLabel.Text = "";
            outputBox.Clear();
            opCount = 0;
            x = 0; y = 0;
            btnDecimal.Enabled = true;
            noInput = true;
            operation = default;
            currentBtn = default;
        }
        private double GetNumber()
        {
            if (!string.IsNullOrEmpty(outputBox.Text))
            {
                return Convert.ToDouble(outputBox.Text);
            }
            return 0;
        }

        // calculate operation with 2 numbers
        private void Calculate(double x, double y, string operation)
        {
            switch (operation)
            {
                case "btnAdd":
                    inputLabel.Text = MathOperations.Add(x, y).ToString();
                    outputBox.Text = MathOperations.Add(x, y).ToString();
                    break;
                case "btnSubtract":
                    inputLabel.Text = MathOperations.Subtract(x, y).ToString();
                    outputBox.Text = MathOperations.Subtract(x, y).ToString();
                    break;
                case "btnMultiply":
                    inputLabel.Text = MathOperations.Multiply(x, y).ToString();
                    outputBox.Text = MathOperations.Multiply(x, y).ToString();
                    break;
                case "btnDivide":
                    inputLabel.Text = MathOperations.Divide(x, y).ToString();
                    outputBox.Text = MathOperations.Divide(x, y).ToString();
                    break;
            }
        }

        // event handler for number input
        private void NumberInputClick(object sender, EventArgs e)
        {
            // clear input before entering number
            if (outputBox.Text == "0")
            {
                outputBox.Clear();
                inputLabel.Text = "";
            }

            currentBtn = (Button)sender;
            inputLabel.Text += currentBtn.Text;
            outputBox.Text += currentBtn.Text;

            noInput = false;
        }

        // event handler for basic operations + - * /
        private void BasicArithmeticClick(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            btnDecimal.Enabled = true;

            // allow only 1 operator
            if (opCount > 0)
            {
                y = GetNumber();
                Calculate(x, y, operation);
                operation = currentBtn.Name;
                x = GetNumber();
                inputLabel.Text += currentBtn.Text;
                outputBox.Clear();
                opCount = 1;
                return;
            }
            operation = currentBtn.Name;

            // enable decimal button for next number input; todo optimize
            if (!string.IsNullOrEmpty(outputBox.Text))
            {
                x = GetNumber();
                outputBox.Clear();
            }

            if (noInput)
            {
                inputLabel.Text += '0' + currentBtn.Text;
            }
            else
            {
                inputLabel.Text += currentBtn.Text;
            }

            opCount++;
        }

        // event handler for equals button
        private void EqualsClick(object sender, EventArgs e)
        {
            // reset operator count to 0
            opCount = 0;

            if (!string.IsNullOrEmpty(outputBox.Text))
            {
                y = GetNumber();
            }
            Calculate(x, y, operation);
            inputLabel.Text = outputBox.Text;
        }

        // event handler for clear and clear all buttons
        private void ClearClick(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            if (currentBtn == btnClearAll)
            {
                ResetCalculator();
            }
            outputBox.Text = "0";
        }

        // event handler for sign click button
        private void SignClick(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;
            inputLabel.Text = (Convert.ToDouble(outputBox.Text) * (-1)).ToString();
            outputBox.Text = (Convert.ToDouble(outputBox.Text) * (-1)).ToString();
        }

        // event handler for decimal click
        private void DecimalClick(object sender, EventArgs e)
        {
            currentBtn = (Button)sender;

            outputBox.Text += '.';
            inputLabel.Text += '.';

            btnDecimal.Enabled = false;
        }

        // todo
        // 2. advanced operators -> mod, abs, squared ...
        // 3. special operators -> e, pi ...
        // 4. trigonometry
        // 5. unit tests & refactoring

        // current bugs:
        // 
    }
}