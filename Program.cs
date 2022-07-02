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


///___________________________________________________________________________________________________________


///Задачи Практического задания #5

/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */

/* Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
} */


///=====================================================


/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях. */

/* Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
} */


///=====================================================


/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */


/* Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
} */


///___________________________________________________________________________________________________________


///Задачи Практического задания #6

/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь. */

/* Console.Clear();

Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь");
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} "); */


///=====================================================


/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *

x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем. */


/* Console.WriteLine($"\nЗадача 43.  Найти точку пересечения двух прямых");

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff); */


///___________________________________________________________________________________________________________


///Задачи Практического задания #7

/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами. */


/* Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
} */


///=====================================================


/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет */

/* Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
} */


///=====================================================


/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. */


/* Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
} */