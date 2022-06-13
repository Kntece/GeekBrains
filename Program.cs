///Задачи Практического задания #1

/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, 
а какое меньшее. */

/* Console.WriteLine("Введите число a:");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Int32.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число a больше числа b");
    }
else
{
    Console.WriteLine("Число b больше числа a");
} */



/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел. */

/* Console.WriteLine("Введите число a:");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число c:");
int c = Int32.Parse(Console.ReadLine());
if ((a > b) & (a > c))
    Console.WriteLine("Число а является наибольшим");
else if ((b > a) & (b > c))
    Console.WriteLine("Число b является наибольшим");
else if ((c > a) & (c > b))
    Console.WriteLine("Число с является наибольшим"); */



/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка). */

/* Console.WriteLine("Введите число:");
int a = Int32.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
} */



/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

/* Console.WriteLine("Введите число n:");
int n = Int32.Parse(Console.ReadLine());
int i = 0;
while (i <= n)
    {
        if (i % 2 == 0)
        Console.Write(i + " ");
        i++;
    } */


///Задачи Практического задания #2

/* Задача 10: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру, 
этого числа. */

/* Console.Clear();
Console.WriteLine("Задача 10 ");
Console.WriteLine("Введите трёхзначное число:");
int n = int.Parse(Console.ReadLine());
if ((n > 99) & (n < 1000))
{
    int a1 = (n / 10) % 10;
    Console.WriteLine ($"{a1}");
} */

/* Задача 15: Напишите программу, которая принимает на вход
цифру, обозначающую день недели, и проверяет является ли этот 
день выходным. */

/* Console.Clear();
Console.WriteLine("Задача 15 ");
Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7");
int n = Int32.Parse(Console.ReadLine());
if (n < 6)
    Console.WriteLine("Рабочие дни.");
else if (n == 6)
    Console.WriteLine("Суббота.");
else if (n == 7)
    Console.WriteLine("Воскресенье.");
else if (n > 7)
    Console.WriteLine("Большей дней недели нет."); */

///Задачи Практического задания #3

