int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }
}

void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


void Task34()
{
    //Задача 34: Задайте массив заполненный случайными
    //положительными трёхзначными числами. Напишите
    //программу, которая покажет количество чётных чисел в
    //массиве.

    int size = Input("Введите размер массива ");
    int[] numbers = new int[size];
    FillArray(numbers);
    Print(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine(count);

}

void Task36()
{
    //Задача 36: Задайте одномерный массив, заполненный
    //случайными числами. Найдите сумму элементов с
    //нечётными индексами.
    int size = Input("Введите размер массива ");
    int[] numbers = new int[size];
    FillArray(numbers, 0, 15);
    Print(numbers);
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 1) sum += numbers[i];
    }
    Console.WriteLine(sum);

}

void Task38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите
    //разницу между максимальным и минимальным
    //элементами массива.
    int size = Input("Введите размер массива ");
    double[] numbers = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.NextDouble()*10;
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
double min = numbers[0];
double max = numbers[0];
   for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]>max) max = numbers[i];
        else if (numbers[i]<min) min = numbers[i];
    }
Console.WriteLine(max-min);

}


Task38();