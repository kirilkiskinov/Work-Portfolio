import random

# Генериране на случайни резултати от теста
def generate_random_results(num_students):
    return [random.randint(0, 100) for _ in range(num_students)]

# Брой студенти
num_students = 20
results = generate_random_results(num_students)

# Функция за изчисляване на средния успех
def average_score(results):
    return sum(results) / len(results)

# Функция за намиране на най-високия резултат
def highest_score(results):
    return max(results)

# Функция за намиране на най-ниския резултат
def lowest_score(results):
    return min(results)

# Функция за отпечатване на резултатите на всички студенти
def print_results(results):
    for idx, score in enumerate(results):
        print(f"Студент {idx + 1}: {score} точки")

# Функция за отпечатване на вертикална хистограма
def print_histogram(results):
    histogram = [0] * 11  # Списък за броя на резултатите в интервалите

    # Броим резултатите в съответните интервали
    for score in results:
        if score == 100:
            histogram[10] += 1
        else:
            histogram[score // 10] += 1

    # Отпечатваме хистограмата до 80 - 89:
    for i in range(9): 
        print(f"{i * 10:02d} - {i * 10 + 9:02d}: {'*' * histogram[i]}")

    # Печатаме интервала 90 - 100
    print(f"90 - 100: {'*' * (histogram[9] + histogram[10])}")  # Включваме звездичките от 90 до 99 и 100 точки 

# Извикване на функциите и отпечатване на резултатите
print("Резултати от теста:")
print_results(results)
print(f"\nСреден успех: {average_score(results):.2f}")
print(f"Най-висок резултат: {highest_score(results)}")
print(f"Най-нисък резултат: {lowest_score(results)}")

print("\nВертикална хистограма на резултатите:")
print_histogram(results)

