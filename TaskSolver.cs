using System;

internal class TaskSolver
{
    public double Fraction(double x)
    {
        double result = x - (int)x;
        return Math.Round(result, 10);
    }

    public int CharToNum(char x)
    {
        return x - '0';
    }

    public bool Is2Digits(int x)
    {
        int absX = x;
        if (absX < 0)
        {
            absX = -absX;
        }
        return absX >= 10 && absX <= 99;
    }

    public bool IsInRange(int a, int b, int num)
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

    public bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    public int Abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        return x;
    }

    public bool Is35(int x)
    {
        bool divBy3 = x % 3 == 0;
        bool divBy5 = x % 5 == 0;
        return (divBy3 || divBy5)
            && !(divBy3 && divBy5);
    }

    public int Max3(int x, int y, int z)
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

    public int Sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }
        return sum;
    }

    public string Day(int x)
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

    public string ListNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            result += i;
            if (i < x)
            {
                result += " ";
            }
        }
        return result;
    }

    public string Chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i += 2)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    public int NumLen(long x)
    {
        if (x == 0)
        {
            return 1;
        }
        long temp = x < 0 ? -x : x;
        int count = 0;
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        return count;
    }

    public void Square(int x)
    {
        string row;
        for (int i = 0; i < x; i++)
        {
            row = "";
            for (int j = 0; j < x; j++)
            {
                row += "*";
            }
            Console.WriteLine(row);
        }
    }

    public void RightTriangle(int x)
    {
        string spaces;
        string stars;
        for (int i = 1; i <= x; i++)
        {
            spaces = "";
            for (int j = 0; j < x - i; j++)
            {
                spaces += " ";
            }

            stars = "";
            for (int j = 0; j < i; j++)
            {
                stars += "*";
            }

            Console.WriteLine(spaces + stars);
        }
    }

    public int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int MaxAbs(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return 0;
        }
        int maxVal = arr[0];
        int maxAbsVal = Abs(arr[0]);
        int currentAbs;

        for (int i = 1; i < arr.Length; i++)
        {
            currentAbs = Abs(arr[i]);
            if (currentAbs > maxAbsVal)
            {
                maxAbsVal = currentAbs;
                maxVal = arr[i];
            }
        }
        return maxVal;
    }

    public int[] Add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[
            arr.Length + ins.Length];
        int index = 0;

        for (int i = 0;
            i < pos && i < arr.Length; i++)
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

    public int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    public int[] FindAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
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
}