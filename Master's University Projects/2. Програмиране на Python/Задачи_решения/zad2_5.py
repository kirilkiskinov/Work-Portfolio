import random

# Списък с имена на студентите
students = [
    {"name": "Алекс"},
    {"name": "Мария"},
    {"name": "Иван"},
    {"name": "Петър"},
    {"name": "Димитър"},
    {"name": "Анна"},
    {"name": "Елена"},
    {"name": "Георги"},
    {"name": "Виктория"},
    {"name": "Калина"}
]

# Генериране на случайни резултати за всеки студент
for student in students:
    student["score"] = random.randint(0, 100)

# Функция за изчисляване на средния успех на студентите
def calculate_average(students):
    total_score = sum(student["score"] for student in students)
    return total_score / len(students) if students else 0

# Функция за намиране на студента с най-високия резултат
def find_top_student(students):
    return max(students, key=lambda student: student["score"], default=None)

# Функция за намиране на студента с най-ниския резултат
def find_lowest_student(students):
    return min(students, key=lambda student: student["score"], default=None)

# Функция за отпечатване на резултатите на всички студенти
def print_all_scores(students):
    print("Резултати на всички студенти:")
    for student in students:
        print(f"{student['name']}: {student['score']} точки")

# Примерно използване на функциите
average_score = calculate_average(students)
top_student = find_top_student(students)
lowest_student = find_lowest_student(students)

print_all_scores(students)
print(f"\nСреден успех на студентите: {average_score:.2f}")
print(f"Студент с най-висок резултат: {top_student['name']} ({top_student['score']} точки)")
print(f"Студент с най-нисък резултат: {lowest_student['name']} ({lowest_student['score']} точки)")
