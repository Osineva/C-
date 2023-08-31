string[] inputArray = { "Russia", "Denmark", "Kazan", "1234", "1567", "-2", "computer science" };

int count = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] filteredArray = new string[count];

int index = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        filteredArray[index] = str;
        index++;
    }
}

Console.WriteLine("Filtered Array:");
foreach (string str in filteredArray)
{
    Console.WriteLine(str);
}

