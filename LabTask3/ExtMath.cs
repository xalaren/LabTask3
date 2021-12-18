using System;
using System.Collections.Generic;

namespace LabTask3
{
    public class ExtMath
    {
        public static double[] BiquadrateEq(double a, double b, double c)
        {
            double[] array = SquareEq(a, b, c);

            if (array == null)
            {
                return null;
            }

            if (array.Length == 0)
            {
                return new double[] { };
            }

            List<double> result = new List<double>();
            for (int i = 0; i < array.Length; i++)
            {
                var t = array[i];
                if (t == 0)
                {
                    result.Add(0);
                }
                else
                {
                    if (t > 0)
                    {
                        var x = Math.Sqrt(t);
                        result.Add(x);
                        result.Add(-x);
                    }
                }
            }

            return result.ToArray();
        }
        public static double[] SquareEq(double a, double b, double c)
        {
            if (a != 0)
            {
                double d = (b * b) - (4 * a * c);
                if (d > 0)
                {
                    double r = Math.Sqrt(d);
                    return new double[] { (-b + r) / (2.0 * a), (-b - r) / (2.0 * a) };
                }
                else if (d == 0)
                {
                    return new double[] { -b / (2.0 * a) };
                }
                else
                {
                    return new double[] { };
                }
            }
            else
            {
                if (b != 0)
                {
                    return new double[] { -c / b };
                }
                else if (c == 0)
                {
                    return null;
                }
                else
                {
                    return new double[] { };
                }
            }
        }
    }
}

