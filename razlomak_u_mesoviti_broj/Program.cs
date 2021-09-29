using System;

namespace razlomak_u_mesoviti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = a / b;
            d = a%b;
            
            Console.Write("{0} {1} {2}",d,c,b);

        }
    }
}
