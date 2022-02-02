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
                firstloop += 3 / 2 * (Math.Sin(Math.Pow((a + (2 * i - 1) * h), 3)));
            }
            for (int i = 1; i < n/2-1; i++)
            {
                secondloop += 3 / 2 * (Math.Sin(Math.Pow((a + 2 * i * h), 3)));
            }
            answer=(h*0.333333)*(3 / 2 * (Math.Sin(Math.Pow(a, 3))) + 3 / 2 * (Math.Sin(Math.Pow(b, 3))) + 4*firstloop+2*secondloop);
            return answer;

        }
        
    }
}
    