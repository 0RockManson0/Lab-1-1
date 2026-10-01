using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Program solver = new Program();
        TaskSolver taskSolver = new TaskSolver();
        int choice;

        while (true)
        {
            Console.WriteLine(
                "\nЛабораторная работа №1");
            Console.WriteLine(
                "Выберите задачу (1-20) " +
                "или 0 для выхода:");
            choice = ReadInt();

            switch (choice)
            {
                case 0:
                    Console.WriteLine(
                        "Выход из программы.");
                    return;

                case 1:
                    solver.RunTask1(taskSolver);
                    break;
                case 2:
                    solver.RunTask2(taskSolver);
                    break;
                case 3:
                    solver.RunTask3(taskSolver);
                    break;
                case 4:
                    solver.RunTask4(taskSolver);
                    break;
                case 5:
                    solver.RunTask5(taskSolver);
                    break;
                case 6:
                    solver.RunTask6(taskSolver);
                    break;
                case 7:
                    solver.RunTask7(taskSolver);
                    break;
                case 8:
                    solver.RunTask8(taskSolver);
                    break;
                case 9:
                    solver.RunTask9(taskSolver);
                    break;
                case 10:
                    solver.RunTask10(taskSolver);
                    break;
                case 11:
                    solver.RunTask11(taskSolver);
                    break;
                case 12:
                    solver.RunTask12(taskSolver);
                    break;
                case 13:
                    solver.RunTask13(taskSolver);
                    break;
                case 14:
                    solver.RunTask14(taskSolver);
                    break;
                case 15:
                    solver.RunTask15(taskSolver);
                    break;
                case 16:
                    solver.RunTask16(taskSolver);
                    break;
                case 17:
                    solver.RunTask17(taskSolver);
                    break;
                case 18:
                    solver.RunTask18(taskSolver);
                    break;
                case 19:
                    solver.RunTask19(taskSolver);
                    break;
                case 20:
                    solver.RunTask20(taskSolver);
                    break;

                default:
                    Console.WriteLine(
                        "Неверный номер задачи. " +
                        "Введите число от 0 до 20.");
                    break;
            }
        }
    }

    private void RunTask1(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 1: Дробная часть");
        Console.Write("Введите число x: ");
        double x = ReadDouble();
        Console.WriteLine(
            "Результат: " + ts.Fraction(x));
    }

    private void RunTask2(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 2: Букву в число");
        Console.Write(
            "Введите символ (0-9): ");
        char ch = ReadDigitChar();
        Console.WriteLine(
            "Результат: " + ts.CharToNum(ch));
    }

    private void RunTask3(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 3: Двузначное");
        Console.Write(
            "Введите целое число: ");
        int num = ReadInt();
        Console.WriteLine(
            "Результат: " + ts.Is2Digits(num));
    }

    private void RunTask4(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 4: Диапазон");
        Console.Write("Введите a: ");
        int a = ReadInt();
        Console.Write("Введите b: ");
        int b = ReadInt();
        Console.Write("Введите num: ");
        int num = ReadInt();
        Console.WriteLine(
            "Результат: " +
            ts.IsInRange(a, b, num));
    }

    private void RunTask5(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 5: Равенство");
        Console.Write("Введите a: ");
        int a = ReadInt();
        Console.Write("Введите b: ");
        int b = ReadInt();
        Console.Write("Введите c: ");
        int c = ReadInt();
        Console.WriteLine(
            "Результат: " +
            ts.IsEqual(a, b, c));
    }

    private void RunTask6(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 6: Модуль числа");
        Console.Write(
            "Введите целое число x: ");
        int x = ReadInt();
        Console.WriteLine(
            "Результат: " + ts.Abs(x));
    }

    private void RunTask7(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 7: Тридцать пять");
        Console.Write(
            "Введите целое число x: ");
        int x = ReadInt();
        Console.WriteLine(
            "Результат: " + ts.Is35(x));
    }

    private void RunTask8(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 8: Тройной максимум");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        int y = ReadInt();
        Console.Write("Введите z: ");
        int z = ReadInt();
        Console.WriteLine(
            "Результат: " +
            ts.Max3(x, y, z));
    }

    private void RunTask9(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 9: Двойная сумма");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        int y = ReadInt();
        Console.WriteLine(
            "Результат: " + ts.Sum2(x, y));
    }

    private void RunTask10(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 10: День недели");
        Console.Write(
            "Введите число x (1-7): ");
        int x = ReadInt();
        Console.WriteLine(
            "Результат: " + ts.Day(x));
    }

    private void RunTask11(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 11: Числа подряд");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: \"" +
            ts.ListNums(ReadInt()) + "\"");
    }

    private void RunTask12(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 12: Четные числа");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: \"" +
            ts.Chet(ReadInt()) + "\"");
    }

    private void RunTask13(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 13: Длина числа");
        Console.Write("Введите число x: ");
        Console.WriteLine(
            "Результат: " +
            ts.NumLen(ReadLong()));
    }

    private void RunTask14(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 14: Квадрат");
        Console.Write("Введите размер x: ");
        ts.Square(ReadInt());
    }

    private void RunTask15(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 15: Правый " +
            "треугольник");
        Console.Write(
            "Введите высоту x: ");
        ts.RightTriangle(ReadInt());
    }

    private void RunTask16(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 16: Поиск " +
            "первого значения");
        Console.WriteLine(
            "Введите элементы " +
            "массива через пробел:");
        int[] arr = ReadIntArray();
        Console.Write(
            "Введите искомое число x: ");
        int x = ReadInt();
        Console.WriteLine(
            "Результат: " +
            ts.FindFirst(arr, x));
    }

    private void RunTask17(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 17: Поиск " +
            "максимального по модулю");
        Console.WriteLine(
            "Введите элементы " +
            "массива через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine(
            "Результат: " +
            ts.MaxAbs(arr));
    }

    private void RunTask18(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 18: Добавление " +
            "массива в массив");
        Console.WriteLine(
            "Введите элементы " +
            "исходного массива arr " +
            "через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine(
            "Введите элементы " +
            "массива ins для вставки " +
            "через пробел:");
        int[] ins = ReadIntArray();
        Console.Write(
            "Введите позицию pos: ");
        int pos = ReadInt();
        Console.WriteLine(
            "Результат: " +
            ArrayToString(
                ts.Add(arr, ins, pos)));
    }

    private void RunTask19(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 19: " +
            "Возвратный реверс");
        Console.WriteLine(
            "Введите элементы " +
            "массива через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine(
            "Результат: " +
            ArrayToString(
                ts.ReverseBack(arr)));
    }

    private void RunTask20(TaskSolver ts)
    {
        Console.WriteLine(
            "\nЗадача 20: Все вхождения");
        Console.WriteLine(
            "Введите элементы " +
            "массива через пробел:");
        int[] arr = ReadIntArray();
        Console.Write(
            "Введите искомое число x: ");
        int x = ReadInt();
        Console.WriteLine(
            "Результат: " +
            ArrayToString(
                ts.FindAll(arr, x)));
    }
    

    private static double ReadDouble()
    {
        string input;
        double result;
        while (true)
        {
            input = Console.ReadLine();
            if (double.TryParse(
                input, out result))
            {
                return result;
            }
            Console.Write(
                "Некорректный ввод. " +
                "Введите число: ");
        }
    }

    private static char ReadDigitChar()
    {
        while (true)
        {
            string input =
                Console.ReadLine();
            if (input != null
                && input.Length == 1
                && input[0] >= '0'
                && input[0] <= '9')
            {
                return input[0];
            }
            Console.Write(
                "Некорректный ввод. " +
                "Введите одну цифру " +
                "(0-9): ");
        }
    }

    private static int ReadInt()
    {
        string input;
        int result;
        while (true)
        {
            input = Console.ReadLine();
            if (int.TryParse(
                input, out result))
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
        string input;
        long result;
        while (true)
        {
            input = Console.ReadLine();
            if (long.TryParse(
                input, out result))
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
            string input =
                Console.ReadLine();
            if (string.IsNullOrWhiteSpace(
                input))
            {
                Console.WriteLine(
                    "Массив не может быть " +
                    "пустым. Попробуйте " +
                    "снова.");
                continue;
            }

            string[] parts =
                input.Split(' ');
            int count = 0;
            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(
                    part))
                {
                    count++;
                }
            }

            int[] result =
                new int[count];
            int index = 0;
            bool isValid = true;

            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(
                    part))
                {
                    if (!int.TryParse(
                        part,
                        out result[index]))
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

    private static string ArrayToString(
        int[] arr)
    {
        if (arr == null
            || arr.Length == 0)
        {
            return "[]";
        }
        string result = "[";
        for (int i = 0;
            i < arr.Length; i++)
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