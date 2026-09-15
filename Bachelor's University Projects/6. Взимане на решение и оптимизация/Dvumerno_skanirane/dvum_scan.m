x1min = input('x1min=');
x2min = input('x2min=');
x1max = input('x1max=');
x2max = input('x2max=');
d1 = input('d1=');
d2 = input('d2=');

Qm = Fun2(x1min,x2min);
xm1 = x1min;
xm2 = x2min;

for x1=x1min:d1:x1max
    for x2=x2min:d2:x2max
        Q1 = Fun2(x1,x2);
        if Q1 > Qm
            Qm = Q1;
            xm1 = x1;
            xm2 = x2;
        end
    end
end

Qm
xm1
xm2