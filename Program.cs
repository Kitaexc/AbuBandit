using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Игра 'Угадай число'");
            Console.WriteLine("2 - Таблица умножения");
            Console.WriteLine("3 - Вывод делителей числа");
            Console.WriteLine("0 - Выход");

            int choice = GetUserChoice(0, 3);

            switch (choice)
            {
                case 1:
                    PlayGuessTheNumber();
                    break;
                case 2:
                    PrintMultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static int GetUserChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
            {
                return choice;
            }
            Console.WriteLine("Неверный ввод. Пожалуйста, введите число от " + min + " до " + max + ".");
        }
    }

    static void PlayGuessTheNumber()
    {
        Console.Clear();
        Console.WriteLine("Игра 'Угадай число'");
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;

        Console.Write("Введите число от 1 до 100: ");

        while (true)
        {
            int guess = GetUserChoice(1, 100);
            attempts++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"Поздравляем! Вы угадали число {targetNumber} за {attempts} попыток.");
                break;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }

        Console.WriteLine("Нажмите Enter, чтобы вернуться в меню.");
        Console.ReadLine();
    }

    static void PrintMultiplicationTable()
    {
        Console.Clear();
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Нажмите Enter, чтобы вернуться в меню.");
        Console.ReadLine();
    }

    static void PrintDivisors()
    {
        Console.Clear();
        Console.WriteLine("Вывод делителей числа:");
        Console.Write("Введите число: ");
        int number = GetUserChoice(1, int.MaxValue);

        Console.Write($"Делители числа {number}: ");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\nНажмите Enter, чтобы вернуться в меню.");
        Console.ReadLine();
    }
}