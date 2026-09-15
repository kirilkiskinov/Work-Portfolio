n = input('n=');

%for i = 1:n
    %x0(i) = input(['x0(' num2str(i) ')=']);
    %xmin(i) = input(['xmin(' num2str(i) ')=']);
    %xmax(i) = input(['xmax(' num2str(i) ')=']);
    %h0(i) = input(['h0(' num2str(i) ')=']);
%end

x0 = [1 1];
xmin = [-5 -5];
xmax = [10 10];
h0 = [0.5 0.5];

for i = 1:n
    a = rand; % alfa [0 1] %
    x0(i) = xmin(i) + a * (xmax(i) - xmin(i));
end

if n <= 3
    M = 2^n + 4;
else
    M = 2*n + 4;
end

Q0 = Fun(x0);
L = 0;

while 1
    for i = 1:n
        a = rand;
        b(i) = (a - 0.5) * 2;
    end
    
    S = b.^2;
    S = sum(S);
    S = S^0.5;
    ksi = b./S;
    
    for i = 1:n
        x(i) = x0(i) + h0(i)*ksi(i);
        if x(i) < xmin(i)
            x(i) = xmin(i);
        end
        if x(i)> xmax(i)
            x(i) = xmax(i);
        end
    end
    
    Q1 = Fun(x);
    
    if Q1 > Q0
        Q0 = Q1;
        x0 = x;
        L = 0;
    else
        for i = 1:n
        x(i) = x0(i) - h0(i)*ksi(i);
        if x(i) < xmin(i)
            x(i) = xmin(i);
        end
        if x(i)> xmax(i)
            x(i) = xmax(i);
        end
        end
        
        Q1 = Fun(x);
        
        if Q1 > Q0
            Q0 = Q1;
            x0 = x;
            L = 0;
        else
            L = L + 1;
            if L > M
             break;
            end        
    end
  end
end

Q0
x0
        
    
    
    

    