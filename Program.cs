using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Program solver = new Program();
        int choice;

        while (true)
        {
            Console.WriteLine("\nЛабораторная работа №1");
            Console.WriteLine("Выберите задачу (1-10) или 0 для выхода:");
            choice = ReadInt();

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Выход из программы.");
                    return;

                case 1:
                    solver.RunTask1();
                    break;

                case 2:
                    solver.RunTask2();
                    break;

                case 3:
                    solver.RunTask3();
                    break;

                case 4:
                    solver.RunTask4();
                    break;

                case 5:
                    solver.RunTask5();
                    break;

                case 6:
                    solver.RunTask6();
                    break;

                case 7:
                    solver.RunTask7();
                    break;

                case 8:
                    solver.RunTask8();
                    break;

                case 9:
                    solver.RunTask9();
                    break;

                case 10:
                    solver.RunTask10();
                    break;

                default:
                    Console.WriteLine("Неверный номер задачи. Введите число от 0 до 10.");
                    break;
            }
        }
    }

    private void RunTask1()
    {
        Console.WriteLine("\nЗадача 1: Дробная часть");
        Console.Write("Введите число x: ");
        double x = ReadDouble();
        Console.WriteLine("Результат: " + Fraction(x));
    }

    private void RunTask2()
    {
        Console.WriteLine("\nЗадача 2: Букву в число");
        Console.Write("Введите символ (0-9): ");
        char ch = ReadDigitChar();
        Console.WriteLine("Результат: " + CharToNum(ch));
    }

    private void RunTask3()
    {
        Console.WriteLine("\nЗадача 3: Двузначное");
        Console.Write("Введите целое число: ");
        int num = ReadInt();
        Console.WriteLine("Результат: " + Is2Digits(num));
    }

    private void RunTask4()
    {
        Console.WriteLine("\nЗадача 4: Диапазон4");
        Console.Write("Введите a: ");
        int a = ReadInt();
        Console.Write("Введите b: ");
        int b = ReadInt();
        Console.Write("Введите num: ");
        int num = ReadInt();
        Console.WriteLine("Результат: " + IsInRange(a, b, num));
    }

    private void RunTask5()
    {
        Console.WriteLine("\nЗадача 5: Равенство");
        Console.Write("Введите a: ");
        int a = ReadInt();
        Console.Write("Введите b: ");
        int b = ReadInt();
        Console.Write("Введите c: ");
        int c = ReadInt();
        Console.WriteLine("Результат: " + IsEqual(a, b, c));
    }

    private void RunTask6()
    {
        Console.WriteLine("\n--- Задача 6: Модуль числа ---");
        Console.Write("Введите целое число x: ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + Abs(x));
    }

    private void RunTask7()
    {
        Console.WriteLine("\n--- Задача 7: Тридцать пять ---");
        Console.Write("Введите целое число x: ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + Is35(x));
    }

    private void RunTask8()
    {
        Console.WriteLine("\n--- Задача 8: Тройной максимум ---");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        int y = ReadInt();
        Console.Write("Введите z: ");
        int z = ReadInt();
        Console.WriteLine("Результат: " + Max3(x, y, z));
    }

    private void RunTask9()
    {
        Console.WriteLine("\n--- Задача 9: Двойная сумма ---");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        int y = ReadInt();
        Console.WriteLine("Результат: " + Sum2(x, y));
    }

    private void RunTask10()
    {
        Console.WriteLine("\n--- Задача 10: День недели ---");
        Console.Write("Введите число x (1-7): ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + Day(x));
    }

    private double Fraction(double x)
    {
        double result = x - (int)x;
        return Math.Round(result, 10);
    }

    private int CharToNum(char x)
    {
        return x - '0';
    }

    private bool Is2Digits(int x)
    {
        int absX = x;

        if (absX < 0)
        {
            absX = -absX;
        }

        return absX >= 10 && absX <= 99;
    }

    private bool IsInRange(int a, int b, int num)
    {
        int min = a;
        int max = b;

        if (a > b)
        {
            min = b;
            max = a;
        }

        return num >= min && num <= max;
    }

    private bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    // ===== Решения задач 6-10 =====

    private int Abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }

        return x;
    }

    private bool Is35(int x)
    {
        bool divBy3 = x % 3 == 0;
        bool divBy5 = x % 5 == 0;

        return (divBy3 || divBy5) && !(divBy3 && divBy5);
    }

    private int Max3(int x, int y, int z)
    {
        int max = x;

        if (y > max)
        {
            max = y;
        }

        if (z > max)
        {
            max = z;
        }

        return max;
    }

    private int Sum2(int x, int y)
    {
        int sum = x + y;

        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }

        return sum;
    }

    private string Day(int x)
    {
        switch (x)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "это не день недели";
        }
    }

    // ===== Вспомогательные методы ввода =====
// ===== Вспомогательные методы ввода =====

// ===== Вспомогательные методы ввода =====
// ===== Вспомогательные методы ввода =====
    private static double ReadDouble()
    {
        string input;
        double result;

        while (true)
        {
            input = Console.ReadLine();

            if (double.TryParse(input, out result))
            {
                return result;
            }

            Console.Write("Некорректный ввод. Введите число: ");
        }
    }

    private static char ReadDigitChar()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input != null && input.Length == 1 && input[0] >= '0' && input[0] <= '9')
            {
                return input[0];
            }

            Console.Write("Некорректный ввод. Введите одну цифру (0-9): ");
        }
    }

    private static int ReadInt()
    {
        string input;
        int result;

        while (true)
        {
            input = Console.ReadLine();

            if (int.TryParse(input, out result))
            {
                return result;
            }

            Console.Write("Некорректный ввод. Введите целое число: ");
        }
    }
}