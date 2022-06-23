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


///=====================================================


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


///=====================================================


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
}  */


///=====================================================


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
    }  */


///___________________________________________________________________________________________________________


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
}
else 
{
    Console.WriteLine("Это не трёхзначное число");
} */


///=====================================================


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


///___________________________________________________________________________________________________________


///Задачи Практического задания #3

/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом. */

/* Console.Clear();
Console.WriteLine("Задача 19 ");
Console.WriteLine("Введите число:");
var s = (Console.ReadLine());
if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Число является палиндром");
else Console.WriteLine("Число не является палиндромом"); */


///=====================================================


/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве. */

/* Console.Clear();
Console.WriteLine("Задача 21 ");
Console.WriteLine("Введите A");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите A");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите A");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int z2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt((a1-a2)*(a1-a2) +
                          (b1-b2)*(b1-b2) +
                          (z1-z2)*(z1-z2));
Console.WriteLine(Math.Round(result,2)); */


///=====================================================


/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

/* Console.Clear();
Console.WriteLine("Задача 23");
Console.WriteLine("Введите целое положительное число");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.Write(Math.Pow(i,3) + " ");
    i++;
} */


///___________________________________________________________________________________________________________


///Задачи Практического задания #4

/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в 
натуральную степень B. */

/* Console.WriteLine("Задача 25");

int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation); */


///=====================================================


/* Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе. */

/* Console.WriteLine("Задача 27");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber); */


///=====================================================


/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран. */

/* int [] array = new int [15];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
} 

void PrintArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

PrintArray(array); */