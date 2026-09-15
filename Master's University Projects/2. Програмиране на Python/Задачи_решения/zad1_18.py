import random

# Генериране на случайно число в интервала от 1 до 100
secret_number = random.randint(1, 100)
tries = 0  # Брояч за опитите на потребителя

print("Опитайте се да отгатнете числото в интервала от 1 до 100!")

# Започва цикълът за отгатване
while True:
    guess = int(input("Въведете вашето предположение: "))
    tries += 1  # Увеличаваме броя на опитите с 1

    # Проверка дали предположението е по-голямо, по-малко или точно
    if guess < secret_number:
        print("Try higher")
    elif guess > secret_number:
        print("Try lower")
    else:
        print(f"You win! You got it in {tries} tries.")
        break  # Край на цикъла при успешно отгатване
