import numpy as np

# Функция за изчисляване на коефициента на дифузия Dg
def calculate_Dg(t, p, Va, Vb, Ma, Mb):
    Dg = (0.00155 * t**(3/2)) / (p * (Va**(1/3) + Vb**(1/3))**(1/2)) * np.sqrt(1/Ma + 1/Mb)
    return Dg

# Входни данни
tn = float(input("Въведете начална стойност на температурата t (в К): "))
tk = float(input("Въведете крайна стойност на температурата t (в К): "))
dt = float(input("Въведете стъпка на нарастване на температурата dt: "))

pn = float(input("Въведете начална стойност на налягането p (в Па): "))
pk = float(input("Въведете крайна стойност на налягането p (в Па): "))
dp = float(input("Въведете стъпка на нарастване на налягането dp: "))

# Входни стойности за молни маси и обеми (примерни стойности)
Ma = float(input("Въведете молна маса Ma (в г/мол): "))
Mb = float(input("Въведете молна маса Mb (в г/мол): "))
Va = float(input("Въведете обем Va (в м³): "))
Vb = float(input("Въведете обем Vb (в м³): "))

# Списъци за съхраняване на стойности на Dg
Dg_results = []

# Цикли за изчисляване на Dg за различни стойности на t и p
# numpy.arange() позволява лесно генериране на числови интервали със зададени стъпки

#t = np.arange(tn, tk + dt, dt)
#p = np.arange(pn, pk + dp, dp)
#print(t,p)
#dg = calculate_Dg(t, p, Va, Vb, Ma, Mb)

for t in np.arange(tn, tk + dt, dt): 
    for p in np.arange(pn, pk + dp, dp):
        Dg = calculate_Dg(t, p, Va, Vb, Ma, Mb)
        Dg_results.append((t, p, Dg))
        print(f"t = {t:.2f} K, p = {p:.2f} Pa => Dg = {Dg:.6f} m²/s")

