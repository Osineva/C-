int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task19()
{
    Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");

    int number = Input("Введите пятизначное число ");
    string num = Convert.ToString(number); // нужно для массива

    if (number > 9999 && number < 100000)
    {
        if (num[0] == num[4] || num[1] == num[3])
        {
            Console.WriteLine($"{number} - палиндром.");
        }
        else Console.WriteLine($"{number} - НЕ палиндром.");
    }
    else Console.WriteLine("Введено НЕ пятизначное число");
}

void Task21()
{
    Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");

int x1 = Input("x1= ");
int y1 = Input("y1= ");
int z1 = Input("z1= ");
int x2 = Input("x2= ");
int y2 = Input("y2= ");
int z2 = Input("z2= ");

 double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
 result = Math.Round(result,2);
 Console.WriteLine($"Расстояние м/у точками: {result}");
}

void Task23()
{
    Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");

int number = Input("Введите число ");

int counter =1;

while(counter<=number)
{
Console.WriteLine($"{counter}^3={Math.Pow(counter, 3)}");
counter++;
}

}

Task23();












