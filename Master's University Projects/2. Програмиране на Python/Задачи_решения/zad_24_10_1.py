def filter_names_by_letter(names_list, letter):
    # Филтрира имената, които започват с дадената буква (независимо от главни или малки букви)
    return [name for name in names_list if name.lower().startswith(letter.lower())]

names = ["Иван", "Анна", "Илиян", "Мария", "Александър", "Ирина"]

letter = input("Въведете буква: ")

filtered_names = filter_names_by_letter(names, letter)

if filtered_names:
    print("Имена, започващи с", letter + ":")
    for name in filtered_names:
        print(name)
else:
    print("Няма имена, започващи с", letter)