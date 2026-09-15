a = input('a=');
b = input('b=');
dmin = input('dmin=');

d = (b - a)/5;
Q1 = F(a); Q2 = Q1; Qm = Q2;
xm = a; x = a;
L = 1;

while 1
    x = x + d;
    if x > b
        x = b;
        d = -d/5;
        L = 2;
        if L == 1
            Qb = F(b);
            Q1 = Qb;
            Q2 = F(x);
        end
    end
    if x < a
        x = a;
        d = -d/5;
        Q1 = Q2;
    end

    Q2 = F(x);
    if Q2 > Q1
        Q1 = Q2;
        if Q2 > Qm
            Qm = Q2;
            xm = x;
        end
    end
    if (abs(d)<= dmin)
        break;
    end
end

Qm
xm