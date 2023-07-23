int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] numbers, int minValue = -9, int maxValue =9)
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



void Task31()
{
    //Задача 31: Задайте массив из 12 элементов, заполненный
    //случайными числами из промежутка [-9, 9]. Найдите сумму
    //отрицательных и положительных элементов массива

    int size = 12; //Input("Введите размер массива ");

    int[] numbers = new int[size];

    FillArray(numbers);

    Print(numbers);

    int sumPositive = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sumPositive += numbers[i];
    }
    Console.WriteLine($"Сумма пол эл = {sumPositive}");

    int sumNegative = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sumNegative += numbers[i];
    }
    Console.WriteLine($"Сумма отр эл = {sumNegative}");
}

void Task32()
{
    //Задача 32: Напишите программу замены элементов
    //массива: положительные элементы замените на
    //соответствующие отрицательные, и наоборот.

    int size = 12; //Input("Введите размер массива ");

    int[] numbers = new int[size];

    FillArray(numbers);

    Print(numbers);

for (int i = 0; i < numbers.Length; i++) //Перебирает массив
    {
       numbers[i]*=-1; 
    }
Print(numbers);
}


void Task33()
{
//Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.

int size = 5; //Input("Введите размер массива ");

    int[] numbers = new int[size];
    FillArray(numbers);
    Print(numbers);

int num = Input("Введите иск знач");
bool flag = false;
    for (int i = 0; i < numbers.Length; i++) //Перебирает массив
    {
     if (numbers[i] == num) flag = true;  
    }
if (flag) Console.WriteLine("yes");
else Console.WriteLine("no");
}


void Task35()
{
//Задача 35: Задайте одномерный массив из 10 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99]. 
int size = 10; //Input("Введите размер массива ");
    int[] numbers = new int[size];
    FillArray(numbers, -50,100);
    Print(numbers);
int count = 0;
for (int i = 0; i < numbers.Length; i++) //Перебирает массив
    {
     if (numbers[i] >= 10 && numbers[i]<=99) count++;  
    }
Console.WriteLine($"Найдено элементов {count}");
}

void Task37()
{
//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

int size = 5; //Input("Введите размер массива ");
    int[] numbers = new int[size];
    FillArray(numbers, 0,15);
    Print(numbers);

    int LastIndex = numbers.Length-1;

for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine($"{numbers[i]}*{numbers[LastIndex-i]} = {numbers[i]*numbers[LastIndex-i]}");
}

}
Task37();