import Numbers

def main():
    print("=== Тест на функциите от модула Numbers ===")
    
    num = 123

    print(f"1. Сумата на числата от 1 до {num} е: {Numbers.get_sum(num)}")
    print(f"2. Средната стойност на числата от 1 до {num} е: {Numbers.get_avg(num):.2f}")
    print(f"3. Числото {num} е четно? {'Да' if Numbers.is_even(num) else 'Не'}")
    print(f"4. Средната стойност на четните числа от 1 до {num} е: {Numbers.get_even_avg(num):.2f}")

    print("5. Българско наименование на цифрите в числото:")
    Numbers.print_text_number(num)

    print(f"6. Числото словом e: {Numbers.print_text_from_number(num)}")

    print(f"7. Числото {num} е палиндром? {'Да' if Numbers.is_palindrome(num) else 'Не'}")

if __name__ == "__main__":
    main()
