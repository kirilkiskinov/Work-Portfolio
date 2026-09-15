# Функция, която проверява дали число е палиндром
def is_palindrome(number):
    number_as_text = str(number)
    # Проверка дали числото е същото, когато е обърнато
    return number_as_text == number_as_text[::-1]

# Въвеждане на няколко числа, разделени със запетая
input = input("Въведете няколко числа, разделени със запетая: ")

# Разделяме въведените числа и ги превръщаме в списък
numbers = [int(x) for x in input.split(',')]

# Проверка за всяко число дали е палиндром
for number in numbers:
    if is_palindrome(number):
        print(f"Числото {number} е палиндром.")
    else:
        print(f"Числото {number} не е палиндром.")
