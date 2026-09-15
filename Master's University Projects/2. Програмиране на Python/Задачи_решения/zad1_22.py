# Изчисляване със for цикъл
sum_for = 0
for number in range(1, 101):
    sum_for += number
average_for = sum_for / 100

# Изчисляване с while цикъл
sum_while = 0
count = 1
while count <= 100:
    sum_while += count
    count += 1
average_while = sum_while / 100

# Извеждане на резултатите
print(f"Сумата на числата от 1 до 100 (използвайки for) е: {sum_for}")
print(f"Средната стойност на числата от 1 до 100 (използвайки for) е: {average_for:.2f}")

print(f"Сумата на числата от 1 до 100 (използвайки while) е: {sum_while}")
print(f"Средната стойност на числата от 1 до 100 (използвайки while) е: {average_while:.2f}")
