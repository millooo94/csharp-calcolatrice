using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CalcoliHelper
{
    public static int Sum(int x, int y) => x + y;

    public static double Sum(double x, double y) => x + y;

    public static int Diff(int x, int y) => x - y;

    public static double Diff(double x, double y) => x - y;

    public static int Mult(int x, int y) => x * y;

    public static double Mult(double x, double y) => x * y;

    public static int Abs(int x)
    {
        if (x < 0) return x * -1;

        else return x;
    }

    public static double Abs(double x)
    {
        if (x < 0) return x * -1;

        else return x;
    }

    public static int Min(int x, int y)
    {
        if (x < y) return x;

        else return y;
    }

    public static double Min(double x, double y)
    {

        if (x < y) return x;

        else return y;

    }

    public static int Max(int x, int y)
    {
        if (x > y) return x;

        else return y;
    }

    public static double Max(double x, double y)
    {
        if (x > y) return x;

        else return y;
    }

    public static double? Pow(double @base, double exp)
    {
        if (exp == 0) return 1;
        if (exp < 0 && @base == 0) return null;
        if (@base == 0) return 0;
        if (@base == 1) return 1;

        var result = @base;


        for (int i = 1; i < exp; i++)
        {
            result *= @base;
        }

        return exp > 0 ? result : 1 / result;
    }
}

