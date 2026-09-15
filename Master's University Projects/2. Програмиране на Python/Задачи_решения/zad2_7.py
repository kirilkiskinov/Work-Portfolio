# Дефиниране на речник за студент
student = {
    "name": "Иван Иванов",
    "faculty_number": "123456",
    "specialty": "Компютърни науки",
    "subjects": {
        "Математика": 5,
        "Програмиране": 6,
        "Физика": 4,
        "Алгоритми": 5
    }
}

# Функция за изчисляване на средния успех на студента
def calculate_average_grade(student):
    grades = student["subjects"].values()
    average_grade = sum(grades) / len(grades)
    return round(average_grade, 2)

# Функция за отпечатване на оценките на студента
def print_student_grades(student):
    print(f"Оценки на {student['name']} (Факултетен номер: {student['faculty_number']}):")
    for subject, grade in student["subjects"].items():
        print(f"{subject}: {grade}")

print_student_grades(student)
average_grade = calculate_average_grade(student)
print(f"\nСреден успех: {average_grade}")
