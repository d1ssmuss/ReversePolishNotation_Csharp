using System.Text;

string str = "";
string result = "";
Console.OutputEncoding = Encoding.UTF8; // для вывода в консоль символ π
// Тесты
// Сделать пару тестов deepseek
// Убрать пробелы везде?
string str_test1 = "3+2*(6-4)";
string str_test2 = "4+3*(6-√(2))-ln(10/sin(" + "\u03c0" + "/6))+(3000-13%)";
Console.WriteLine(str_test2);
Console.WriteLine();

str = str_test2;
char pi = 'π';
string trigonometric = "";

// Console.WriteLine(char.IsLetter(pi)); // π - это буква


// Создаю стек
Stack<string> stack = new Stack<string>(); // операций и скобки


// Я хочу создать словарь приоритетов операций
var priority_operation = new Dictionary<string, int>
{
    { "+", 1 },
    { "-", 1 },
    { "*", 2 },
    { "/", 2 },
    { "^", 3 },
};

// Console.WriteLine(priority_operation["^"]);
// Console.WriteLine(char.IsLetter('√')); // False


for (int i = 0; i < str.Length; i++)
{
    char current_element = str[i]; // Текущий элемент
    if (char.IsDigit(current_element) || current_element == pi || current_element == 'e' || current_element == '%')
    {
        Console.WriteLine(i.ToString() + ". " + "Добавляю " + current_element + " в результат");
        result += current_element;
    }
    else if (char.IsLetter(current_element)) // текущий символ - буква, используется для sin cos tg ctg abs lg ln 
    {
        trigonometric += current_element;
    }
    else if (current_element.ToString() != ")")
    {
        if (trigonometric.Length > 0) // Нашли выражение
        {
            stack.Push(trigonometric);
            Console.WriteLine(i.ToString() + ". " + "Добавляю " + trigonometric + " в стек");
            trigonometric = ""; // обнуляем строку тригонометрик(тригонометрического выражения)
        }
        else
        {
            // Возможно здесь будет ошибка в самом начале, про что я имею ввиду
            // У нас в начале стек пустой, и как он будет сравнивать какой приоритет у знака в стеке(которого нет) ?
            // М.б опять проверять на стке больше нуля, иначе просто добавлять (push)

            if (priority_operation.ContainsKey(current_element.ToString()) && stack.Count > 0 && priority_operation.ContainsKey(stack.Peek()))
            {
                if (priority_operation[stack.Peek()] > priority_operation[current_element.ToString()])
                {
                    result += stack.Pop(); // Удаляю из стека
                }
            }
            stack.Push(current_element.ToString()); // Помещаю в стек
            Console.WriteLine(i.ToString() + ". " + "Добавляю " + current_element + " в стек");
        }


        // Console.WriteLine(i.ToString() + ". " + "Добавляю " + current_element + " в стек");
    }
    else if (current_element.ToString() == ")")
    {
        while (stack.Count > 0 && stack.Peek() != "(")
        {
            var t = stack.Peek();
            result += stack.Pop();
            Console.WriteLine(i.ToString() + ". " + "Убираю из стека " + t + " и добавляю " + t + " в результат");
        }
        if (stack.Count > 0 && stack.Peek() == "(") // А можно ли убрать здесь stack.Count > 0 ?
        {
            var p = stack.Pop(); // Убираем "("
            Console.WriteLine(i.ToString() + ". " + "Убираю из стека " + p);
        }
    }
}

Console.WriteLine("Стек:");
foreach (string c in stack)
{
    Console.WriteLine(c);
}

while (stack.Count > 0)
{
    result += stack.Pop();
}


Console.WriteLine("Результат: " + result);

if (result == "4362√-*10π6/sin/ln-300013%-++")
{
    for (int i = 0; i < 13; i++)
    {
        Console.WriteLine("ПОБЕДА");
    }
}
