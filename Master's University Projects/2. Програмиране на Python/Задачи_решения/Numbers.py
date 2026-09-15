def get_sum(num):
    """Изчислява сумата на числата в интервала от 1 до num."""
    return sum(range(1, num + 1))


def get_avg(num):
    """Изчислява средната стойност на числата в интервала от 1 до num."""
    return get_sum(num) / num if num > 0 else 0


def is_even(num):
    """Проверява дали num е четно число."""
    return num % 2 == 0


def get_even_avg(num):
    """Изчислява средната стойност на четните числа в интервала от 1 до num."""
    even_numbers = [i for i in range(1, num + 1) if i % 2 == 0]
    return sum(even_numbers) / len(even_numbers) if even_numbers else 0


def print_text_number(num):
    """Отпечатва българското наименование на всяка една от цифрите на зададеното число."""
    digit_to_text = {
        0: "нула", 1: "едно", 2: "две", 3: "три", 4: "четири",
        5: "пет", 6: "шест", 7: "седем", 8: "осем", 9: "девет"
    }
    digits = [int(d) for d in str(num)]
    print(" ".join(digit_to_text[d] for d in digits))


def print_text_from_number(num):
    """Отпечатва числото словом на български."""
    units = ["", "едно", "две", "три", "четири", "пет", "шест", "седем", "осем", "девет"]
    teens = ["десет", "единадесет", "дванадесет", "тринадесет", "четиринадесет", "петнадесет",
             "шестнадесет", "седемнадесет", "осемнадесет", "деветнадесет"]
    tens = ["", "", "двадесет", "тридесет", "четиридесет", "петдесет", "шестдесет",
            "седемдесет", "осемдесет", "деветдесет"]
    hundreds = ["", "сто", "двеста", "триста", "четиристотин", "петстотин", "шестстотин",
                "седемстотин", "осемстотин", "деветстотин"]

    if num == 0:
        return "нула"

    result = []
    
    # За стотиците
    if num // 100 > 0:
        result.append(hundreds[num // 100])
        num %= 100

    # За десетиците и единиците
    if 10 <= num < 20:
        if result:  # Ако има стотици, добавяме "и"
            result.append("и " + teens[num - 10])
        else:
            result.append(teens[num - 10])
    else:
        if num // 10 > 0:
            result.append(tens[num // 10])
        if num % 10 > 0:
            if result:  # Ако има десетици или стотици, добавяме "и"
                result.append("и " + units[num % 10])
            else:
                result.append(units[num % 10])

    return " ".join(result)


def is_palindrome(num):
    """Проверява дали num е палиндром."""
    num_str = str(num)
    return num_str == num_str[::-1]
