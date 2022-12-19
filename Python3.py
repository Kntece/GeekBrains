# n = int(input())
#
# s = ''
# h = '0123456789ABCDEF'
#
# while n > 0:
#     s = h[n % 16] + s
#     n = n // 16
#
# print(s)


# str = '10.3'
# try:
#     float(str)
#     if str.find('.') != -1 and str.count('.') == 1:
#         print('Дробное')
#     else:
#         raise ValueError
# except ValueError:
#     print('Не дробное')