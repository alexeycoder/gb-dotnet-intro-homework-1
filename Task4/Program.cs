// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// aux vars
var commonForeColor = Console.ForegroundColor;
var titleForeColor = ConsoleColor.Cyan;
var errorForeColor = ConsoleColor.Magenta;

string title = "Нахождение максимального из трёх чисел";
string errorMsg = "Ошибка: Некорректный ввод! Пожалуйста повторите";
int width = Console.BufferWidth;
string titleDelimiter = new string('\u2550', width);
string splitter = new string('\u2508', width);

Console.Title = title;

// increase n to check more numbers
const int n = 3;

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

	decimal[] numbers = new decimal[n];
	decimal max = decimal.MinValue;
	int countOfMax = 0;

	for (int i = 0; i < n; ++i)
	{

		bool handleError = false;
		decimal number;
		do
		{
			if (handleError)
			{
				Console.ForegroundColor = errorForeColor;
				Console.WriteLine(errorMsg);
				Console.ForegroundColor = commonForeColor;
			}
			Console.Write($"Введите {i + 1}-е число: ");
			handleError = !(decimal.TryParse(Console.ReadLine(), out number));

		} while (handleError);

		numbers[i] = number;

		if (number > max)
		{
			max = number;
			countOfMax = 1;
		}
		else if (number == max)
		{
			++countOfMax;
		}

		Console.WriteLine(splitter);
	}

	if (countOfMax == n)
	{
		Console.WriteLine($"Все введённые числа равны между собой и равны {max}");
	}
	else
	{
		Console.WriteLine($"Максимальное из введённых чисел равно {max}.");
	}

	// ask for repeat or exit
	Console.WriteLine(splitter);
	Console.Write("Нажмите Enter, чтобы повторить или Esc, чтобы завершить...");
	ConsoleKeyInfo key = Console.ReadKey(true);
	repeat = key.Key != ConsoleKey.Escape;

} while (repeat);

Console.WriteLine(Environment.NewLine + splitter + Environment.NewLine + "Спасибо!");
