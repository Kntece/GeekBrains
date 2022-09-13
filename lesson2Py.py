# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр. Учтите, что числа могут быть отрицательными
# num = input('Введите число: ')
# sum = 0
# i = 0
# while i < len(num):
#     match num[i]:
#         case '0' | '.' | '-':
#             i += 1
#         case _:
#             sum += int(num[i])
#             i += 1
# print(f'Сумма = {sum}')


# Напишите программу, которая принимает на вход число N и выдает набор произведений (набор - это список) чисел от 1 до N.
# n = int(input('Введите число N: '))
# num_list = []
#
# num = 1
# i = 1
# while i < n + 1:
#     match i:
#         case 1:
#             num_list.append(num)
#             i += 1
#         case _:
#             num *= i
#             num_list.append(num)
#             i += 1
# print(num_list)

# Палиндромом называется слово, которое в обе стороны читается одинаково: "шалаш", "кабак".
# value = input('Введите слово:')
# revers_string = value[::-1]
# if value == revers_string:
#     print('Это палиндром')
# else:
#     print('Не палиндром')

# Реализуйте выдачу случайного числа
# import time
#
# def my_random(minn, maxx):
#     time.sleep(0.3)
#     return int((time.time() % 1  * (maxx - minn)) + minn)
#
#
# for i in range(10):
#     print(my_random(1, 9))