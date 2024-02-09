using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Magnitude
            Vector test8 = new Vector(-4, -1, 0);
            //Adding
            Vector test1 = new Vector(3, 1, 2);
            Vector test2 = new Vector(-6, 0, 3);
            //Subtracing
            Vector test3 = new Vector(4, 2, 8);
            Vector test4 = new Vector(1, 2, 3);
            //Negate
            Vector test5 = new Vector(-8, -6, -8);
            //Scaling
            Vector test6 = new Vector(3, 1, 2);
            float test7 = 3;
            //Normalize
            Vector test9 = new Vector(3, 1, 2);
            //DotProduct
            Vector test10 = new Vector(2, 7, 0); 
            Vector test11 = new Vector(-4, -1, 0);
            //CrossProduct
            Vector test12 = new Vector(3, 6, 4);
            Vector test13 = new Vector(7, 5, 5);
            //AngleBetween
            Vector test14 = new Vector(2, 7, 0);
            Vector test15 = new Vector(-4, -1, 0);
            //AngleBetween
            Vector test16 = new Vector(4, 8, 0);
            Vector test17 = new Vector(10, 3, 0);



            //Addition
            Console.WriteLine("Adding:");
            Console.WriteLine(Vector.Add(test1, test2));
            //Subtraction
            Console.WriteLine("Subtracting:");
            Console.WriteLine(Vector.Subtract(test3, test4));
            //Negate
            Console.WriteLine("Negating:");
            Console.WriteLine(Vector.Negate(test5));
            //Scale
            Console.WriteLine("Scaleing:");
            Console.WriteLine(Vector.Scale(test6, test7));
            //Magnitude
            Console.WriteLine("Magnituding:");
            Console.WriteLine(Vector.GetMagnitude(test8));
            //Normalize
            Console.WriteLine("Normalizing:");
            Console.WriteLine(Vector.Normalize(test9));
            //DotProduct
            Console.WriteLine("DotProducting:");
            Console.WriteLine(Vector.DotProduct(test10, test11));
            //CrossProduct
            Console.WriteLine("CrossProducting:");
            Console.WriteLine(Vector.CrossProduct(test12, test13));
            //AngleBetween
            Console.WriteLine("AngleBetweening:");
            Console.WriteLine(Vector.AngleBetween(test14, test15));
            //ProjectOnto
            //Projecting the first one onto the second one
            Console.WriteLine("ProjectOntoing:");
            Console.WriteLine(Vector.ProjectOnto(test16, test17));

        }
    }
}
