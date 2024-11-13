// Initialize a similar design as the given image with buttons 0-9, +, -, *, /, = and clear buttons
// Sample code for handling button clicks can be like this:

public partial class Form1 : Form
{
    private double currentNumber = 0;
    private string operation = "";

    public Form1()
    {
        InitializeComponent();
    }

    private void numberButton_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        txtDisplay.Text += button.Text;
    }

    private void operatorButton_Click(object sender, EventArgs e)
    {
        currentNumber = Convert.ToDouble(txtDisplay.Text);
        operation = (sender as Button).Text;
        txtDisplay.Clear();
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        double secondNumber = Convert.ToDouble(txtDisplay.Text);
        switch (operation)
        {
            case "+":
                txtDisplay.Text = (currentNumber + secondNumber).ToString();
                break;
            case "-":
                txtDisplay.Text = (currentNumber - secondNumber).ToString();
                break;
            case "*":
                txtDisplay.Text = (currentNumber * secondNumber).ToString();
                break;
            case "/":
                txtDisplay.Text = (currentNumber / secondNumber).ToString();
                break;
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDisplay.Clear();
        currentNumber = 0;
        operation = "";
    }
}
