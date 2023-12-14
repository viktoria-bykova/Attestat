// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int CalculateAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalculateAckermann(m - 1, 1);
    }
    else
    {
        return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
    }
}

int m1 = 2;
int n1 = 3;
Console.WriteLine("m = " + m1 + "; " + "n = " + n1 + " => A(m,n) = " + CalculateAckermann(m1, n1));

int m2 = 3;
int n2 = 2;
Console.WriteLine("m = " + m2 + "; " + "n = " + n2 + " => A(m,n) = " + CalculateAckermann(m2, n2));
