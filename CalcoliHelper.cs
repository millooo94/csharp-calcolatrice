using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CalcoliHelper
{
    public static int IntSum(int x, int y) => x + y;

    public static double DoubleSum(double x, double y) => x + y;

    public static int IntDiff(int x, int y) => x - y;

    public static double DoubleDiff(double x, double y) => x - y;

    public static int IntMult(int x, int y) => x * y;

    public static double DoubleMult(double x, double y) => x * y;

    public static int IntAbs(int x)
    {
        if (x < 0) return x * -1;

        else return x;
    }

    public static double DoubleAbs(double x)
    {
        if (x < 0) return x * -1;

        else return x;
    }

    public static int IntMin(int x, int y)
    {
        if (x < y) return x;

        else return y;
    }

    public static double DoubleMin(double x, double y)
    {

        if (x < y) return x;

        else return y;

    }

    public static int IntMax(int x, int y)
    {
        if (x > y) return x;

        else return y;
    }

    public static double DoubleMax(double x, double y)
    {
        if (x > y) return x;

        else return y;
    }

    public static int IntPow(int @base, int exp)
    {
        if (@base == 0 && exp == 0) return 1;
        else if (exp == 0) return 1;
        else if (exp == 1) return @base;
        else
        {
            var result = @base;
            for (int i = 1; i < exp; i++)
            {
                result *= @base;
            }
            return result;
        }
    }
