namespace _3
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double precision = 1e-6;

            Console.WriteLine("Series 1 Sum: " + CalculateSeriesSum(Series1Term, precision));
            Console.WriteLine("Series 2 Sum: " + CalculateSeriesSum(Series2Term, precision));
            Console.WriteLine("Series 3 Sum: " + CalculateSeriesSum(Series3Term, precision));
        }

        public delegate double SeriesTerm(int n);

        public static double CalculateSeriesSum(SeriesTerm term, double precision)
        {
            double sum = 0;
            double currentTermValue;
            int n = 0;

            do
            {
                currentTermValue = term(n);
                sum += currentTermValue;
                n++;
            } while (Math.Abs(currentTermValue) >= precision);

            return sum;
        }

        public static double Series1Term(int n)
        {
            return 1.0 / Math.Pow(2, n);
        }

        public static double Series2Term(int n)
        {
            return 1.0 / Factorial(n+1);
        }

        public static double Series3Term(int n)
        {
            return Math.Pow(-1, n) / Math.Pow(2, n);
        }

        public static double Factorial(int number)
        {
            long factorial = 1;
            while (number != 1)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
    }

}