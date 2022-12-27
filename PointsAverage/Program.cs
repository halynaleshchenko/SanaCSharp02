Console.WriteLine("1:"); double a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("2:"); double a2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("3:"); double a3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("4:"); double a4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("5:"); double a5 = Convert.ToDouble(Console.ReadLine());
if( a1 > 5 || a2 >5 || a3 > 5 || a4 > 5 || a5 > 5)
{
    Console.WriteLine("Ви ввели неправильний бал, > 5");
}
else if (a1 < 0 || a2 < 0 || a3 < 0 || a4 < 0 || a5 < 0)
{
    Console.WriteLine("Ви ввели неправильний бал, < 0");
}

else 
{
    double a;
    a = (a1 + a2 + a3 + a4 + a5) / 5;
    if (a > 3)
    {
        Console.WriteLine("Бал:" + a);
        Console.WriteLine("Допущений до екзамену");
    }
    else if (a < 4)
    {
        Console.WriteLine("Бал:" + a);
        Console.WriteLine("Не допущений до екзамену");
    }
}
return 0;
