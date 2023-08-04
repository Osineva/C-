





void Task54()
{
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
 //двумерного массива.


                int[,] array = { 
                { 1, 4, 7, 2 }, 
                { 5, 9, 2, 3 }, 
                { 8, 4, 2, 4 }
                 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

               SortRowsDescending(array);

        Console.WriteLine("\nМассив после сортировки:");
        PrintArray(array);
    }

    static void SortRowsDescending(int[,] array)
    {
               int rows = array.GetLength(0);
        int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
        {
                        for (int j = 1; j < cols; j++)
            {
                int key = array[i, j];
                int k = j - 1;

                while (k >= 0 && array[i, k] < key)
                {
                    array[i, k + 1] = array[i, k];
                    k--;
                }

                array[i, k + 1] = key;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }



void Task56()
{
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.

 int[,] array = {
            { 1, 4, 7, 2 }, 
            { 5, 9, 2, 3 }, 
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        
        int minSum = int.MaxValue; 
        int minSumRow = 0; 

        for (int i = 0; i < array.GetLength(0); i++) 
        {
            int sum = 0; 

            for (int j = 0; j < array.GetLength(1); j++) 
            {
                sum += array[i, j]; 
            }

            if (sum < minSum) 
            {
                minSum = sum; 
                minSumRow = i; 
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");


}

void Task58()
{
//Задача 58: Заполните спирально массив 4 на 4 числами oт 1 до 16.

int[,] array = new int[4, 4];
        int number = 1;
        int rowStart = 0, rowEnd = 3;
        int colStart = 0, colEnd = 3;

        while (number <= 16)
        {
            
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = number;
                number++;
            }
            rowStart++;

            
            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = number;
                number++;
            }
            colEnd--;

            
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = number;
                number++;
            }
            rowEnd--;

            
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = number;
                number++;
            }
            colStart++;
        }

        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{array[i, j],2} ");
            }
            Console.WriteLine();
        }


}

Task58();