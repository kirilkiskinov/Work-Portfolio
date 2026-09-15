function dQdx = NABLA(n,x0,dx,Q0)
x=x0;
%S=0;
for i = 1 : n
    x(i) = x(i) + dx(i);
    Q1 = Fun(x);
    dQdx(i) = (Q1 - Q0)/dx(i);
    x(i) = x(i) - dx(i);
    %S=S+dQdx(i)^2;
end
return
    