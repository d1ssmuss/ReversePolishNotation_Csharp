using System.Text;

Console.OutputEncoding = Encoding.UTF8;

static string ConvertToRPN(string expression)
{
    if (string.IsNullOrEmpty(expression))
        return "";

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
        //Console.WriteLine();
        //Console.WriteLine(cleanedExpression + " - Строка после изменений");
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

// Console.WriteLine(ConvertToRPN(","));
static double Calculate(string rpnExpression)
{
    if (string.IsNullOrEmpty(rpnExpression))
        return 0;

    Stack<double> stack = new Stack<double>();
    string[] tokens = rpnExpression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

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
            if (stack.Count < 1) return double.NaN; // Недостаточно операндов для %
            double value = stack.Pop();
            stack.Push(value / 100);
        }
        else if (IsOperator(token))
        {
            if (stack.Count < 2) return double.NaN; // Недостаточно операндов для оператора
            double b = stack.Pop();
            double a = stack.Pop();
            double result = ApplyOperator(a, b, token);
            if (double.IsNaN(result)) return double.NaN;
            stack.Push(result);
        }
        else if (IsFunction(token))
        {
            if (stack.Count < 1) return double.NaN; // Недостаточно операндов для функции
            double value = stack.Pop();
            double result = ApplyFunction(value, token);
            if (double.IsNaN(result)) return double.NaN;
            stack.Push(result);
        }
        else
        {
            return double.NaN; // Неизвестный токен
        }
    }

    if (stack.Count != 1) return double.NaN; // Некорректное выражение

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
    return op switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => b != 0 ? a / b : double.NaN, // Деление на ноль
        "^" => Math.Pow(a, b),
        _ => double.NaN // Неизвестный оператор
    };
}

static double ApplyFunction(double value, string func)
{
    return func switch
    {
        "sin" => Math.Sin(value),
        "cos" => Math.Cos(value),
        "tg" => Math.Tan(value),
        "ctg" => value != 0 ? 1.0 / Math.Tan(value) : double.NaN, // Деление на ноль в котангенсе
        "ln" => value > 0 ? Math.Log(value) : double.NaN, // Логарифм от неположительного числа
        "lg" => value > 0 ? Math.Log10(value) : double.NaN, // Логарифм от неположительного числа
        "abs" => Math.Abs(value),
        "√" => value >= 0 ? Math.Sqrt(value) : double.NaN, // Корень из отрицательного числа
        _ => double.NaN // Неизвестная функция
    };
}

string o = ConvertToRPN("2-2*9");
Console.WriteLine(o);
double result = Calculate(o);
if (double.IsNaN(result))
{
    Console.WriteLine("Ошибка в вычислениях");
}
else
{
    Console.WriteLine(result);
}
