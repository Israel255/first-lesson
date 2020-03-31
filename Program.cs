using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2903
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("TARGIL 1");
               Console.WriteLine("please enter a number:");
               double a1 = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("please enter another number");
               double b1 = Convert.ToDouble(Console.ReadLine());
               if (a1 % b1 == 0)
               {
                   Console.WriteLine("The solution is:" + a1 / b1);
                   Console.WriteLine("The numbers are divided");
               }
               else
               {
                   Console.WriteLine("The solution is:" + a1 / b1);
                   Console.WriteLine("Not divided");
               }
               Console.WriteLine("---------------------------------------------------------------");
               Console.WriteLine("TARGIL 2");
               Console.WriteLine("please enter a number");
               int num = Convert.ToInt32(Console.ReadLine());
               int mult = 1;
               while (num > 0)
               {
                   mult = mult * num;
                   num--;
               }
               Console.WriteLine(mult);
               Console.WriteLine("---------------------------------------------------------------");
              Console.WriteLine("TARGIL 3");
              Console.WriteLine("please enter a number:");
              int a2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("please enter another number:");
              int b2 = Convert.ToInt32(Console.ReadLine());
              int sum = 0;
              while (a2 > 0 && b2 > 0)
              {
                  sum = sum + a2;
                  b2--;
              }
              Console.WriteLine("the mult is:" + sum);
              Console.WriteLine("---------------------------------------------------------------");
              Console.WriteLine("TARGIL 4");
              Console.WriteLine("please enter a number:");
              int prime = Convert.ToInt32(Console.ReadLine());
              int SmallestPrime = 1;
              if (prime == 2)
              {
                  Console.WriteLine("it's a prime!!");
              }
              while (SmallestPrime <= prime)
              {
                  if (prime % SmallestPrime == 0)
                  {
                      Console.WriteLine("divied " + SmallestPrime);
                  }
                  else
                  {
                      Console.WriteLine("not divied " + SmallestPrime);
                  }
                  SmallestPrime++;
              }
              Console.WriteLine("---------------------------------------------------------------");
              Console.WriteLine("TARGIL 5");
              Console.WriteLine("please enter a 1 digit number:");
              int x = Convert.ToInt32(Console.ReadLine());
              while (x >= 0)
              {
                  Console.WriteLine(x);
                  x--;
              }
              Console.WriteLine(x);
              Console.WriteLine("---------------------------------------------------------------");
              Console.WriteLine("TARGIL 6");
              Console.WriteLine("please enter a number");
              double num1 = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("please enter another number");
              double num2 = Convert.ToDouble(Console.ReadLine());
              double sum1 = num1 + num2;
              double avg = sum1 / 2;
              Console.WriteLine("the sum is: " + sum1);
              Console.WriteLine("the avg is: " + avg);
              Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("TARGIL 7");
            int i = 0;
            int sum7 = 0;
            while (i >= 0)
            {
                Console.WriteLine("please enter a number:");
                i = Convert.ToInt32(Console.ReadLine());
                sum7 = sum7 + i;
            }
            if (i < 0)
            {
                sum7 = sum7 + Math.Abs(i);
                Console.WriteLine("the sum is: " + sum7);
            }
                Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("TARGIL 8");
            Console.WriteLine("please enter a number:");
            int a8 = Convert.ToInt32(Console.ReadLine());
            int m8 = 2;
            string p8 = "prime number!";
            if (a8 % m8 == 0)
            {
                p8 = "not prime!";
            }
            while (a8 % m8 != 0 && m8 < a8)
            {
                p8 = "prime number";
                m8++;
                if (a8 % m8 == 0 && m8<a8)
                {
                    p8 = "not prime";
                }
            }
            Console.WriteLine(p8);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("TARGIL 9");
            int secret = 0;
            int guess = 0;
            int i9 = 0;
            while (i9 >= 0)
            {
                Console.WriteLine("please enter a number:");
                 secret = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter another number:");
                 guess = Convert.ToInt32(Console.ReadLine());
                if (guess < secret)
                {
                    Console.WriteLine("too small");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("too big");
                }
                else
                {
                    Console.WriteLine("bingo");
                    i9 = -1;
                }
            }
        }
    }
}