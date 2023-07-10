namespace Pr_2._1;
class Program
{
    static void Main(string[] args)
    {


        /* // 9. Напишите программу, которая выводит
         //случайное число из отрезка [10, 99] и показывает
         //наибольшую цифру числа.

         Random rnd = new Random();
         //Random метод случайных чисел, rnd название, к которому обращаемся ниже
         int number = rnd.Next(10, 100);
         // Next создает случайные числа

         Console.WriteLine($"Выпало случайное число {number}");

         int f_digit = number / 10;
         int s_digit = number % 10;
         Console.WriteLine(f_digit);
         Console.WriteLine(s_digit);

         int max;

         if (f_digit > s_digit) max = f_digit;
         else max = s_digit;

         Console.WriteLine(max);

     */



        /* //11. Напишите программу, которая выводит случайное
         //трёхзначное число и удаляет вторую цифру этого числа.

         Random rnd = new Random();

         int number = rnd.Next(100, 1000);

         Console.WriteLine($"Выпало случайное число {number}");

         int f_digit = number / 100;
         int t_digit = number % 10;

         Console.WriteLine($"Ответ {f_digit}{t_digit}");
         Console.WriteLine($"Ответ {f_digit * 10 + t_digit}");

         */

        //. Напишите программу, которая будет принимать
        //на вход два числа и выводить, является ли второе
        //число кратным первому. Если число 2 не кратно числу
        //1, то программа выводит остаток от деления.

        /* int Input(string text)
         {
             Console.Write(text);
             return Convert.ToInt32(Console.ReadLine());
         }

         Console.Write("Введите первое число");
         int number_f = Convert.ToInt32(Console.ReadLine());

         int number_s = Input("Введите второе число");
         // Чтобы не печатать код в две строки, вызываем метод Input выше

         if (number_s % number_f == 0)
         {
         Console.WriteLine("$Число {number_s} кратно числу {number_f}");
         }
         else 
         {
         Console.WriteLine("$Число {number_s}  не кратно числу {number_f}."
                             + $"Остаток от деления равен {number_s % number_f}");
         }
 */
        /*// 14. Напишите программу, которая принимает на
        // вход число и проверяет, кратно ли оно
        //одновременно 7 и 23.

        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        int number = Input("Введите число");
        // & - и
        // | - или
        // && - сокращенное и
        if(number % 7 == 0 & number % 23 == 0)
        {
        Console.WriteLine($"{number} кратно 7 и 23 одновременно");
        }
        else 
        {
        Console.WriteLine($"{number} не кратно 7 и 23 одновременно");
        }
*/


        // 16. Напишите программу, которая принимает на
        //вход два числа и проверяет, является ли одно
        //число квадратом другого.

        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        int number_f = Input("Введите 1 число");
        int number_s = Input("Введите 2 число");

        if (number_f * number_f == number_s
        || number_s * number_s == number_f)
        {
            Console.WriteLine("Есть квадрат");
        }
        else
        {
            Console.WriteLine("Нет квадрата");
        }




    }

}