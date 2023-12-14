// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void ReverseArray(int[] array, int start, int end)
{
    if (start >= end)
        return;

    int temp = array[start];
    array[start] = array[end];
    array[end] = temp;

    ReverseArray(array, start + 1, end - 1);
}

void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
}

int[] sourceArray = { 1, 2, 5, 0, 10, 34 };
PrintArray(sourceArray);
Console.Write(" => ");
ReverseArray(sourceArray, 0, sourceArray.Length - 1);
PrintArray(sourceArray);


