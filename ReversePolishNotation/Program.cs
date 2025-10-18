using System.Text;

string str = "";

// Тесты
// Сделать пару тестов deepseek
// Убрать пробелы везде?
string str_test1 = "3+2*(6-4)";
string str_test2 = "4+3*(6-√(2))-ln(10/sin(π/6))+(3000-13%)";

void TypeAllSymbols(string stroka)
{
    foreach(char c in stroka)
    {
        if (char.IsDigit(c))
        {
            Console.WriteLine(c + " - это цифра");
        }
        else
        {
            Console.WriteLine(c + " - это символ");
        }
    }
}

TypeAllSymbols(str_test1);
TypeAllSymbols(str_test2);
Console.OutputEncoding = Encoding.UTF8; // для вывода в консоль символ π
if ("\u03c0" == 'π'.ToString())
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(2);
}