import cmath

def quadratic_roots(a, b, c):
    D = b**2 - 4 * a * c

    if D > 0:
        root1 = (-b + cmath.sqrt(D)) / (2 * a)
        root2 = (-b - cmath.sqrt(D)) / (2 * a)
        return root1.real, root2.real #връща ни реални стойности Пример: а = 1 , b = 3 , c = -4
    elif D == 0:
        root = -b / (2 * a) #Пример: а = 1 , b = 4 , c = 4
        return root,
    else:
        # Два комплексни корена. Използваме модула cmath, защото той може да обработва и комплексни числа. 
        # Когато дискриминантата 𝐷 е отрицателна, cmath.sqrt(D) ще върне комплексна стойност. 
        # Пример: а = 1 , b = 2 , c = 5
        root1 = (-b + cmath.sqrt(D)) / (2 * a)
        root2 = (-b - cmath.sqrt(D)) / (2 * a)
        return root1, root2

a = float(input("Въведете a: "))
b = float(input("Въведете b: "))
c = float(input("Въведете c: "))

roots = quadratic_roots(a, b, c)
print("Корените на уравнението са:", roots)
