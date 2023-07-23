void Task24()
{
//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А

int number = 10;
int sum = 0;

for(int i = 1; i<=number; i++) 
{
Console.Write($"{i} + ");
sum +=i; // sum увеличиваем на i
}
Console.Write("\b\b= ");
Console.Write(sum);

}

void Task26()

{
//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе

int number = 17532;
int digitsCount = 0;

Console.Write($"В числе {number} - ");
while (number > 0)
{
number/=10;
//Console.WriteLine(number);
digitsCount++;
}
Console.WriteLine($"{digitsCount} цифр");


}

void Task28()
{
//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N

int number = 10;
int mult = 1;

for(int i = 1; i<=number; i++) 
{
Console.Write($"{i} * ");
mult *=i; 
}
Console.Write("\b\b= ");
Console.Write(mult);



}

void Task30()
{
//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.

int size = 6;

Random rnd = new Random();
int[] numbers = new int[size];
for(int i = 0; i<size; i++) 
{
numbers[i] = rnd.Next(0,2);
}

//Console.WriteLine(numbers[3]);

for(int i = 0; i<size; i++) 
{
Console.Write($"{i} ");
Console.WriteLine(numbers[i]);
}
Console.WriteLine();

}
Task30();
