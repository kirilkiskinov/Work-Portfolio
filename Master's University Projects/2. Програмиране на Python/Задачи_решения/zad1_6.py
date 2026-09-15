# Въвеждане на времето в секунди от потребителя
vreme_v_sekundi = int(input("Въведете времето в секунди: "))

# Преобразуване в часове, минути и секунди
chasove = vreme_v_sekundi // 3600
ostavashti_sekundi = vreme_v_sekundi % 3600
minuti = ostavashti_sekundi // 60
sekundi = ostavashti_sekundi % 60

# Извеждане на резултата
print(f"{vreme_v_sekundi} секунди са равни на {chasove} час(а), {minuti} минута(и) и {sekundi} секунда(и).")
