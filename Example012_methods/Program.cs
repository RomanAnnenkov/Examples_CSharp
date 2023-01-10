
void Method1()
{
    Console.WriteLine("Автор ...");
}

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method21(msg: "test", count: 4);

int Method3()
{
    return DateTime.Now.Year;
}

/* int year = Method3();
Console.WriteLine(year); */

string Method4(int count, string text)
{
    /* int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result; */
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

/* string res = Method4(10, "asdf");
Console.WriteLine(res); */

/* for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
} */

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
    }

    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

void SelectionSortReverse(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j; 
        }
        
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
Console.WriteLine();
SelectionSortReverse(arr);
PrintArray(arr);