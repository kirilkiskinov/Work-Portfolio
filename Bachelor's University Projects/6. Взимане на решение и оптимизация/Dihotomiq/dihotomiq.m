x(1) = input('a=');
x(5) = input('b=');
dmin = input('dmin=');

q(1) = F(x(1));
q(5) = F(x(5));
delta = (x(5)-x(1))/4;

while 1
    x(3) = (x(1)+x(5))/2;
    q(3) = F(x(3));
    x(2) = x(1) + delta;
    q(2) = F(x(2));
    x(4) = x(5) - delta;
    q(4) = F(x(4));
    qmax = q(1);
    xmax = x(1);
    k = 1;
    for i = 2:5
        if q(i)>qmax
            qmax = q(i);
            xmax = x(i);
            k = i;
        end
    end
    if (k == 5)
        x(1) = x(4);
        q(1) = q(4);
    end
    if (k == 1)
        x(5) = x(2);
        q(5) = q(2);
    end
    if (k>1) && (k<5)
        x(1) = x(k-1);
        q(1) = q(k-1);
        x(5) = x(k+1);
        q(5) = q(k+1);
    end
    delta = (x(5)-x(1))/4;
    if delta<dmin
        break
    end 
end
qmax
xmax
