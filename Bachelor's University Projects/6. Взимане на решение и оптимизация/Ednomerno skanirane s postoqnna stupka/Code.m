a = input('a = ');
b = input('b = ');
delta = input('delta = ');

xm = a;
Qm = F(a);
x = a;

for x = a:delta:b
    Q = F(x);
    if Q > Qm
        xm = x;
        Qm = Q;
    end
end

Qm
xm