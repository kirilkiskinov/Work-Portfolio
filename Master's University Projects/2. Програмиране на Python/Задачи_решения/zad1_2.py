import sys
gallons = sys.argv[1:]
for g in gallons:
    liters = float(g) * 3.7854
    print(f'{g} галона се равняват на {liters:.3f} литра')