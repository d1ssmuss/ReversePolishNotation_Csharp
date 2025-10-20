static string ConvertToRPN(string expression)
{
    if (string.IsNullOrEmpty(expression))
        return "";

    string result = "";
    Stack<string> stack = new Stack<string>();
    string functionBuffer = "";

    // Расширенный словарь приоритетов
    var priority = new Dictionary<string, int>
    {
        { "+", 1 }, { "-", 1 }, { "*", 2 }, { "/", 2 }, { "^", 3 },
        { "√", 4 }, { "sin", 4 }, { "cos", 4 }, { "tg", 4 }, { "ctg", 4 },
        { "ln", 4 }, { "lg", 4 }, { "abs", 4 }
    };

    // Список поддерживаемых функций
    var functions = new HashSet<string> { "sin", "cos", "tg", "ctg", "ln", "lg", "abs" };

    for (int i = 0; i < expression.Length; i++)
    {
        char current = expression[i];

        if (current == ' ') continue; // если символ - пробел

        // Обработка цифр, констант и специальных символов
        if (char.IsDigit(current) || current == 'π' || current == 'e' || current == '%')
        {
            result += current;
            continue;
        }

        // Обработка букв (имен функций)
        if (char.IsLetter(current))
        {
            functionBuffer += current;
            continue;
        }

        // Если накопилась функция и следующий символ не буква - обрабатываем функцию
        if (functionBuffer.Length > 0 && !char.IsLetter(current))
        {
            if (functions.Contains(functionBuffer) || functionBuffer == "√")
            {
                stack.Push(functionBuffer);
            }
            functionBuffer = "";
        }

        // Обработка открывающей скобки
        if (current == '(')
        {
            stack.Push("(");
        }
        // Обработка закрывающей скобки
        else if (current == ')')
        {
            while (stack.Count > 0 && stack.Peek() != "(")
            {
                result += stack.Pop();
            }
            if (stack.Count > 0 && stack.Peek() == "(")
                stack.Pop();

            // После закрывающей скобки проверяем, не функция ли на вершине
            if (stack.Count > 0 && (functions.Contains(stack.Peek()) || stack.Peek() == "√"))
            {
                result += stack.Pop();
            }
        }
        // Обработка операций
        else if (priority.ContainsKey(current.ToString()))
        {
            string op = current.ToString();

            while (stack.Count > 0 &&
                   stack.Peek() != "(" &&
                   priority.ContainsKey(stack.Peek()) &&
                   priority[stack.Peek()] >= priority[op])
            {
                result += stack.Pop();
            }
            stack.Push(op);
        }
        // Обработка корня (если он не был обработан как функция)
        else if (current == '√')
        {
            stack.Push("√");
        }
    }

    // Обработка оставшейся функции
    // Используется для того, если например входная строка это функция
    if (functionBuffer.Length > 0)
    {
        if (functions.Contains(functionBuffer) || functionBuffer == "√")
        {
            stack.Push(functionBuffer);
        }
        else
        {
            result += functionBuffer;
        }
        functionBuffer = "";
    }

    // Выталкиваем оставшиеся операции
    while (stack.Count > 0)
    {
        result += stack.Pop();
    }

    return result;
}

Console.WriteLine(ConvertToRPN("sin(5)"));
Console.WriteLine(ConvertToRPN("4+3*(6-√(2))-ln(10/sin(" + "\u03c0" + "/6))+(3000-13%)"));
