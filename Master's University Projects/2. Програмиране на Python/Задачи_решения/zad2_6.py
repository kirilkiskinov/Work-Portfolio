class Employee:
    def __init__(self, name, age, height, weight):
        self.name = name
        self.age = age
        self.height = height  # височина в метри
        self.weight = weight  # тегло в килограми
        self.bmi = self.calculate_bmi()
        self.category, self.risk = self.determine_category_and_risk()
        self.weight_correction = self.calculate_weight_correction()

    def calculate_bmi(self):
        return round(self.weight / (self.height ** 2), 1)

    def determine_category_and_risk(self):
        if self.bmi < 18.5:
            return "Поднормено тегло", "Повишен"
        elif 18.5 <= self.bmi <= 24.9:
            return "Нормално тегло", "Нисък"
        elif 25.0 <= self.bmi <= 29.9:
            return "Наднормено тегло", "Повишен"
        elif 30.0 <= self.bmi <= 34.9:
            return "Затлъстяване I степен", "Средно висок"
        elif 35.0 <= self.bmi <= 39.9:
            return "Затлъстяване II степен", "Висок"
        else:
            return "Затлъстяване III степен", "Много висок"

    def calculate_weight_correction(self):
        # Изчисляваме минималното тегло, при което човек би имал ИТМ от 18.5, което е долната граница на нормалното тегло
        min_weight = 18.5 * (self.height ** 2)
        # Изчисляваме максималното тегло, при което човек би имал ИТМ от 24.9, което е горната граница на нормалното тегло
        max_weight = 24.9 * (self.height ** 2)
        if self.bmi < 18.5:
            return f"Трябва да качите {round(min_weight - self.weight, 1)} кг."
        elif self.bmi > 24.9:
            return f"Трябва да свалите {round(self.weight - max_weight, 1)} кг."
        else:
            return "Теглото Ви е в нормалния диапазон."

    def display_info(self):
        print(f"Име: {self.name}")
        print(f"Възраст: {self.age} години")
        print(f"Височина: {self.height} м")
        print(f"Тегло: {self.weight} кг")
        print(f"ИТМ: {self.bmi}")
        print(f"Категория: {self.category}")
        print(f"Риск за здравето: {self.risk}")
        print(f"Корекция на теглото: {self.weight_correction}")
        print("-" * 50)


# Създаване на списък със служители
employees = [
    Employee("Иван Иванов", 30, 1.75, 85),
    Employee("Мария Георгиева", 28, 1.62, 54),
    Employee("Петър Петров", 45, 1.80, 120),
    Employee("Анна Димитрова", 34, 1.55, 40),
]

# Принтиране на информацията за служителите
for employee in employees:
    employee.display_info()
