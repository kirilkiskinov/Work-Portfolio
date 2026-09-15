# Въвеждане на две реални числа
number1 = float(input("Въведете първото число: "))
number2 = float(input("Въведете второто число: "))

# Проверка на знака на частното
if number1 == 0 or number2 == 0:
    print("Деление на нула е невъзможно!")
else:
    if (number1 > 0 and number2 > 0) or (number1 < 0 and number2 < 0):
        print("Знакът на частното е: +")
    else:
        print("Знакът на частното е: -")
