/*
// 0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
int number = 5;
int result = number * number;
Console.WriteLine(result);
*/

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.WriteLine("Введите первое число: ");
int number_f = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_s = Convert.ToInt32(Console.ReadLine());

// == это сравнение
// = это присвоение
if (number_f == number_s * number_s)
{
    Console.WriteLine("Первая переменная явл кв второй");
}
else{
Console.WriteLine("Первая переменная не явл кв второй");
}
*/

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

/* Console.WriteLine("Введите № дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
Console.WriteLine("Понедельник");
}
else if (day == 2)
{
Console.WriteLine("Вторник");
}
else if (day == 3)
{
Console.WriteLine("Среда");
}
else if (day == 4)
{
Console.WriteLine("Четверг");
}
else if (day == 5)
{
Console.WriteLine("Пятница");
}
else  (day == 6)
{
Console.WriteLine("Суббота");
}
else if (day == 7)
{
Console.WriteLine("Воскресенье");
}
*/

/*
// 5. Напишите программу вычисления значения функции возведения числа в квадрат.

int Power(int number)
{
int result = number * number;
return result;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = Power(num);
Console.WriteLine(result);

*/

void Task7()
{
// 7. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int counter = -num;

// до тех пор, пока не дcounter <= num

while (counter < num)
{
Console.Write(counter + " ");
// WriteLine пишет каждое значение с новой строки
// Write пишет все значения в одну строку "+ " " " - прописывает с пробелом
counter++;
}
}
Task7();






