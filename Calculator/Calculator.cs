using System;

namespace Calculator
{
    public class Calculator
    {
        public static Double Add(double x, double y)
        {
            return x + y;
        }

        public static Double Sub(double x, double y)
        {
            return x - y;
        }

        public static Double Multi(double x, double y)
        {
            return x * y;
        }
        public static double Add(double[] doubles)
        {
            double result = 0;
            for (Int32 i = 0; i < doubles.Length; i++)
                result += doubles[i];
            return result;
        }
        public static double Sub(double[] doubles)
        {
            double result = 0;
            for (Int32 i = 0; i < doubles.Length; i++)
                result -= doubles[i];
            return result;
        }

        public static string Div(double x, double y)
        {
            double result = x / y;
            string result1 = result.ToString();
            string error = "You cannot divide by Zero";

            if (y == 0)
            {
                return error;

            }
            else
                return result1;
        }
    }
}