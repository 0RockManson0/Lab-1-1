using System;

internal class Program
{
    private static void Main(string[] args)
    {
        TaskSolver solver = new TaskSolver();
        int choice;

        while (true)
        {
            Console.WriteLine(
                "\nЛабораторная работа №1");
            Console.WriteLine(
                "Выберите задачу (1-20) или 0 для выхода:");
            choice = ReadInt();

            switch (choice)
            {
                case 0:
                    Console.WriteLine(
                        "Выход из программы.");
                    return;
                case 1: RunTask1(solver); break;
                case 2: RunTask2(solver); break;
                case 3: RunTask3(solver); break;
                case 4: RunTask4(solver); break;
                case 5: RunTask5(solver); break;
                case 6: RunTask6(solver); break;
                case 7: RunTask7(solver); break;
                case 8: RunTask8(solver); break;
                case 9: RunTask9(solver); break;
                case 10: RunTask10(solver); break;
                case 11: RunTask11(solver); break;
                case 12: RunTask12(solver); break;
                case 13: RunTask13(solver); break;
                case 14: RunTask14(solver); break;
                case 15: RunTask15(solver); break;
                case 16: RunTask16(solver); break;
                case 17: RunTask17(solver); break;
                case 18: RunTask18(solver); break;
                case 19: RunTask19(solver); break;
                case 20: RunTask20(solver); break;
                default:
                    Console.WriteLine(
                        "Неверный номер задачи. " +
                        "Введите число от 0 до 20.");
                    break;
            }
        }
    }

    private static void RunTask1(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 1: Дробная часть");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: " + s.Fraction(ReadDouble()));
    }

    private static void RunTask2(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 2: Букву в число");
        Console.Write("Введите символ (0-9): ");
        Console.WriteLine(
            "Результат: " + s.CharToNum(ReadDigitChar()));
    }

    private static void RunTask3(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 3: Двузначное");
        Console.Write("Введите целое число: ");
        Console.WriteLine(
            "Результат: " + s.Is2Digits(ReadInt()));
    }

    private static void RunTask4(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 4: Диапазон");
        Console.Write("Введите a: ");
        int a = ReadInt();
        Console.Write("Введите b: ");
        int b = ReadInt();
        Console.Write("Введите num: ");
        Console.WriteLine(
            "Результат: " + s.IsInRange(a, b, ReadInt()));
    }

    private static void RunTask5(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 5: Равенство");
        Console.Write("Введите a: ");
        int a = ReadInt();
        Console.Write("Введите b: ");
        int b = ReadInt();
        Console.Write("Введите c: ");
        Console.WriteLine(
            "Результат: " + s.IsEqual(a, b, ReadInt()));
    }

    private static void RunTask6(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 6: Модуль числа");
        Console.Write("Введите целое число x: ");
        Console.WriteLine("Результат: " + s.Abs(ReadInt()));
    }

    private static void RunTask7(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 7: Тридцать пять");
        Console.Write("Введите целое число x: ");
        Console.WriteLine("Результат: " + s.Is35(ReadInt()));
    }

    private static void RunTask8(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 8: Тройной максимум");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        int y = ReadInt();
        Console.Write("Введите z: ");
        Console.WriteLine(
            "Результат: " + s.Max3(x, y, ReadInt()));
    }

    private static void RunTask9(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 9: Двойная сумма");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        Console.WriteLine(
            "Результат: " + s.Sum2(x, ReadInt()));
    }

    private static void RunTask10(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 10: День недели");
        Console.Write("Введите число x (1-7): ");
        Console.WriteLine("Результат: " + s.Day(ReadInt()));
    }

    private static void RunTask11(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 11: Числа подряд");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: \"" + s.ListNums(ReadInt()) + "\"");
    }

    private static void RunTask12(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 12: Четные числа");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: \"" + s.Chet(ReadInt()) + "\"");
    }

    private static void RunTask13(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 13: Длина числа");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: " + s.NumLen(ReadLong()));
    }

    private static void RunTask14(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 14: Квадрат");
        Console.Write("Введите размер x: ");
        s.Square(ReadInt());
    }

    private static void RunTask15(TaskSolver s)
    {
        Console.WriteLine(
            "\nЗадача 15: Правый треугольник");
        Console.Write("Введите высоту x: ");
        s.RightTriangle(ReadInt());
    }

    private static void RunTask16(TaskSolver s)
    {
        Console.WriteLine(
            "\nЗадача 16: Поиск первого значения");
        Console.WriteLine(
            "Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.Write("Введите искомое число x: ");
        Console.WriteLine(
            "Результат: " + s.FindFirst(arr, ReadInt()));
    }

    private static void RunTask17(TaskSolver s)
    {
        Console.WriteLine(
            "\nЗадача 17: Поиск максимального " +
            "по модулю");
        Console.WriteLine(
            "Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine("Результат: " + s.MaxAbs(arr));
    }

    private static void RunTask18(TaskSolver s)
    {
        Console.WriteLine(
            "\nЗадача 18: Добавление массива " +
            "в массив");
        Console.WriteLine(
            "Введите элементы исходного массива " +
            "arr через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine(
            "Введите элементы массива ins для " +
            "вставки через пробел:");
        int[] ins = ReadIntArray();
        Console.Write("Введите позицию pos: ");
        Console.WriteLine(
            "Результат: " +
            ArrayToString(s.Add(arr, ins, ReadInt())));
    }

    private static void RunTask19(TaskSolver s)
    {
        Console.WriteLine(
            "\nЗадача 19: Возвратный реверс");
        Console.WriteLine(
            "Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine(
            "Результат: " +
            ArrayToString(s.ReverseBack(arr)));
    }

    private static void RunTask20(TaskSolver s)
    {
        Console.WriteLine("\nЗадача 20: Все вхождения");
        Console.WriteLine(
            "Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.Write("Введите искомое число x: ");
        Console.WriteLine(
            "Результат: " +
            ArrayToString(s.FindAll(arr, ReadInt())));
    }
    

    private static double ReadDouble()
    {
        while (true)
        {
            if (double.TryParse(
                Console.ReadLine(), out double result))
            {
                return result;
            }
            Console.Write(
                "Некорректный ввод. Введите число: ");
        }
    }

    private static char ReadDigitChar()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input != null
                && input.Length == 1
                && input[0] >= '0'
                && input[0] <= '9')
            {
                return input[0];
            }
            Console.Write(
                "Некорректный ввод. " +
                "Введите одну цифру (0-9): ");
        }
    }

    private static int ReadInt()
    {
        while (true)
        {
            if (int.TryParse(
                Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.Write(
                "Некорректный ввод. " +
                "Введите целое число: ");
        }
    }

    private static long ReadLong()
    {
        while (true)
        {
            if (long.TryParse(
                Console.ReadLine(), out long result))
            {
                return result;
            }
            Console.Write(
                "Некорректный ввод. " +
                "Введите целое число: ");
        }
    }

    private static int[] ReadIntArray()
    {
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(
                    "Массив не может быть пустым. " +
                    "Попробуйте снова.");
                continue;
            }

            string[] parts = input.Split(' ');
            int count = 0;
            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            bool isValid = true;

            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    if (!int.TryParse(
                        part, out result[index]))
                    {
                        isValid = false;
                        break;
                    }
                    index++;
                }
            }

            if (isValid) return result;
            Console.WriteLine(
                "Некорректный ввод. " +
                "Введите целые числа " +
                "через пробел.");
        }
    }

    private static string ArrayToString(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return "[]";
        }
        string result = "[";
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
            if (i < arr.Length - 1)
            {
                result += ", ";
            }
        }
        result += "]";
        return result;
    }
}