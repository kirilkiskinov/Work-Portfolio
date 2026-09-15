# Константи за броя часове, минути и секунди
chasove_v_denonoshtie = 24
minuti_v_chas = 60
sekundi_vminuta = 60

# Изчисляване на секундите в денонощие
sekundi_v_denonoshtie = chasove_v_denonoshtie * minuti_v_chas * sekundi_vminuta

# Извеждане на резултата с поясняващ текст
print(f"Броят на секундите в едно денонощие е: {sekundi_v_denonoshtie}, защото {chasove_v_denonoshtie} * {minuti_v_chas} * {sekundi_vminuta} = {sekundi_v_denonoshtie}")
