namespace Calculator4
{
    public partial class Form1 : Form
    {
        string operator_Clicked = "";
        double resultValue;
        bool isOperatorPerformed=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttons_Clickeve(object sender, EventArgs e)
        {
            Button button=(Button)sender;

            if(textBox1_Display.Text =="0" || (isOperatorPerformed))
                textBox1_Display.Clear();

            isOperatorPerformed= false;
            if(button.Text == ".")
            {
                if (!textBox1_Display.Text.Contains("."))
                {
                    textBox1_Display.Text = textBox1_Display.Text + button.Text;
                } 
            }
            else
            {
                textBox1_Display.Text = textBox1_Display.Text + button.Text;
            }
            
           
        }

        private void operators_ClickEve(object sender, EventArgs e)
        {
            Button pressOperators = (Button)sender;
            if (resultValue != 0)
            {
                button11.PerformClick();
                 operator_Clicked = pressOperators.Text;
             
                lable_Show.Text = resultValue + " " + operator_Clicked;
                isOperatorPerformed = true;
            }
            else
            {
                operator_Clicked = pressOperators.Text;
                resultValue = Convert.ToDouble(textBox1_Display.Text);
                lable_Show.Text = resultValue + " " + operator_Clicked;
                isOperatorPerformed = true;
            }
           
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operator_Clicked)
            {
                case "+":
                    textBox1_Display.Text = (resultValue + (Double.Parse(textBox1_Display.Text))).ToString();break;
                case "-":
                    textBox1_Display.Text = (resultValue - (Double.Parse(textBox1_Display.Text))).ToString(); break;
                case "/":
                    textBox1_Display.Text = (resultValue / (Double.Parse(textBox1_Display.Text))).ToString(); break;
                case "*":
                    textBox1_Display.Text = (resultValue * (Double.Parse(textBox1_Display.Text))).ToString(); break;
                default:
                    break;

            }
            resultValue= Convert.ToDouble(textBox1_Display.Text);
            lable_Show.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1_Display.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1_Display.Text = "";
            resultValue = 0;
        }
    }
}