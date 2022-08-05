// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// aux vars
var commonForeColor = Console.ForegroundColor;
var titleForeColor = ConsoleColor.Cyan;
var errorForeColor = ConsoleColor.Magenta;

string title = "Проверка целого числа на чётность";
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

	bool handleError = false;
	int num;
	do
	{
		if (handleError)
		{
			Console.ForegroundColor = errorForeColor;
			Console.WriteLine(errorMsg);
			Console.ForegroundColor = commonForeColor;
		}
		Console.Write($"Введите целое число: ");
		handleError = !(int.TryParse(Console.ReadLine(), out num));

	} while (handleError);

	Console.WriteLine(splitter);

	if (num % 2 == 0)
	{
		Console.WriteLine($"Введённое число \u2014 чётное");
	}
	else
	{
		Console.WriteLine($"Введённое число \u2014 нечётное");
	}

	// ask for repeat or exit
	Console.WriteLine(splitter);
	Console.Write("Нажмите Enter, чтобы повторить или Esc, чтобы завершить...");
	ConsoleKeyInfo key = Console.ReadKey(true);
	repeat = key.Key != ConsoleKey.Escape;

} while (repeat);

Console.WriteLine(Environment.NewLine + splitter + Environment.NewLine + "Спасибо!");
