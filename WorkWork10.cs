int n = InputInt("Введите количество элементов: ");
int[] number = new int[n];
int count = 1;
FillArray(number);

for (int i = 0; i < number.Length; i++)
{
    if (number[i] != 0)
    {
        int index = 0;
        int[] num2 = new int[number.Length];
        for (int k = i; k < number.Length; k++)
        {
            if (number[k] % number[i] != 0 || number[k] / number[i] == 1)
            {
                num2[index] = number[k];
                index++;
            }
        }
        for (int j = 1; j < num2.Length; j++)
        {
            for (int l = j + 1; l < num2.Length; l++)
            {
                if (num2[j] != 0 && num2[l] % num2[j] == 0)
                {
                    num2[l] = 0;
                }
            }
        }
        for (int f = 0; f < number.Length; f++)
        {
            for (int m = 0; m < num2.Length; m++)
            {
                if (num2[m] == number[f])
                {
                    number[f] = 0;
                }
            }
        }
        Console.Write($"группа {count++}: " );
        for (int k = 0; k < num2.Length; k++)
        {
            if (num2[k] != 0)
            {
                Console.Write(num2[k] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Количество групп: {count-1} " );

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = i + 1;
    }
}



