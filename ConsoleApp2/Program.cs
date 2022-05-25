using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic operation On OOPS");
            operaion op = new operaion();
            double rRaiseTo = op.RaiseTo(20, 4);
            Console.WriteLine($"RaiseTo of given nember are { rRaiseTo}");
            int rfactorial = op.factorial(7);
            Console.WriteLine($"Factorial Of given No is { rfactorial}");
            Console.WriteLine();

            double return_value = op.area("circle", new double[] { 10, 5, 5 });
            double return_value1 = op.area("rectangle", new double[] { 10, 5, 5 });
            double return_value2 = op.area("elipse", new double[] { 10, 5, 5 });
            double return_value3 = op.area("triangle", new double[] { 10, 5, 5 });
            double return_value4 = op.area("square", new double[] { 10, 5, 5 });

            Console.WriteLine($"Area of circle = {return_value}");
            Console.WriteLine($"Area of rectangle = {return_value1}");
            Console.WriteLine($"Area of elipse = {return_value2}");
            Console.WriteLine($"Area of triangle = {return_value3}");
            Console.WriteLine($"Area of square = {return_value4}");

            double[] trignotype = op.trignotype("cos", new int[] { 90, 60, 45, 0, 30 });
            double[] trignotype1 = op.trignotype("sin", new int[] { 90, 60, 45, 0, 30 });
            double[] trignotype2 = op.trignotype("tan", new int[] { 90, 60, 45, 0, 30 });

            foreach (var item in trignotype)
            {
                Console.WriteLine((double)item);
            }

            foreach (var item in trignotype)
            {
                Console.WriteLine((double)item);
            }

            foreach (var item in trignotype)
            {
                Console.WriteLine((double)item);
            }


        }
    }
    public class operaion
    {
        private bool validate(int x, int y)
        {
            if (x == 0 || y == 0)
                return false
;
            else
                return true;

        }
        public double RaiseTo(int x, int y)
        {
            if (!validate(x, y)) return 0;
            double z = Math.Pow(x, y);
            return z;
        }

        public int factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        private bool valid(double x, double y)
        {
            if (x == 0 || y == 0)
                return true;
            else
                return false;
        }
        public double area(string shape, double[] dimensions)
        {
            if (shape == "circle")
            {
                return 3.14 * dimensions[0] * dimensions[0];
            }
            else if (shape == "rectangle")
            {
                return dimensions[1] * dimensions[2];
            }
            else if (shape == "elipse")
            {
                return 3.14 * dimensions[1] * dimensions[2];
            }
            else if (shape == "triangle")
            {
                return 0.5 * dimensions[1] * dimensions[2];
            }
            else
            {
                return dimensions[1] = dimensions[1];
            }
        }
        public double[] trignotype(string x, int[] trignotype)
        {
            if (x == "cos")
            {
                return new double[] { Math.Cos(0), Math.Cos(30), Math.Cos(45), Math.Cos(60), Math.Cos(90) };
            }
            else if (x == "sin")
            {
                return new double[] { Math.Sin(0), Math.Sin(30), Math.Sin(45), Math.Sin(60), Math.Sin(90) };
            }
            else if (x == "tan")
            {
                return new double[] { Math.Tan(0), Math.Tan(30), Math.Tan(45), Math.Tan(60), Math.Tan(90) };
            }
            else
            {
                return new double[] { 0, 0, 0, 0, 0, };
            }
        }
    }
}