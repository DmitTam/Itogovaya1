string[] CreateArrayFromConsole(string values)
{
    string str = values;
    string [] array = str.Split(' ').ToArray();
    Console.ReadKey();
    return array;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"->[{arr[i]}, ]");
    }
}

Console.WriteLine("введите значения через пробел");
string values = Console.ReadLine();
string[] array = CreateArrayFromConsole(values);
PrintArray(array);
