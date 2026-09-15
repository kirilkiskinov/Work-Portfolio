import math

# Клас за точка в равнината
class Point:
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def __repr__(self):
        return f"({self.x}, {self.y})"

# Клас за управление на равнината
class Plane:
    def __init__(self):
        self.points = []  # Списък с точки в равнината

    # Добавяне на точка в равнината
    def add_point(self, x, y):
        self.points.append(Point(x, y))
        print(f"Точка {x, y} е добавена.")

    # Изтриване на точка от равнината
    def delete_point(self, x, y):
        for point in self.points:
            if point.x == x and point.y == y:
                self.points.remove(point)
                print(f"Точка {x, y} е изтрита.")
                return
        print(f"Точка {x, y} не е намерена.")

    # Изчисляване на изминатия път на обекта
    def calculate_distance(self):
        if len(self.points) < 2:
            print("Не може да се изчисли път, защото няма достатъчно точки.")
            return 0

        distance = 0
        for i in range(len(self.points) - 1): # Преминава през индексите на точките в списъка, но не включва последната точка, защото ще се сравняват съседни точки, а последната точка няма следваща точка, с която да се изчисли разстоянието
            dx = self.points[i + 1].x - self.points[i].x # Разликата по координатата x между съседни точки. Това показва хоризонталното разстояние между точките
            dy = self.points[i + 1].y - self.points[i].y # Разликата по координатата y между съседни точки. Това показва вертикалното разстояние между точките
            distance += math.sqrt(dx**2 + dy**2) # Формулата за разстояние между две точки в равнината (по теоремата на Питагор). Изчислява хипотенузата на правоъгълен триъгълник, като dx е една страна, а dy е другата.
        return round(distance, 2)

    # Извеждане на точки, които се намират в подравнина
    def points_in_subplane(self, x_min, x_max, y_min, y_max): # задава границите на подравнината (правоъгълника), в който търсим точките.
        subplane_points = [
            point for point in self.points #  list comprehension (синтаксис за създаване на нов списък), който преминава през всички точки в списъка и избира само тези, които попадат в зададения диапазон.
            if x_min <= point.x <= x_max and y_min <= point.y <= y_max
        ]
        return subplane_points

    # Отпечатване на всички точки
    def print_points(self):
        if not self.points:
            print("Няма добавени точки.")
        else:
            print("Точки в равнината:")
            for point in self.points:
                print(point)

# Функция за извеждане на менюто
def display_menu():
    print("\n--- Меню ---")
    print("1. Добавяне на точка")
    print("2. Изтриване на точка")
    print("3. Изчисляване на изминатия път")
    print("4. Извеждане на точки в подравнина")
    print("5. Извеждане на всички точки")
    print("6. Изход")

# Главна програма
def main():
    plane = Plane()

    while True:
        display_menu()
        choice = input("Изберете опция: ")

        if choice == "1":
            x = float(input("Въведете x координата: "))
            y = float(input("Въведете y координата: "))
            plane.add_point(x, y)

        elif choice == "2":
            x = float(input("Въведете x координата на точката за изтриване: "))
            y = float(input("Въведете y координата на точката за изтриване: "))
            plane.delete_point(x, y)

        elif choice == "3":
            distance = plane.calculate_distance()
            print(f"Изминатият път е: {distance} единици.")

        elif choice == "4":
            x_min = float(input("Въведете минимална x координата: "))
            x_max = float(input("Въведете максимална x координата: "))
            y_min = float(input("Въведете минимална y координата: "))
            y_max = float(input("Въведете максимална y координата: "))
            subplane_points = plane.points_in_subplane(x_min, x_max, y_min, y_max)
            if subplane_points:
                print("Точки в подравнината:")
                for point in subplane_points:
                    print(point)
            else:
                print("Няма точки в подравнината.")

        elif choice == "5":
            plane.print_points()

        elif choice == "6":
            print("Изход от програмата.")
            break

        else:
            print("Невалидна опция. Опитайте отново.")

if __name__ == "__main__": # checks if the current script is being run directly as the main program, or if it's being imported as a module into another program
    main()