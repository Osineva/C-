void Task64()
{
//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

 Console.Write("Введите начало промежутка (M): ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите конец промежутка (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Натуральные числа, кратные 3, в промежутке от {0} до {1}:", M, N);
        PrintNumbersDivisibleByThree(M, N);
    }

    static void PrintNumbersDivisibleByThree(int start, int end)
    {
        if (start <= end)
        {
            if (start % 3 == 0)
            {
                Console.WriteLine(start);
            }
            PrintNumbersDivisibleByThree(start + 1, end);
        }

}

void Task66()
{
//Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.

int M = 1;
        int N = 10;

        
        int sum = SumOfNaturalNumbers(M, N);

        Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {sum}");
    }

    static int SumOfNaturalNumbers(int m, int n)
    {
        if (m > n) return 0; 

        return m + SumOfNaturalNumbers(m + 1, n);

}

void Task68()
{
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);



void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
}

Task68();



