using System.Security.Cryptography.X509Certificates;

namespace Demo
{
    internal class Program
    {



        /*example for Question 1

        void PassingByValueExOfQ1(int x)
         {
             x = 5; // Only modifies the copy, not the original variable
         }
      void PassingByRefExOfQ1(ref int x)
               {
                x = 10; 
               }


      */

        static int SumOfDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {

                sum += (n % 10);
                n /= 10;

            }
            return sum;
        }


        static void MinMaxArr(int[] Arr, out int x, out int y)
        {

            int mx = 0, mn = 1000000000;
            for (int i = 0; i < Arr?.Length; i++)
            {
                mn = Math.Min(mn, Arr[i]);
                mx = Math.Max(mx, Arr[i]);
            }

            x = mx; y = mn;



        }
        static bool isPrime(int n)
        {

            if (n <= 1)
                return false;

            for (int i = 2; i * i < n; i++)

            {
                if (n % i == 0)
                {
                    return false;
                }
            }


            return true;
        }
        static int FactorialOfNum(int n)
        {
            int fact = 1;
            while (n > 0)
            {
                fact *= n;
                n--;
            }
            return fact;
        }
        static void SummitionAndSubtraction(int n1, int n2, int n3, int n4, out int sum, out int sub)
        {

            sum = n1 - n2;
            sub = n3 - n4;

        }
        static string ChangeChar(string s, int index, char newChar)
        {
            char[] Arr = s.ToCharArray();
            Arr[index] = newChar;
            s = new string(Arr);
            return s;
        }

        //Q6 examples
        //passing by value
        void ModifyArraybyValue(int[] arr)
        {
            arr[0] = 99; // Modifies the original array

        }

        //passing by Reference
        void ModifyArraybyRef(ref int[] arr)
        {
            arr[0] = 99;
            arr = new int[] { 1, 2, 3 };
        }
        enum WeekDays
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday

        }
        enum Seasons
        {
            spring,
            summer,
            Autumn,
            winter
        }
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void Main(string[] args)
        {

            //   Part 01
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
            
              Passing by Value:
            Description: A copy of the original value is passed to the method. The method works with this copy, not the original variable.
           Effect: Any changes made to the parameter inside the method do not affect the original variable outside the method.
              int num = 5;
              PassingByValueExOfQ1(num);
              Console.WriteLine(num);
           

              Passing by Reference:
               Description: Instead of a copy, a reference to the original variable is passed to the method. 
              The method works directly with the original variable.
               Effect: Any changes made to the parameter inside the method directly affect 
              the original variable outside the method.
            int num = 5;
          PassingByRefExOfQ1(ref num);
           Console.WriteLine(num);
           
            */
            #endregion
            #region 2-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine("Enter A Number");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine(SumOfDigits(number));

            #endregion

            #region 3-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(isPrime(n));
            #endregion

            #region 4- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //  MinMaxArr(ints , out int x, out int y);
            //  Console.WriteLine($"Max is {x} , Min is {y}");

            #endregion

            #region 5-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int factorialNum = int.Parse(Console.ReadLine());
            //Console.WriteLine(FactorialOfNum(factorialNum));

            #endregion

            #region 6-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            /*
               Passing Reference Type by Value:
            Description: When a reference type is passed by value, the reference (or address) to the object is copied to the method, 
            not the actual object.
            Effect: Changes made to the object inside the method will affect the original object, 
            as both the original variable and the method parameter 
            point to the same object.
            int[] numbers = { 10, 20, 30 };
            ModifyArray(numbers);
           Console.WriteLine(string.Join(", ", numbers)); // Output: 99, 20, 30
            ----------------------------
            Passing Reference Type by Reference:
            Description: When a reference type is passed by reference (using the ref keyword), the method receives a reference to the variable itself,
            not just the object it points to.
            Effect: The method can modify the original object and also reassign the reference,
            changing which object the variable points to.

              int[] numbers = { 10, 20, 30 };
              ModifyArray(ref numbers);
              Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3
             */

            #endregion

            #region 7-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int n1 = int .Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());
            //int n4 = int.Parse(Console.ReadLine());
            //SummitionAndSubtraction(n1, n2, n3, n4, out int Summition, out int subtraction);
            //Console.WriteLine($"Summition of N1 and N2 = {Summition} , Subtraction of N3 and N4 {subtraction}  ");

            //string str = Console.ReadLine();
            //int index = int.Parse(Console.ReadLine());
            //char ch = char .Parse(Console.ReadLine());

            //Console.WriteLine(ChangeChar(str, index, ch));
            #endregion

            //  part 02

            #region 1-Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the week:");


            //foreach (WeekDays day in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2-Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 
            //Console.WriteLine("Enter a sesson :");
            //Enum.TryParse(Console.ReadLine(), out Seasons season);
            //Console.Write($"The Range of {season} is between ");

            //switch (season)
            //{
            //    case Seasons.spring:
            //        Console.WriteLine("march to may");
            //        break;
            //    case Seasons.summer:
            //        Console.WriteLine(" june to august ");
            //            break;
            //    case Seasons.winter:
            //        Console.WriteLine(" December to February");
            //            break;


            //    case Seasons.Autumn:
            //        Console.WriteLine("September to November ");
            //            break;

            //    default:
            //        break;

            //}

            #endregion
            #region 3-No Question

            #endregion
            #region 

            #endregion
            #region 5- Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Console.WriteLine("Enter A Color : ");

            //if (Enum.TryParse(Console.ReadLine(), true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a Primary Color");
            //}
            //else
            //    Console.WriteLine("Not a Primary Color");

            #endregion
            //mkkjjkhhvgvgvggv
        }
    }
}


