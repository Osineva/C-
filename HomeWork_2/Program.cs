void Task10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    Random rnd = new Random();

    int number = rnd.Next(100, 1000);

    Console.WriteLine($"Выпало случайное число {number}");

    int f_digit = number / 10;
    int t_digit = f_digit % 10;

    Console.WriteLine($"Ответ {t_digit}");


}

void Task13()
{
    //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    int number = Input("Введите число ");

    if (number >= 100 & number < 1000)
    {
        int f_digit = number / 100;
        int t_digit = number % 10;
        Console.WriteLine(t_digit);
    }
    if (number > 1000)
    {
        while (number > 999 & number >= 100)
        {
            int t_digit = number / 10;
        
         t_digit= number % 10;
        Console.WriteLine(t_digit);
        }
}

}



void Task15()
{
    //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    Console.WriteLine("Введите № дня недели: ");
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
    else if (day == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (day == 7)
    {
        Console.WriteLine("Воскресенье");
    }

    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Не выходной");
    }
}


Task13();

