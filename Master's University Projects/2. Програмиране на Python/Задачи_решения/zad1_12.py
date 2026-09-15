# Въвеждане на три числа от потребителя, разделени със запетая
numbers = input("Въведете три числа, разделени със запетая: ").split(',')

# Преобразуване на въведените стойности в числа (float)
number1 = float(numbers[0].strip())
number2 = float(numbers[1].strip())
number3 = float(numbers[2].strip())

# Определяне на най-голямото число
biggest = max(number1, number2, number3)

# Извеждане на резултата
print(f"Най-голямото от въведените числа е: {biggest}")
