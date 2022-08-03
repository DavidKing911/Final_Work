Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку: ");
    array[i] = Convert.ToString(Console.ReadLine());
}

string[] NewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    string[] mas = new string[count];
    int index = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            mas[index] = arr[j];
            index++;
        }
    }
    return mas;
}

void PrintArray(string[] arr)
{
    if(arr.Length == 0) Console.Write("[]");
    for (int j = 0; j < arr.Length; j++)
    {
        if (j == 0) Console.Write("[");
        Console.Write($"\"{arr[j]}\"");
        if (j < arr.Length - 1) Console.Write(", ");
        else Console.Write("]");
    }
}

string[] arr = NewArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(arr);