# Списък със студенти
students = [
    {
        "name": "Иван Иванов",
        "faculty_number": "123456",
        "specialty": "Компютърни науки",
        "subjects": {"Математика": 5, "Програмиране": 6, "Физика": 4}
    },
    {
        "name": "Мария Георгиева",
        "faculty_number": "654321",
        "specialty": "Информационни технологии",
        "subjects": {"Математика": 6, "Програмиране": 5, "Алгоритми": 4}
    },
    {
        "name": "Петър Петров",
        "faculty_number": "111222",
        "specialty": "Компютърни науки",
        "subjects": {"Математика": 4, "Физика": 3}
    }
]

# Функция за изчисляване на среден успех на студент
def calculate_average_grade(student):
    grades = student["subjects"].values()
    return round(sum(grades) / len(grades), 2) if grades else 0

# 1. Среден успех на студентите, сортиран по възходящ/низходящ ред
def print_students_sorted_by_grade(students, ascending=True):
    sorted_students = sorted(students, key=calculate_average_grade, reverse=not ascending)
    for student in sorted_students:
        print(f"{student['name']} - Среден успех: {calculate_average_grade(student)}")

# 2. Извеждане на студенти от дадена специалност
def print_students_by_specialty(students, specialty):
    for student in students:
        if student["specialty"] == specialty:
            print(f"{student['name']} - Факултетен номер: {student['faculty_number']}")

# 3. Добавяне на нова дисциплина за даден студент
def add_subject(student_name, subject, grade):
    for student in students:
        if student["name"] == student_name:
            student["subjects"][subject] = grade
            print(f"Дисциплината '{subject}' е добавена на {student_name}.")
            return
    print(f"Студентът {student_name} не е намерен.")

# 4. Коригиране на оценка по дисциплина за даден студент
def update_grade(student_name, subject, new_grade):
    for student in students:
        if student["name"] == student_name:
            if subject in student["subjects"]:
                student["subjects"][subject] = new_grade
                print(f"Оценката по '{subject}' е актуализирана за {student_name}.")
                return
            else:
                print(f"Дисциплината '{subject}' не е намерена за {student_name}.")
                return
    print(f"Студентът {student_name} не е намерен.")

# 5. Изтриване на дисциплина за даден студент
def delete_subject(student_name, subject):
    for student in students:
        if student["name"] == student_name:
            if subject in student["subjects"]:
                del student["subjects"][subject]
                print(f"Дисциплината '{subject}' е изтрита за {student_name}.")
                return
            else:
                print(f"Дисциплината '{subject}' не е намерена за {student_name}.")
                return
    print(f"Студентът {student_name} не е намерен.")

# 6. Добавяне на студент към списъка
def add_student(name, faculty_number, specialty, subjects):
    students.append({
        "name": name,
        "faculty_number": faculty_number,
        "specialty": specialty,
        "subjects": subjects
    })
    print(f"Студентът {name} е добавен успешно.")

# 7. Изтриване на студент от списъка
def delete_student(student_name):
    for student in students:
        if student["name"] == student_name:
            students.remove(student)
            print(f"Студентът {student_name} е изтрит успешно.")
            return
    print(f"Студентът {student_name} не е намерен.")

# 8. Извеждане на данни за студентите, сортирани по име във възходящ ред
def print_students_sorted_by_name(students):
    sorted_students = sorted(students, key=lambda x: x["name"])
    for student in sorted_students:
        print(f"{student['name']} - Факултетен номер: {student['faculty_number']}")

# 9. Извеждане на данни за студентите, сортирани по успех в низходящ ред
def print_students_sorted_by_grade_desc(students):
    print_students_sorted_by_grade(students, ascending=False)


print("Среден успех на студентите (възходящ ред):")
print_students_sorted_by_grade(students)

print("\nСтуденти от специалност 'Компютърни науки':")
print_students_by_specialty(students, "Компютърни науки")

add_subject("Иван Иванов", "Алгоритми", 5)
update_grade("Мария Георгиева", "Математика", 5.5)
delete_subject("Петър Петров", "Физика")
add_student("Анна Димитрова", "333444", "Информационни технологии", {"Бази данни": 6, "Мрежи": 5})
delete_student("Мария Георгиева")

print("\nСтуденти, сортирани по име:")
print_students_sorted_by_name(students)

print("\nСтуденти, сортирани по успех (низходящ ред):")
print_students_sorted_by_grade_desc(students)
