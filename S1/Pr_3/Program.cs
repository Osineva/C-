int Input(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

void Task17()
{
// Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка

int x = Input("x");
int y = Input("y");

if (x > 0 && y >0)
{
Console.WriteLine("1");
}
else if(x < 0 && y > 0 )
{
Console.WriteLine("2");
}
else if(x < 0 && y < 0 )
{
Console.WriteLine("3");
}
else if(x > 0 && y < 0 )
{
Console.WriteLine("4");
}

}

void Task18()
{
//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

int quater = Input("Четверть ");


if (quater == 1)
{
Console.WriteLine("x > 0 && y >0");
}
else if(quater == 2)
{
Console.WriteLine("x < 0 && y > 0");
}
else if(quater == 3)
{
Console.WriteLine("x < 0 && y < 0");
}
else if(quater == 4)
{
Console.WriteLine("x > 0 && y < 0");
}

}


void Task21()

//Задача 21: Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек
//и находит расстояние между ними в 2D
//пространстве.
{
int x1 = Input("x1 ");
int y1 = Input("y1 ");
int x2 = Input("x2 ");
int y2 = Input("y2 ");

 double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y1 - y1),2));
 result = Math.Round(result,2);
 Console.WriteLine($"Расстояние м/у точками: {result}");

}

void Task22()
{
//Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

int number = Input("Введите число ");

// через while
//int counter =1;

//while(counter<=number)
//{
//Console.WriteLine($"{counter}^2={Math.Pow(counter, 2)}");
//counter++;
//}

// через for

for(int counter =1; counter<=number; counter++)
{
Console.WriteLine($"{counter}^2={Math.Pow(counter, 2)}");
}




}
Task22();


