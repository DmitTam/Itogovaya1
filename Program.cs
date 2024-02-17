string[] CreateArrayFromConsole(string values)
{
    string str = values;
    string [] array = str.Split(' ').ToArray();
    Console.ReadKey();
    return array;
}

void CreateMiniArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        char [] ar = str.ToCharArray();
        if (ar.Length < 4) Console.Write($"{array[i]}, ");
    }
    
}

Console.WriteLine("введите значения через пробел");
string values = Console.ReadLine();
string[] array = CreateArrayFromConsole(values);
Console.Write("-> ");
CreateMiniArray(array);
