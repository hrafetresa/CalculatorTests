using System;
using System.Windows.Forms;
namespace MathTaskWindowsForms
{
    public partial class MainForm : Form
    {
        private Calculator calculator;
        private double currentValue;
        private string currentOperation;
        private bool isNewEntry;
        public MainForm()
        {
            InitializeComponent();
            calculator = new Calculator();
            currentValue = 0;
            currentOperation = "";
            isNewEntry = true;
        }
        private void InitializeComponent()
        {
            this.Text = "Калькулятор";
            this.Size = new System.Drawing.Size(430, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            // Создание текстового поля для отображения результата
            TextBox txtDisplay = new TextBox()
            {
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(360, 40),
                Font = new System.Drawing.Font("Arial", 18,
           System.Drawing.FontStyle.Bold),
                TextAlign = HorizontalAlignment.Right,
                ReadOnly = true,
                Text = "0"
            };
            // Создание кнопок
            Button btnMC = CreateButton("MC", 12, 70);
            Button btnMR = CreateButton("MR", 92, 70);
            Button btnMS = CreateButton("MS", 172, 70);
            Button btnMPlus = CreateButton("M+", 252, 70);
            Button btnMMinus = CreateButton("M-", 332, 70);
            Button btn7 = CreateButton("7", 12, 130);
            Button btn8 = CreateButton("8", 92, 130);
            Button btn9 = CreateButton("9", 172, 130);
            Button btnDivide = CreateButton("/", 252, 130);
            Button btnSqrt = CreateButton("√", 332, 130);
            Button btn4 = CreateButton("4", 12, 190);
            Button btn5 = CreateButton("5", 92, 190);
            Button btn6 = CreateButton("6", 172, 190);
            Button btnMultiply = CreateButton("*", 252, 190);
            Button btnPower = CreateButton("x^y", 332, 190);
            Button btn1 = CreateButton("1", 12, 250);
            Button btn2 = CreateButton("2", 92, 250);
            Button btn3 = CreateButton("3", 172, 250);
            Button btnSubtract = CreateButton("-", 252, 250);
            Button btnPercent = CreateButton("%", 332, 250);
            Button btn0 = CreateButton("0", 12, 310);
            Button btnDot = CreateButton(".", 92, 310);
            Button btnClear = CreateButton("C", 172, 310);
            Button btnAdd = CreateButton("+", 252, 310);
            Button btnEquals = CreateButton("=", 332, 310, 70);
            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
 txtDisplay,
 btnMC, btnMR, btnMS, btnMPlus, btnMMinus,
 btn7, btn8, btn9, btnDivide, btnSqrt,
 btn4, btn5, btn6, btnMultiply, btnPower,
 btn1, btn2, btn3, btnSubtract, btnPercent,
 btn0, btnDot, btnClear, btnAdd, btnEquals
 });
            // Обработчики событий для цифр
            Button[] digitButtons = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8,
btn9 };
            foreach (var btn in digitButtons)
            {
                btn.Click += (sender, e) => DigitButton_Click(sender, e, txtDisplay);
            }
            // Обработчики для операций
            btnAdd.Click += (sender, e) => OperationButton_Click("+", txtDisplay);
            btnSubtract.Click += (sender, e) => OperationButton_Click("-", txtDisplay);
            btnMultiply.Click += (sender, e) => OperationButton_Click("*", txtDisplay);
            btnDivide.Click += (sender, e) => OperationButton_Click("/", txtDisplay);
            btnPower.Click += (sender, e) => OperationButton_Click("^", txtDisplay);
            btnEquals.Click += (sender, e) => EqualsButton_Click(txtDisplay);
            btnClear.Click += (sender, e) => ClearButton_Click(txtDisplay);
            btnDot.Click += (sender, e) => DotButton_Click(txtDisplay);
            btnSqrt.Click += (sender, e) => SqrtButton_Click(txtDisplay);
            btnPercent.Click += (sender, e) => PercentButton_Click(txtDisplay);
            // Обработчики для памяти
            btnMC.Click += (sender, e) => MemoryClear_Click(txtDisplay);
            btnMR.Click += (sender, e) => MemoryRecall_Click(txtDisplay);
            btnMS.Click += (sender, e) => MemoryStore_Click(txtDisplay);
            btnMPlus.Click += (sender, e) => MemoryAdd_Click(txtDisplay);
            btnMMinus.Click += (sender, e) => MemorySubtract_Click(txtDisplay);
        }
        private Button CreateButton(string text, int x, int y, int height = 50)
        {
            return new Button()
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(70, height),
                Font = new System.Drawing.Font("Arial", 12,
           System.Drawing.FontStyle.Bold),
                UseVisualStyleBackColor = true
            };
        }
        private void DigitButton_Click(object sender, EventArgs e, TextBox display)
        {
            Button btn = sender as Button;
            if (isNewEntry)
            {
                display.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                display.Text = display.Text == "0" ? btn.Text : display.Text + btn.Text;
            }
        }
        private void OperationButton_Click(string operation, TextBox display)
        {
            currentValue = double.Parse(display.Text);
            currentOperation = operation;
            isNewEntry = true;
        }
        private void EqualsButton_Click(TextBox display)
        {
            if (string.IsNullOrEmpty(currentOperation))
                return;
            try
            {
                double secondValue = double.Parse(display.Text);
                double result = 0;
                switch (currentOperation)
                {
                    case "+":
                        result = calculator.Add(currentValue, secondValue);
                        break;
                    case "-":
                        result = calculator.Subtract(currentValue, secondValue);
                        break;
                    case "*":
                        result = calculator.Multiply(currentValue, secondValue);
                        break;
                    case "/":
                        result = calculator.Divide(currentValue, secondValue);
                        break;
                    case "^":
                        result = calculator.Power(currentValue, secondValue);
                        break;
                }
                display.Text = result.ToString();
                currentValue = result;
                currentOperation = "";
                isNewEntry = true;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                ClearButton_Click(display);
            }
        }
        private void ClearButton_Click(TextBox display)
        {
            display.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isNewEntry = true;
        }
        private void DotButton_Click(TextBox display)
        {
            if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        }
        private void SqrtButton_Click(TextBox display)
        {
            try
            {
                double value = double.Parse(display.Text);
                double result = calculator.SquareRoot(value);
                display.Text = result.ToString();
                isNewEntry = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void PercentButton_Click(TextBox display)
        {
            double value = double.Parse(display.Text);
            double result = calculator.Percentage(currentValue, value);
            display.Text = result.ToString();
            isNewEntry = true;
        }
        private void MemoryClear_Click(TextBox display)
        {
            calculator.ClearMemory();
        }
        private void MemoryRecall_Click(TextBox display)
        {
            display.Text = calculator.MemoryValue.ToString();
            isNewEntry = true;
        }
        private void MemoryStore_Click(TextBox display)
        {
            calculator.ClearMemory();
            calculator.MemoryAdd(double.Parse(display.Text));
        }
        private void MemoryAdd_Click(TextBox display)
        {
            calculator.MemoryAdd(double.Parse(display.Text));
        }
        private void MemorySubtract_Click(TextBox display)
        {
            calculator.MemorySubtract(double.Parse(display.Text));
        }
    }
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (Math.Abs(b) < double.Epsilon)
                throw new DivideByZeroException("Divisor cannot be zero");
            return a / b;
        }
        public double Power(double @base, double exponent)
        => Math.Pow(@base, exponent);
        public double SquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException(
                "Cannot calculate square root of negative number",
                nameof(number));
            return Math.Sqrt(number);
        }
        public double Percentage(double value, double percent)
        => value * percent / 100;
        public void ClearMemory()
        {
            MemoryValue = 0;
        }
        public double MemoryValue { get; private set; }
        public void MemoryAdd(double value) => MemoryValue += value;
        public void MemorySubtract(double value) => MemoryValue -= value;
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}