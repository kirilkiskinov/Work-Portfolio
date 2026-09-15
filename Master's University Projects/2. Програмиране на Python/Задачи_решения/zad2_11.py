import itertools
import math

# Функция за генериране на точки в 2D равнината
def generate_points(num_points, x_range, y_range):
    """
    Генерира списък с точки в 2D равнината.
    :param num_points: Брой точки за генериране.
    :param x_range: Обхват за координатите x (tuple: (min_x, max_x)).
    :param y_range: Обхват за координатите y (tuple: (min_y, max_y)).
    :return: Списък с точки (като tuples: (x, y)).
    """
    import random
    points = [(random.uniform(*x_range), random.uniform(*y_range)) for _ in range(num_points)]
    return points


# Функция за проверка дали три точки образуват триъгълник
def is_valid_triangle(p1, p2, p3):
    """
    Проверява дали три точки образуват валиден триъгълник.
    :param p1, p2, p3: Координати на точките (x, y).
    :return: True, ако образуват триъгълник; False, в противен случай.
    """
    # Изчисляване на дължините на страните
    a = distance(p1, p2)
    b = distance(p2, p3)
    c = distance(p1, p3)
    return a + b > c and a + c > b and b + c > a


# Функция за изчисляване на разстояние между две точки
def distance(p1, p2):
    """
    Изчислява разстоянието между две точки.
    :param p1, p2: Координати на точките (x, y).
    :return: Разстоянието между точките.
    """
    return math.sqrt((p2[0] - p1[0])**2 + (p2[1] - p1[1])**2)


# Функция за изчисляване на периметъра на триъгълник
def calculate_perimeter(p1, p2, p3):
    """
    Изчислява периметъра на триъгълник.
    :param p1, p2, p3: Координати на точките (x, y).
    :return: Периметърът на триъгълника.
    """
    return distance(p1, p2) + distance(p2, p3) + distance(p1, p3)


# Функция за изчисляване на площта на триъгълник
def calculate_area(p1, p2, p3):
    """
    Изчислява площта на триъгълник по формулата на Херон.
    :param p1, p2, p3: Координати на точките (x, y).
    :return: Площта на триъгълника.
    """
    a = distance(p1, p2)
    b = distance(p2, p3)
    c = distance(p1, p3)
    s = (a + b + c) / 2  # Полупериметър
    return math.sqrt(s * (s - a) * (s - b) * (s - c))


# Функция за определяне на типа на триъгълника
def triangle_type(p1, p2, p3):
    """
    Определя типа на триъгълника - равностранен, равнобедрен или разностранен.
    :param p1, p2, p3: Координати на точките (x, y).
    :return: Тип на триъгълника (string).
    """
    a = distance(p1, p2)
    b = distance(p2, p3)
    c = distance(p1, p3)

    if math.isclose(a, b) and math.isclose(b, c):
        return "Равностранен"
    elif math.isclose(a, b) or math.isclose(b, c) or math.isclose(a, c):
        return "Равнобедрен"
    else:
        return "Разностранен"


# Основна програма
def main():
    # Генериране на точки
    points = generate_points(num_points=6, x_range=(0, 10), y_range=(0, 10))
    print("Генерирани точки:", points)

    # Намиране на всички възможни триъгълници
    triangles = []
    for p1, p2, p3 in itertools.combinations(points, 3):
        if is_valid_triangle(p1, p2, p3):
            perimeter = calculate_perimeter(p1, p2, p3)
            area = calculate_area(p1, p2, p3)
            triangles.append({"points": (p1, p2, p3), "perimeter": perimeter, "area": area, "type": triangle_type(p1, p2, p3)})

    # Брой на триъгълниците
    print(f"Общо възможни триъгълници: {len(triangles)}")

    # Информация за всеки триъгълник
    for i, triangle in enumerate(triangles):
        p1, p2, p3 = triangle["points"]
        print(f"Триъгълник {i+1}: Върхове {p1}, {p2}, {p3}, Периметър: {triangle['perimeter']:.2f}, Площ: {triangle['area']:.2f}, Тип: {triangle['type']}")

    # Намиране на триъгълника с най-голяма площ
    if triangles:
        largest_triangle = max(triangles, key=lambda t: t["area"])
        p1, p2, p3 = largest_triangle["points"]
        print("\nТриъгълник с най-голяма площ:")
        print(f"Върхове: {p1}, {p2}, {p3}, Периметър: {largest_triangle['perimeter']:.2f}, Площ: {largest_triangle['area']:.2f}, Тип: {largest_triangle['type']}")

    # Записване на данните в текстов файл
    with open("triangles.txt", "w", encoding="utf-8") as file: # "w" = write; with = контекстен мениджър, който автоматично се грижи за отваряне и затваряне на ресурси. Дори ако възникне грешка по време на работа с файла, той ще бъде затворен коректно
        file.write("Информация за триъгълниците:\n")
        for i, triangle in enumerate(triangles):
            p1, p2, p3 = triangle["points"]
            file.write(f"Триъгълник {i+1}: Върхове {p1}, {p2}, {p3}, Периметър: {triangle['perimeter']:.2f}, Площ: {triangle['area']:.2f}, Тип: {triangle['type']}\n")

if __name__ == "__main__":
    main()
