using System;
using System.Runtime.InteropServices;

namespace NetSamples.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exceptions that we can't handle
            //try
            //{
            //    //DoSmth(1);
            //    var st = "SomeSpecificString";
            //    for (int i = 0; i < Int32.MaxValue; i++)
            //    {
            //        st += st;
            //    }

            //}
            //catch (StackOverflowException e)
            //{
            //    Console.WriteLine(e);
            //}
            
            try
            {
                Do();
            }

            catch (DivideByZeroException ex)
            {
                HandleException(ex);
                Console.WriteLine($"Result of dividing by zero is infinity");
            }

            catch (FormatException ex)
            {
                HandleException(ex);
                Console.WriteLine($"Next time please enter some number");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Console.WriteLine("finally");

                try
                {
                    var obj = new MyCustomClass(-1);
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        static void Do()
        {
            try
            {
                Console.WriteLine("Enter X:");
                var x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y:");
                var y = Convert.ToInt32(Console.ReadLine());
                if (y == 0)
                {
                    Console.WriteLine($"Impossible to divide by zero");
                }
                Console.WriteLine($"{x}/{y} = {x / y}");

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Impossible to divide by zero");

                //throw new DivideByZeroException();
                throw ex;
            }

            finally
            {
                Console.WriteLine("inner finally");
            }
        }

        static void HandleException(Exception ex)
        {
            Console.WriteLine("Exception was handled");

            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

        }

        static int DoSmth(int i)
        {
            return DoSmth(i++);
        }
    }
}