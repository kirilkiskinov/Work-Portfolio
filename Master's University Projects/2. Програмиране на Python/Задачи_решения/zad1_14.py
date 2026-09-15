# Въвеждане на две числа от потребителя
number1 = float(input("Въведете първото число: "))
number2 = float(input("Въведете второто число: "))

# Проверка за деление на нула
if number2 == 0:
    print("Грешка: Деление на нула е невъзможно!")
else:
    result = number1 / number2
    print(f"Резултатът от делението на {number1} и {number2} е: {result}")
