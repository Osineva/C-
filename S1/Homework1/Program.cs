void Task2()
{
/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.*/

Console.WriteLine("Введите первое число: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b)
{
    Console.WriteLine(number_a);
}
else{
Console.WriteLine(number_b);
}
}
 

 void Task4()
 {
 //Задача 4: Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
 
 Console.WriteLine("Введите первое число: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number_c = Convert.ToInt32(Console.ReadLine());

int max = number_a;
if (number_a > max) max = number_a;
if (number_b > max) max = number_b;
if (number_c > max) max = number_c;

Console.WriteLine(max);
 }
 

 void Task6()
 {
 // Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
{
Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}
 }


void Task8()
{
//Задача 8: Напишите программу, которая на вход
//принимает число (N > 0), а на выходе показывает все
//чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;

while (counter <= number)
{
if (number % 2 == 0)
{
Console.Write(counter + " ");
}
counter++;
}
}

Task8();

