using System;

// Much more than the Quadratic Formula
namespace QuadFormula
{
    internal class Quad
    {
        public float a, b, c;
        public double D;

        public double Descrim()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }

        public void Concavity()
        {
            bool up_down = a < 0;
            Console.WriteLine(up_down ? "Concave Down" : "Concave Up");
        }

        public void Apex()
        {
            double x_apex = -1 * b / (2 * a);
            double y_apex = a * Math.Pow(x_apex, 2) + b * x_apex + c;
            if (a < 0)
            {
                Console.WriteLine($"Function attains max at x = {x_apex} with value {y_apex}");
            }
            else
            {
                Console.WriteLine($"Function attains min at x = {x_apex} with value {y_apex}");
            }
        }

        public float Slope_at(float x)
        {
            return 2 * a * x + b;
        }

        public float Eval(float point)
        {
            return a * (float)Math.Pow(point, 2) + b * point + c;
        }

        public void Tangent_at(float point)
        {
            float x0 = point;
            float y0 = Eval(x0);
            float slope = Slope_at(x0);

            Console.WriteLine($"Tangent to {a}x^2 + {b}x + {c} at x = {x0} is y = {y0} + {slope}(x-{x0})");
        }

        public float Area_under(float x1, float x2)
        {
            float upp = (float) (a / 3 * Math.Pow(x2, 3) + b / 2 * Math.Pow(x2, 2) + c * x2);
            float low = (float)(a / 3 * Math.Pow(x1, 3) + b / 2 * Math.Pow(x1, 2) + c * x1);

            float area = upp - low;

            return area;
        }

        public void Roots()
        {
            if (D == 0)
            {
                double root = -1 * b / (2 * a);
                Console.WriteLine($"Root is {root}");
            }
            else if (D > 0)
            {
                double root1 = Math.Round(((-1 * b - Math.Pow(D, 0.5)) / (2 * a)), 6);
                double root2 = Math.Round(((-1 * b + Math.Pow(D, 0.5)) / (2 * a)), 6);

                Console.WriteLine($"Roots are {root1} and {root2}");
            }
            else
            {
                double real_part = (-1 * b) / (2 * a);
                double img_part = Math.Round(Math.Pow(-D, 0.5) / (2 * a), 6);
                Console.WriteLine($"Roots are {real_part} - {img_part}i and {real_part} + {img_part}i");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Quad f = new Quad
            {
                a = 1,
                b = 0,
                c = 0
            };

            Console.WriteLine(f.Area_under(-6,6));
            */
        }
    }
}