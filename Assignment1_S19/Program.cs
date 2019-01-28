using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // The assignment is difficult in comparision to the examples solved in the class. More exampples can be solved in the class to get a better understanding. 

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                {
                    int num, i, j;

                    for (num = x; num <= y; num++)
                    {
                        j = 0;

                        for (i = 2; i <= num / 2; i++)
                        {
                            if (num % i == 0)
                            {
                                j++;
                                break;
                            }
                        }

                        if (j == 0 && num != 1)
                            Console.WriteLine("{0}", num);
                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        // Using "num" for first For loop and "i" for the second for loop whereas "j" is the flag.
        //The method helps to get all the prime numbers between 5 and 15. If the number is divided by 2 then it is not prime number and that helps to identify the true prime numbers.
        // If the range ends at 1 there are no prime numbers but if it extendes means there are prime numbers present.

        public static double getSeriesResult(int n)
        {
            try
            {
                double a = 0.0;
                for (int j = 1; j <= n; j++)
                {

                    double a1 = fact(j) / (j + 1);
                    if (j % 2 == 0)
                    {
                        a = a - a1;
                    }
                    else
                    {
                        a = a + a1;
                    }

                }
                return Math.Round(a,3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
                return 0;
            }
        }

        static double fact(int n)
        {
            int b = 1;
            for (int j = 1; j <= n; j++)
            {
                b = b * j;
            }
            return b;
        }

        //All the variable are stored in a1 such as 1/2,2!/3,3!/4..)
        //Math.Round helps to get 3 decimal places.
        //for (int j = 1; j <= n; j++) helps to get factorial.




        public static long decimalToBinary(long n)
        {
            try
            {
                long remainder;
                long result1;
                string result = string.Empty;
                while (n > 0)

                {
                    remainder = n % 2;
                    n /= 2;
                    result = remainder.ToString() + result;
                }

                result1 = Convert.ToInt64(result);
                return result1;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            return 0;
        }

        //This method helpls to divide a number by 2 till the quotient is 0. That helps to identify the remainder and turn them into binary numbers.
        // The result is converted to Int64 as it can be big.
        // While loop is used to divide the number till 0.
        // The result is converted to string to get a final value.


        public static long binaryToDecimal(long n)
        {
            int c, d;
            int a = 1, sol = 0, b = 1;
            try

            {
                int n1 = Convert.ToInt32(n);
                for (c = n1; c > 0; c = c / 10)
                {
                    d = c % 10;
                    if (b == 1)
                        a *= 1;
                    else
                        a *= 2;

                    sol = sol + (d * a);
                    b++;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return sol;
        }
         // The number is separated into individial digits which can be later multiplied by 2 with the respective power of digit.


        public static void printTriangle(int n)
        {
            try
            {

                for (int a = 1; a <= n; a++)
                {
                    int b = 0;

                    for (int space = 1; space <= n - a; space++)
                    {
                        Console.Write(" ");

                    }

                    while (b < (2 * a - 1))
                    {
                        Console.Write("*");
                        b++;
                    }

                    Console.WriteLine("");
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        // The total number is 


        public static void computeFrequency(int[] a)
        {
            try
            {
                int len = a.Length;
                int b;
                int[] frq = new int[len];
                for (int c = 0; c < len; c++)
                {
                    frq[c] = -1;
                }

                for (int c = 0; c < len; c++)
                {
                    b = 1;
                    for (int j = c + 1; j < len; j++)
                    {
                        if (a[c] == a[j])
                        {
                            b++;
                            frq[j] = 0;
                        }
                    }
                    if (frq[c] != 0)
                    {
                        frq[c] = b;
                    }
                }
                Console.Write("\nThe frequency of all elements of the array : \n");

                Console.WriteLine("Number \t Frequency");
                for (int c = 0; c < len; c++)
                {
                    if (frq[c] != 0)
                    {
                        Console.WriteLine(a[c] + "\t" + frq[c]);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }
}


