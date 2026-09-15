N = input('N= ');
M2 = input('M2= ');
for i = 1 : N
    xmin(i) = input(['xmin(' num2str(i) ')= ']);
    xmax(i) = input(['xmax(' num2str(i) ')= ']);
end
j = 0;
Qm = -1.0E+15;

for i = 1 : N
    a = rand;
    x(i) = xmin(i) + a*(xmax(i) - xmin(i));
end
 Q = Func2(x);
while 1
if Q > Qm
   Qm = Q;
   xm = x;
   j = 0;
else
    j = j+1;
end
if j > M2
    break
end
end
disp(['Qm= ' num2str(Qm)])
disp(['xm= ' num2str(xm)])