N = input('N=');
M1 = input('M1=');
for i = 1:N
    xmin(i) = input(['xmin(' num2str(i) ')=']);
    xmax(i) = input(['xmax(' num2str(i) ')=']);
end

for L = 1:M1
    for i = 1:N
        a = rand;
        x(i) = xmin(i) + a*(xmax(i) - xmin(i));
    end
    
    Q = Func2(x);
    
    if L == 1
        Qm = Q;
        xm = x;
    end
    
    if Q > Qm
        Qm = Q;
        xm = x;
    end
end

Qm
xm
        