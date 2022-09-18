int count = 0;
string word;
string[] set;
set = new string[count];

string[] setTwo;

Console.WriteLine("to stop typing, press esc");
do
{
    Console.Write("Enter any world: ");
    word = Console.ReadLine();
    count++;
    setTwo = new string[count];
    for (int i = 0; i < setTwo.Length - 1; i++)
    {
        setTwo[i] = set[i];
    }
    setTwo[count - 1] = word;

    set = setTwo;
} while (Console.ReadKey().Key != ConsoleKey.Escape);

string[] ChoiseThre(string[] arr)
{
    string[] newArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) newArr[i] = arr[i];
    }
    string[] test = newArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    return test;
}

void PrintArrayString(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[^1]}\"]");
}


string[] testValue = ChoiseThre(set);
Console.WriteLine();

PrintArrayString(set);
Console.Write(" -> ");
PrintArrayString(testValue);
Console.WriteLine();

// int letghtone = set.Length;
// int lenghttwo = testValue.Length;
// Console.WriteLine($"{letghtone}, {lenghttwo}");