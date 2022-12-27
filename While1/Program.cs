Console.WriteLine("n="); byte n = byte.Parse(Console.ReadLine());
double a=0, b=0, c=0; byte m=1;
while (m<=n){
    a += (Math.Pow((-1), m)) / (2 * m + 1);
    b += 1 + (1) / (Math.Pow(m, 2));
    int factor=1;
    for(byte i = 0; i<m; i++)
    {
       factor*=m - i;
    }
    c += factor;
    m++;
    
}
Console.WriteLine("a:"+a);
Console.WriteLine("b:"+b);
Console.WriteLine("c:"+c);

