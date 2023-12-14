// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNumbersBetweenInterval(int leftValue, int rightValue)
{
    if (leftValue > rightValue)
    {
        return;
    }

    Console.Write(" " + leftValue);
    PrintNumbersBetweenInterval(leftValue + 1, rightValue);
}

int M1 = 1; 
int N1 = 5;
Console.Write("M = " + M1 + "; " + "N = " + N1 + " => ");
PrintNumbersBetweenInterval(M1, N1);
Console.WriteLine();

int M2 = 4; 
int N2 = 8;
Console.Write("M = " + M2 + "; " + "N = " + N2 + " => ");
PrintNumbersBetweenInterval(M2, N2);
Console.WriteLine();