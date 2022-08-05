// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// aux vars
var commonForeColor = Console.ForegroundColor;
var titleForeColor = ConsoleColor.Cyan;
var errorForeColor = ConsoleColor.Magenta;

string title = "Вывод всех положительных чётных чисел, не превышающих указанное значение";
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
	int maxNum;
	do
	{
		if (handleError)
		{
			Console.ForegroundColor = errorForeColor;
			Console.WriteLine(errorMsg);
			Console.ForegroundColor = commonForeColor;
		}
		Console.Write($"Введите целое положительное число: ");
		handleError = !(int.TryParse(Console.ReadLine(), out maxNum)) || maxNum < 0;

	} while (handleError);

	Console.WriteLine(splitter);

	if (maxNum < 2)
	{
		Console.WriteLine("Для введённого числа результирующий ряд пуст!");
	}
	else
	{
		int maxEven = maxNum / 2;
		maxEven *= 2;

		// not <= for no comma "," at the end
		for (int i = 2; i < maxEven; i += 2)
		{
			Console.Write($"{i}, ");
		}
		Console.WriteLine(maxEven);
	}

	// ask for repeat or exit
	Console.WriteLine(splitter);
	Console.Write("Нажмите Enter, чтобы повторить или Esc, чтобы завершить...");
	ConsoleKeyInfo key = Console.ReadKey(true);
	repeat = key.Key != ConsoleKey.Escape;

} while (repeat);

Console.WriteLine(Environment.NewLine + splitter + Environment.NewLine + "Спасибо!");
