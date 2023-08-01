void FillArrayD(double[,] matrix, int minValue = -100, int maxValue = 100)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
            matrix[i, j] = Math.Round(matrix[i, j], 2);
        }
    }
}

void PrintD(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}




void Task47()
{
    int rows = 5;
    int columns = 6;
    double[,] numbers = new double[rows, columns];

    FillArrayD(numbers);
    PrintD(numbers);

}

void Task50()
{
    Console.WriteLine("введите номер строки");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[10, 10];

    FillArrayRandomNumbers(numbers);

    if (rows > numbers.GetLength(0) || columns > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {numbers[rows - 1, columns - 1]}");
    }



}

void Task52()
{
    Console.WriteLine("введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[rows, columns];
    FillArrayRandomNumbers(numbers);


    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        
        avarage = avarage / rows;
        Console.Write(avarage + "; ");
    }
    Console.WriteLine();
    PrintArray(numbers);


}


Task52();




