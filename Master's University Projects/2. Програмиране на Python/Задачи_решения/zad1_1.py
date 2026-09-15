data_input = input("Въведете име, фамилия, факултетен номер, курс и специалност, разделени с интервал: ").split()
variables = ["Име", "Фамилия", "Факултетен номер", "Курс", "Специалност"]
#print(join([f"{variables[i]}: {data_input[i]}" for i in range(5)])) данните да се показват на няколко реда

print(", ".join([f"{variables[i]}: {data_input[i]}" for i in range(5)])) #данните да се показват на 1 ред