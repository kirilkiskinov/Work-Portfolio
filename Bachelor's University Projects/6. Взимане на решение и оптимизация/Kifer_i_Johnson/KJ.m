clearvars
a = input('a=');
b = input('b=');
dmin = input('dmin=');

M = (b-a)/dmin;
F(1) = 1; F(2) = 1; i = 2;

while 1
    i = i+1;
    F(i) = F(i - 1) + F(i-2);
    if F(i) >= M
        break
    end
end
 n = i;
 dm = (b-a)/F(n);
 xm = a;
 Qm = func(a);
 Q = Qm;
 
 while 1
     n = n-2;
     if n<1
         break
     end
     x = a+dm*F(n);
     Q = func(x);
     if Q > Qm
         Qm = Q
         xm = x;
         break
     end
 end
 
 while 1 
     n = n - 1;
     if n<1
         break
     end

 
 x = xm + dm*F(n);
 Q = func(x);
 if Q>Qm
     Qm = Q;
     xm = x;
 else
     dm = -dm;
    end
 end
 
 disp(['Qm =' num2str(Qm)])
 disp(['xm =' num2str(xm)])