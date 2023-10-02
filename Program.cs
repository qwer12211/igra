using System;
class Program
{
    static void Main()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.WriteLine("Меню выбора программ:");
            Console.WriteLine("1. Игра \"Угадай число\"");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выйти из программы");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    exitMenu = true;
                    break;
                case 1:
                    PlayGuessNumber();
                    break;
                case 2:
                    Printtablichaumnogenia();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void PlayGuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(101); 

        Console.WriteLine("Игра \"Угадай число\"");
        Console.WriteLine("Ckexfqyjt число выбрано от 0 до 100. Введеите свой вариант");

        while (true)
        {
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == randomNumber)
            {
                Console.WriteLine("Вы угадали!");
                break;
            }
            else
            {
                Console.WriteLine("Неверное число. Попробуйте снова:");
            }
        }
    }

    static void Printtablichaumnogenia()
    {
        Console.WriteLine("Таблица умножения:");

        int[,] tablichaumnogenia = new int[10, 10];

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                tablichaumnogenia[i - 1, j - 1] = i * j;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{tablichaumnogenia[i, j],4}");
            }

            Console.WriteLine();
        }
    }

    static void Printsss()
    {
        Console.WriteLine("Вывод делителей числа");
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Делители числа {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}