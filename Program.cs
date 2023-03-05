/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоночальный массив можно ввести с клавиатуры, либо зажать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[] arrayStr = new string[] { "one", "two", "three", "four", "five", "six", "seven" };
PrintArray(arrayStr);
string[] arrayStrResult = ArrayStrUpToTreeChar(arrayStr);
Console.Write(" -> ");
PrintArray(arrayStrResult);

string[] ArrayStrUpToTreeChar(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    string[] arrResult = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrResult[j] = array[i];
            j++;
        }
    }
    return arrResult;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        if (i == array.Length - 1) Console.Write($"\"{array[i]}\"");
        else Console.Write($"\"{array[i]}\", ");
    Console.Write("]");
}
