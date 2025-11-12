using System;

namespace ConversaoImplicitaeCasting
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;
            int c;
            int d = 5;
            int e = 2;
            double resultado = (double)d / e;

            Console.WriteLine(resultado);
            Console.WriteLine("\n\n\n\n");

            a = 5.1;
            b = (float)a;
            c = (int)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}