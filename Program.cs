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
            Console.WriteLine("Выберите задачу (1-20) или 0 для выхода:");
            choice = ReadInt();

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Выход из программы.");
                    return;

                case 1: solver.RunTask1(); break;
                case 2: solver.RunTask2(); break;
                case 3: solver.RunTask3(); break;
                case 4: solver.RunTask4(); break;
                case 5: solver.RunTask5(); break;
                case 6: solver.RunTask6(); break;
                case 7: solver.RunTask7(); break;
                case 8: solver.RunTask8(); break;
                case 9: solver.RunTask9(); break;
                case 10: solver.RunTask10(); break;
                case 11: solver.RunTask11(); break;
                case 12: solver.RunTask12(); break;
                case 13: solver.RunTask13(); break;
                case 14: solver.RunTask14(); break;
                case 15: solver.RunTask15(); break;
                case 16: solver.RunTask16(); break;
                case 17: solver.RunTask17(); break;
                case 18: solver.RunTask18(); break;
                case 19: solver.RunTask19(); break;
                case 20: solver.RunTask20(); break;

                default:
                    Console.WriteLine("Неверный номер задачи. Введите число от 0 до 20.");
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
        Console.WriteLine("\nЗадача 4: Диапазон");
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
        Console.WriteLine("\nЗадача 6: Модуль числа");
        Console.Write("Введите целое число x: ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + Abs(x));
    }

    private void RunTask7()
    {
        Console.WriteLine("\nЗадача 7: Тридцать пять");
        Console.Write("Введите целое число x: ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + Is35(x));
    }

    private void RunTask8()
    {
        Console.WriteLine("\nЗадача 8: Тройной максимум");
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
        Console.WriteLine("\nЗадача 9: Двойная сумма");
        Console.Write("Введите x: ");
        int x = ReadInt();
        Console.Write("Введите y: ");
        int y = ReadInt();
        Console.WriteLine("Результат: " + Sum2(x, y));
    }

    private void RunTask10()
    {
        Console.WriteLine("\nЗадача 10: День недели");
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
        if (absX < 0) absX = -absX;
        return absX >= 10 && absX <= 99;
    }

    private bool IsInRange(int a, int b, int num)
    {
        int min = a;
        int max = b;
        if (a > b) { min = b; max = a; }
        return num >= min && num <= max;
    }

    private bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    private int Abs(int x)
    {
        if (x < 0) return -x;
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
        if (y > max) max = y;
        if (z > max) max = z;
        return max;
    }

    private int Sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19) return 20;
        return sum;
    }

    private string Day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    private void RunTask11()
    {
        Console.WriteLine("\nЗадача 11: Числа подряд");
        Console.Write("Введите число x: ");
        Console.WriteLine("Результат: \"" + ListNums(ReadInt()) + "\"");
    }

    private void RunTask12()
    {
        Console.WriteLine("\nЗадача 12: Четные числа");
        Console.Write("Введите число x: ");
        Console.WriteLine("Результат: \"" + Chet(ReadInt()) + "\"");
    }

    private void RunTask13()
    {
        Console.WriteLine("\nЗадача 13: Длина числа");
        Console.Write("Введите число x: ");
        Console.WriteLine("Результат: " + NumLen(ReadLong()));
    }

    private void RunTask14()
    {
        Console.WriteLine("\nЗадача 14: Квадрат");
        Console.Write("Введите размер x: ");
        Square(ReadInt());
    }

    private void RunTask15()
    {
        Console.WriteLine("\nЗадача 15: Правый треугольник");
        Console.Write("Введите высоту x: ");
        RightTriangle(ReadInt());
    }

    private void RunTask16()
    {
        Console.WriteLine("\nЗадача 16: Поиск первого значения");
        Console.WriteLine("Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.Write("Введите искомое число x: ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + FindFirst(arr, x));
    }

    private void RunTask17()
    {
        Console.WriteLine("\nЗадача 17: Поиск максимального по модулю");
        Console.WriteLine("Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine("Результат: " + MaxAbs(arr));
    }

    private void RunTask18()
    {
        Console.WriteLine("\nЗадача 18: Добавление массива в массив");
        Console.WriteLine("Введите элементы исходного массива arr через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine("Введите элементы массива ins для вставки через пробел:");
        int[] ins = ReadIntArray();
        Console.Write("Введите позицию pos: ");
        int pos = ReadInt();
        Console.WriteLine("Результат: " + ArrayToString(Add(arr, ins, pos)));
    }

    private void RunTask19()
    {
        Console.WriteLine("\nЗадача 19: Возвратный реверс");
        Console.WriteLine("Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.WriteLine("Результат: " + ArrayToString(ReverseBack(arr)));
    }

    private void RunTask20()
    {
        Console.WriteLine("\nЗадача 20: Все вхождения");
        Console.WriteLine("Введите элементы массива через пробел:");
        int[] arr = ReadIntArray();
        Console.Write("Введите искомое число x: ");
        int x = ReadInt();
        Console.WriteLine("Результат: " + ArrayToString(FindAll(arr, x)));
    }
    

    private string ListNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            result += i;
            if (i < x) result += " ";
        }
        return result;
    }

    private string Chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i += 2)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    private int NumLen(long x)
    {
        if (x == 0) return 1;
        long temp = x < 0 ? -x : x;
        int count = 0;
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        return count;
    }

    private void Square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            string row = "";
            for (int j = 0; j < x; j++) row += "*";
            Console.WriteLine(row);
        }
    }

    private void RightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            string spaces = "";
            for (int j = 0; j < x - i; j++) spaces += " ";
            
            string stars = "";
            for (int j = 0; j < i; j++) stars += "*";
            
            Console.WriteLine(spaces + stars);
        }
    }
    

    private int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }

    private int MaxAbs(int[] arr)
    {
        if (arr == null || arr.Length == 0) return 0;
        int maxVal = arr[0];
        int maxAbsVal = Abs(arr[0]);

        for (int i = 1; i < arr.Length; i++)
        {
            int currentAbs = Abs(arr[i]);
            if (currentAbs > maxAbsVal)
            {
                maxAbsVal = currentAbs;
                maxVal = arr[i];
            }
        }
        return maxVal;
    }

    private int[] Add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        int index = 0;
        
        for (int i = 0; i < pos && i < arr.Length; i++)
        {
            result[index] = arr[i];
            index++;
        }
        
        for (int i = 0; i < ins.Length; i++)
        {
            result[index] = ins[i];
            index++;
        }
        
        for (int i = pos; i < arr.Length; i++)
        {
            result[index] = arr[i];
            index++;
        }

        return result;
    }

    private int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    private int[] FindAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++;
        }

        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[index] = i;
                index++;
            }
        }
        return result;
    }
    

    private static double ReadDouble()
    {
        string input;
        double result;
        while (true)
        {
            input = Console.ReadLine();
            if (double.TryParse(input, out result)) return result;
            Console.Write("Некорректный ввод. Введите число: ");
        }
    }

    private static char ReadDigitChar()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input != null && input.Length == 1 && input[0] >= '0' && input[0] <= '9') return input[0];
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
            if (int.TryParse(input, out result)) return result;
            Console.Write("Некорректный ввод. Введите целое число: ");
        }
    }
    
    private static long ReadLong()
    {
        string input;
        long result;
        while (true)
        {
            input = Console.ReadLine();
            if (long.TryParse(input, out result)) return result;
            Console.Write("Некорректный ввод. Введите целое число: ");
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
                Console.WriteLine("Массив не может быть пустым. Попробуйте снова.");
                continue;
            }

            string[] parts = input.Split(' ');
            int count = 0;
            foreach (string part in parts) { if (!string.IsNullOrWhiteSpace(part)) count++; }

            int[] result = new int[count];
            int index = 0;
            bool isValid = true;

            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    if (!int.TryParse(part, out result[index]))
                    {
                        isValid = false;
                        break;
                    }
                    index++;
                }
            }

            if (isValid) return result;
            Console.WriteLine("Некорректный ввод. Введите целые числа через пробел.");
        }
    }
    
    private static string ArrayToString(int[] arr)
    {
        if (arr == null || arr.Length == 0) return "[]";
        string result = "[";
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
            if (i < arr.Length - 1) result += ", ";
        }
        result += "]";
        return result;
    }
}