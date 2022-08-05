// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// aux vars
var commonForeColor = Console.ForegroundColor;
var titleForeColor = ConsoleColor.Cyan;
var errorForeColor = ConsoleColor.Magenta;

string title = "Определение наибольшего и наименьшего из двух чисел";
string errorMsg = "Ошибка: Некорректный ввод! Пожалуйста повторите";
int width = Console.BufferWidth;
string titleDelimiter = new string('\u2550', width);
string splitter = new string('\u2508', width);

Console.Title = title;

bool repeat;

do
{
	Console.Clear();

	// header
	Console.ForegroundColor = titleForeColor;
	Console.WriteLine(titleDelimiter);
	Console.WriteLine(title);
	Console.WriteLine(titleDelimiter);
	Console.ForegroundColor = commonForeColor;

	decimal numA, numB;
	bool handleError = false;

	do
	{
		if (handleError)
		{
			Console.ForegroundColor = errorForeColor;
			Console.WriteLine(errorMsg);
			Console.ForegroundColor = commonForeColor;
			//handleError = false;
		}
		Console.Write("Введите первое число: ");
		handleError = !(decimal.TryParse(Console.ReadLine(), out numA));

	} while (handleError);

	Console.WriteLine(splitter);

	do
	{
		if (handleError)
		{
			Console.ForegroundColor = errorForeColor;
			Console.WriteLine(errorMsg);
			Console.ForegroundColor = commonForeColor;
		}
		Console.Write("Введите второе число: ");
		handleError = !(decimal.TryParse(Console.ReadLine(), out numB));

	} while (handleError);

	Console.WriteLine(splitter);

	if (numA > numB)
	{
		Console.WriteLine($"Первое число ({numA}) \u2014 большее, а второе число ({numB}) \u2014 меньшее");
	}
	else if (numA < numB)
	{
		Console.WriteLine($"Второе число ({numB}) \u2014 большее, а первое число ({numA}) \u2014 меньшее");
	}
	else
	{
		Console.WriteLine($"Введённые числа равны между собой ({numA} = {numB}).");
	}

	// ask for repeat or exit
	Console.WriteLine(splitter);
	Console.Write("Нажмите Enter, чтобы повторить или Esc, чтобы завершить...");
	ConsoleKeyInfo key = Console.ReadKey(true);
	repeat = key.Key != ConsoleKey.Escape;

} while (repeat);

Console.WriteLine(Environment.NewLine + splitter + Environment.NewLine + "Спасибо!");
