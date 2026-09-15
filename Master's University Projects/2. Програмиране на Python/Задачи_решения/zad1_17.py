import random

# Въвеждане на числото N от потребителя
N = int(input("Въведете положително цяло число N: "))

# Генериране и отпечатване на 5 случайни числа в интервала от 1 до N
print(f"5 случайни числа в интервала от 1 до {N} са:")

for a in range(5):
    random_number = random.randint(1, N)
    print(random_number)
