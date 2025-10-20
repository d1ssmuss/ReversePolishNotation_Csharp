using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_RPN_0_
{
    public partial class Form1 : Form
    {
        string virajenie = "";
        public Form1()
        {
            InitializeComponent();
        }

        static string ConvertToRPN(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return "";

            // Проверка скобок для функций
            string checkResult = CheckFunctionBrackets(expression);
            if (checkResult != "OK")
            {
                return checkResult;
            }

            expression = expression.Replace(" ", "");

            string cleanedExpression = expression
                .Replace("sin", "")
                .Replace("cos", "")
                .Replace("ctg", "")
                .Replace("tg", "")
                .Replace("ln", "")
                .Replace("lg", "")
                .Replace("abs", "")
                .Replace("√", "")
                .Replace("π", "")
                .Replace("e", "")
                .Replace("%", "");

            if (cleanedExpression.Contains('.') || cleanedExpression.Contains(','))
            {
                return "Ошибка: Выражение содержит числа с плавающей запятой";
            }
            else if (cleanedExpression.Any(c => char.IsLetter(c)))
            {
                return "Ошибка: Выражение содержит переменные или неизвестные функции";
            }

            string result = "";
            Stack<string> stack = new Stack<string>();
            string functionBuffer = "";

            var priority = new Dictionary<string, int>
            {
                { "+", 1 }, { "-", 1 }, { "*", 2 }, { "/", 2 }, { "^", 3 },
                { "√", 4 }, { "sin", 4 }, { "cos", 4 }, { "tg", 4 }, { "ctg", 4 },
                { "ln", 4 }, { "lg", 4 }, { "abs", 4 }
            };

            var functions = new HashSet<string> { "sin", "cos", "tg", "ctg", "ln", "lg", "abs" };

            for (int i = 0; i < expression.Length; i++)
            {
                char current = expression[i];

                if (char.IsDigit(current) || current == 'π' || current == 'e' || current == '%')
                {
                    result += current;
                    continue;
                }

                if (char.IsLetter(current))
                {
                    functionBuffer += current;
                    continue;
                }

                if (functionBuffer.Length > 0 && !char.IsLetter(current))
                {
                    if (functions.Contains(functionBuffer) || functionBuffer == "√")
                    {
                        stack.Push(functionBuffer);
                    }
                    functionBuffer = "";
                }

                if (current == '(')
                {
                    stack.Push("(");
                }
                else if (current == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        result += " " + stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() == "(")
                        stack.Pop();

                    if (stack.Count > 0 && (functions.Contains(stack.Peek()) || stack.Peek() == "√"))
                    {
                        result += " " + stack.Pop();
                    }
                }
                else if (priority.ContainsKey(current.ToString()))
                {
                    string op = current.ToString();
                    result += " ";

                    while (stack.Count > 0 &&
                           stack.Peek() != "(" &&
                           priority.ContainsKey(stack.Peek()) &&
                           priority[stack.Peek()] >= priority[op])
                    {
                        result += stack.Pop() + " ";
                    }
                    stack.Push(op);
                }
                else if (current == '√')
                {
                    stack.Push("√");
                }
            }

            if (functionBuffer.Length > 0)
            {
                if (functions.Contains(functionBuffer) || functionBuffer == "√")
                {
                    stack.Push(functionBuffer);
                }
                functionBuffer = "";
            }

            while (stack.Count > 0)
            {
                result += " " + stack.Pop();
            }

            return result.Trim().Replace("  ", " ");
        }

        // Новая функция для проверки скобок у функций
        static string CheckFunctionBrackets(string expression)
        {
            var functions = new HashSet<string> { "sin", "cos", "tg", "ctg", "ln", "lg", "abs" };

            for (int i = 0; i < expression.Length; i++)
            {
                // Проверка для именованных функций (sin, cos, etc.)
                foreach (string func in functions)
                {
                    if (i + func.Length <= expression.Length &&
                        expression.Substring(i, func.Length) == func)
                    {
                        // После функции должна идти открывающая скобка
                        int bracketIndex = i + func.Length;
                        if (bracketIndex >= expression.Length || expression[bracketIndex] != '(')
                        {
                            return $"Ошибка: После функции {func} должны быть скобки";
                        }
                    }
                }

                // Проверка для корня
                if (expression[i] == '√')
                {
                    // После корня должна идти открывающая скобка
                    if (i + 1 >= expression.Length || expression[i + 1] != '(')
                    {
                        return "Ошибка: После √ должны быть скобки";
                    }
                }
            }

            // Дополнительная проверка для степени (необязательно, но можно добавить)
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '^')
                {
                    // Проверяем, что после ^ есть выражение в скобках или число
                    bool hasValidRightOperand = false;

                    // Пропускаем пробелы после ^
                    int j = i + 1;
                    while (j < expression.Length && expression[j] == ' ') j++;

                    if (j < expression.Length)
                    {
                        if (expression[j] == '(' || char.IsDigit(expression[j]) ||
                            expression[j] == 'π' || expression[j] == 'e')
                        {
                            hasValidRightOperand = true;
                        }
                    }

                    if (!hasValidRightOperand)
                    {
                        return "Ошибка: После ^ должно быть выражение в скобках или число";
                    }
                }
            }

            return "OK";
        }

        static double Calculate(string rpnExpression)
        {
            if (string.IsNullOrEmpty(rpnExpression) || rpnExpression.StartsWith("Ошибка:"))
                return double.NaN;

            Stack<double> stack = new Stack<double>();
            string[] tokens = rpnExpression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else if (token == "π")
                {
                    stack.Push(Math.PI);
                }
                else if (token == "e")
                {
                    stack.Push(Math.E);
                }
                else if (token == "%")
                {
                    if (stack.Count < 1) return double.NaN;
                    double value = stack.Pop();
                    stack.Push(value / 100);
                }
                else if (IsOperator(token))
                {
                    if (stack.Count < 2) return double.NaN;
                    double b = stack.Pop();
                    double a = stack.Pop();
                    double result = ApplyOperator(a, b, token);
                    if (double.IsNaN(result)) return double.NaN;
                    stack.Push(result);
                }
                else if (IsFunction(token))
                {
                    if (stack.Count < 1) return double.NaN;
                    double value = stack.Pop();
                    double result = ApplyFunction(value, token);
                    if (double.IsNaN(result)) return double.NaN;
                    stack.Push(result);
                }
                else
                {
                    return double.NaN;
                }
            }

            if (stack.Count != 1) return double.NaN;

            return stack.Pop();
        }

        static bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/" || token == "^";
        }

        static bool IsFunction(string token)
        {
            return token == "sin" || token == "cos" || token == "tg" || token == "ctg" ||
                   token == "ln" || token == "lg" || token == "abs" || token == "√";
        }

        static double ApplyOperator(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return b != 0 ? a / b : double.NaN;
                case "^": return Math.Pow(a, b);
                default: return double.NaN;
            }
        }

        static double ApplyFunction(double value, string func)
        {
            switch (func)
            {
                case "sin": return Math.Sin(value);
                case "cos": return Math.Cos(value);
                case "tg": return Math.Tan(value);
                case "ctg": return value != 0 ? 1.0 / Math.Tan(value) : double.NaN;
                case "ln": return value > 0 ? Math.Log(value) : double.NaN;
                case "lg": return value > 0 ? Math.Log10(value) : double.NaN;
                case "abs": return Math.Abs(value);
                case "√": return value >= 0 ? Math.Sqrt(value) : double.NaN;
                default: return double.NaN;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            virajenie = Input.Text;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            // Добавьте логику для кнопки "равно"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpn = ConvertToRPN(virajenie);
            labelresult.Text = "= " + rpn;

            if (rpn.StartsWith("Ошибка:"))
            {
                labelansw.Text = rpn;
            }
            else
            {
                double result = Calculate(rpn);
                if (double.IsNaN(result))
                {
                    labelansw.Text = "Ошибка вычисления";
                }
                else
                {
                    labelansw.Text = "Результат вычисления: " + result.ToString();
                }
            }
        }

        private void labelansw_Click(object sender, EventArgs e)
        {
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            labelresult.Text = "";
            labelansw.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                Input.Text = Input.Text.Remove(Input.Text.Length - 1);
            }
            catch
            {

            }
        }

        private void btnbracketopen_Click(object sender, EventArgs e)
        {
            Input.Text += "(";
        }

        private void btnbracketclosed_Click(object sender, EventArgs e)
        {
            Input.Text += ")";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            Input.Text += "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Input.Text += "-";
        }

        private void btnprocent_Click(object sender, EventArgs e)
        {
            Input.Text += "%";
        }

        private void btnlg_Click(object sender, EventArgs e)
        {
            Input.Text += "lg(";
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            Input.Text += "ln(";
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            Input.Text += "sin(";
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            Input.Text += "cos(";
        }

        private void btnabs_Click(object sender, EventArgs e)
        {
            Input.Text += "abs(";
        }

        private void btnctg_Click(object sender, EventArgs e)
        {
            Input.Text += "ctg(";
        }

        private void btntg_Click(object sender, EventArgs e)
        {
            Input.Text += "tg(";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            Input.Text += "e";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            Input.Text += "π";
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            Input.Text += "^";
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            Input.Text += "*";
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            Input.Text += "√(";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Input.Text += "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            Input.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input.Text += "2";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Input.Text += "9";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Input.Text += "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Input.Text += "7";
        }

        private void six_Click(object sender, EventArgs e)
        {
            Input.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            Input.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            Input.Text += "4";
        }

        private void three_Click(object sender, EventArgs e)
        {
            Input.Text += "3";
        }
    }
}