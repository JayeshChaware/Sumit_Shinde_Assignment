using System;

namespace ExceptionHandling
{
    public class ExeptionHandlingClass
    {
        public void ExceptionHandlingQuestionThree()
        {
            int[] arr = { 1 };
            

            try {
                Console.WriteLine("{0}/0={1}", arr[0], arr[0] / 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", arr[0]);
            }

            try
            {
                arr[1] = 100;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Cant add element in array. Array is full");
            }
            try
            {
                arr[0] = (int)'j';
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        
        public void ExceptionHandlingQuestionFour()
        {
            int[] arr = { 1 };
            try
            {
                Console.WriteLine("{0}/0={1}", arr[0], arr[0] / 0);
                arr[1] = 100;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", arr[0]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Cant add element in array. Array is full");
            }
            finally 
            {
                Console.WriteLine("program Executed");
            }

        }
    }
}
