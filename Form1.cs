namespace calculatorApp
{
    public partial class calcApp : Form
    {
        string operation = "";
        double firstNum, secondNum;

        public calcApp()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox.Text == "0") textBox.Text = "";

            textBox.Text += btn.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void Operation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNum = Double.Parse(textBox.Text);
            operation = btn.Text;
            textBox.Text = "";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            else if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("-")) textBox.Text = textBox.Text.Remove(0, 1);
            else textBox.Text = "-" + textBox.Text;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(textBox.Text);
            operation = "%";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = Double.Parse(textBox.Text);

            switch (operation)
            {
                case "+":
                    textBox.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    textBox.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    textBox.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "/":
                    textBox.Text = Convert.ToString(firstNum / secondNum);
                    if (secondNum == 0) MessageBox.Show("Error! You can not divide by zero!");
                    break;
                case "%":
                    textBox.Text = Convert.ToString(firstNum / 100);
                    break;
                case "sqrt":
                    textBox.Text = Convert.ToString(Math.Sqrt(firstNum));
                    break;
                default:
                    break;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(",") && textBox.Text != "") textBox.Text += ",";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(textBox.Text);
            operation = "sqrt";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

            string f, s;

            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            f = "";
            s = "";
        }
    }
}