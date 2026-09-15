n=2;%n = input('n =');
xmin = [-5 -5]%for i = 1 : n
xmax = [10 10]%    xmin(i) = input(['xmin(' num2str(i) ')= ']);
 h= [0.1 0.1]%   xmax(i) = input(['xmax(' num2str(i) ')= ']);
  %  h(i) = input(['h(' num2str(i) ')= ']);
  %  end
for i = 1 : n
    a = rand;
    x0(i) = xmin(i) + a*(xmax(i)-xmin(i));
end
    if n <= 3
        M = 2^n + 4;
    else
        M = 2*n + 4;
    end
    Q0 = Fun(x0);
    L = 0;
    while 1
        S = 0;
        for i = 1 : n
            alfa(i) = rand;
            beta(i) = (alfa(i) - 0.5)*2;
            S = S + beta(i)^2;
        end
        S = S^0.5;
        ksi = beta/S;
        while 1
            for i = 1 : n
            x(i) = x0(i) + h(i)*ksi(i);
            if x(i)<xmin(i)
                x(i) = xmin(i);
            end
            if x(i)>xmax(i)
                x(i) = xmax(i);
            end
            end
            Q1 = Fun(x);
            if Q1 > Q0
                L=0;
                x0 = x;
                Q0 = Q1;
            else
                L = L+1;
                break;
            end
        end
        if L > M
            break;
        end
    end
    Q0
    x0