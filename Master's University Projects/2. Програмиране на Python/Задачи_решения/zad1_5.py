#centi = float(input("Въведете сантиметри: "))     #Вариант 1

#m = centi // 100
#cm = centi % 100

#print(f'{centi} cm са равни на {m} m и {cm} cm')

# Вариант 2

import sys
centi = sys.argv[1:]
for cm in centi:
    cm = float(cm)
    m = int(cm // 100)
    ostcm = int(cm % 100) 
    print(f'{cm} cm са равни на {m} m и {ostcm} cm')