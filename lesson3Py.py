# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# list = [2, 3, 5, 9, 3]
# print(sum(list[1::2]))


# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# list = [2, 3, 5, 6]
# result = []
# for i in range((len(list)+1)//2):
#     result.append(list[i]*list[len(list)-1-i])
# print(result)


# Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# list = [4.07, 5.1, 8.2444, 6.98]
# min = 1
# max = 0
# for i in list:
#     if (i - int(i)) <= min:
#         min = i - int(i)
#     if (i - int(i)) >= max:
#         max = i - int(i)
# print(max-min)


# Напишите программу, которая будет преобразовывать десятичное число в двоичное. Подумайте, как это можно решить с помощью рекурсии.
# s = ""
# n = int(input("Введите число для преобразовывания:\n"))
# while n != 0:
#     s = str(n%2) + s
#     n //=2
# print(s)


# Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
# def Fibonacci(n):
#     if n in [1, 2]:
#         return 1
#     else:
#         return Fibonacci(n-1) + Fibonacci(n-2)
#
# def NegaFibonacci(n):
#     if n == 1:
#         return 1
#     elif n == 2:
#         return -1
#     else:
#         num1, num2 = 1, -1
#         for i in range(2, n):
#             num1, num2 = num2, num1 - num2
#         return num2
#
# list = [0]
# userNumber = int(input('Введите число: '))
# for e in range(1, userNumber + 1):
#     list.append(Fibonacci(e))
#     list.insert(0, NegaFibonacci(e))
# print(list)