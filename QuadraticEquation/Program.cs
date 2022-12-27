Console.WriteLine("a:") ;double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b:"); double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("c:"); double c = Convert.ToDouble(Console.ReadLine());

double d,x1,x2; 

            d = b * b - 4 * a * c;
 if (d > 0)
{   
    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("x1="+x1);
    Console.WriteLine("x2=" + x2);
    
                
 }
  
       if (d == 0)
       {
       x1 = x2 = (-b) / (2 * a);
    Console.WriteLine("x=" + x1);
    
       }

       if (d<0)
    {
           x1 = x2 = 0;
    Console.WriteLine("Erorr");
    
          }
return 0;
    
