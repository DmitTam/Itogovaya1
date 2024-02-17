
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"->[{arr[i]}, ]");
    }
}


