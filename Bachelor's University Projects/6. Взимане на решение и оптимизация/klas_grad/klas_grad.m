n = 2;%input('n =');
eps = 0.001;
dx = [0.1 0.1];
cnt = 0;
%for i = 1 : n
    xmin =[-5 -5] %input(['xmin(' num2str(i) ')= ']);
    xmax = [4 4]%input(['xmax(' num2str(i) ')= ']);
    h = [0.5 0.5]%input(['h(' num2str(i) ')= ']);
    x0 = [0 0]%input(['x0(' num2str(i) ')= ']);
%end
while 1
    Q0 = Fun(x0);
    dQdx = NABLA(n,x0,dx,Q0);
    cnt = cnt + 1;
    S = dQdx.^2;
    S = sum(S);
    S = S^0.5
    
    if S <= eps
        break;
    end
    x0 = x0 + h.*dQdx/S;
end
    for i = 1 : n
        if x0(i) > xmax(i)
            x0(i) = xmax(i);
        end
         if x0(i) < xmin(i)
           x0(i) = xmin(i);
         end
    end
Q0
x0
  