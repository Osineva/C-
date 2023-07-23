int Input(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

// Создать массив
void FillArray(int[] numbers)
{
Random rnd = new Random();
for(int i = 0; i < numbers.Length; i++)
{
numbers[i]=rnd.Next(-9,10);
}
}

// Напечатать массив
void Print(int[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
}

// Сумма положительных элементов
int SumPositive(int[] numbers)
{
    int sumPositive = 0;
for(int i = 0; i<numbers.Length; i++)
{
if (numbers[i]>0) sumPositive+=numbers[i];
}
return SumPositive;
}