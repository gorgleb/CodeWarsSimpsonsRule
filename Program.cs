using System;
using System.Linq;

namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 72 ;
            Console.WriteLine(SimpsonIntegration.Simpson(n));

        }


    }
    public class SimpsonIntegration
    {
       
        public static double Simpson(int n)
        {
            double answer = 0;
            double x = 0;
            double h = 0;
            double a = 0;
            double b = Math.PI;
            double firstloop = 0;
            double secondloop = 0;
            h = (b - a) / (3 * n);
            for (int i = 1; i < n/2; i++)
            {
                firstloop += func(a + (2 * i - 1) * h);
            }
            for (int i = 1; i < n/2-1; i++)
            {
                secondloop += func(a + 2 * i * h);
            }
            answer=(h*(1/3))*(func(a)+func(b)+4*firstloop+2*secondloop);
            return answer;

        }
        public static double func(double x)
        {
            x = 3 / 2 * (Math.Sin(Math.Pow(x, 3)));
            return x;
        }
    }
}
    