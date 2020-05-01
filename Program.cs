using System;

namespace IT483
{
    public class Lab04
    {

        public static void Main(String[] args)
        {
            int a = 1, b = 3, c = 5;

            double x = 2.2, y = 4.4, z = 6.6, ans;

            ans = average(a, b);

            Console.WriteLine("\naverage(a, b) = " + ans);


            ans = average(a, b, c);

            Console.WriteLine("\naverage(a, b, c) = " + ans);


            ans = average(x, y);

            Console.WriteLine("\naverage(x, y) = " + ans);


            ans = average(x, y, z);

            Console.WriteLine("\naverage(x, y, z) = " + ans);


            ans = average(average(a, b), c);

            Console.WriteLine("\naverage(a, b, c) = " + ans);


            ans = average(1, 2.0, 3);

            Console.WriteLine("\naverage(1, 2.0, 3) = " + ans);

        }


        public static double average(double a, double b)
        {

            return ((a + b) / 2.0);

        }

        public static double average(double a, double b, double c)
        {

            return ((a + b + c) / 3.0);

        }

    }
}

/*Ans 1: No we do not need the int parameter version(s) of avg as we are calling average()
* with the int argument 
* 
* Ans 2: Yes we do need all three parameter because all the averages will be different 
* than the avg of mean of two numbers.For example average(int a, int b, int c)is not similaer to
* average((int a, int b), int c)
* 
* Ans 3: Yes it is legal because average(int a, int b, int c) and average(double a, double b)
* are cast to doubles and the third argument is only accepted in double.
*/
