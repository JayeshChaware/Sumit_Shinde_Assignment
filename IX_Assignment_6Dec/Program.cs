using System;

namespace IX_Assignment_6Dec
{
    public delegate void DisplayMessage(string name);
    public delegate void CalculateNaturalNuber(int number1, int number2);    // delegate foe add Sum and Product method

    class Program
    {
        static void Main(string[] args)
        {
            CalculateNaturalNuber CalculateSum = new CalculateNaturalNuber(Calculator.Sum);//Delegate object for Sum method
            CalculateSum(9, 21);
            CalculateNaturalNuber CalculateProduct = new CalculateNaturalNuber(Calculator.Product);//delegate object for Product method
            CalculateProduct(9, 21);

            CalculateNaturalNuber[] CalculateAll = new CalculateNaturalNuber[3];  //array of delegate
            CalculateAll[0] = new CalculateNaturalNuber(Calculator.Sum);
            CalculateAll[1] = new CalculateNaturalNuber(Calculator.Product);
            CalculateAll[2] = new CalculateNaturalNuber(Calculator.Modulus);
            CalculateAll[0](13,5);
            CalculateAll[1](13, 5);
            CalculateAll[2](13, 5);

            CalculateNaturalNuber calSum, calProduct, calModulus, calAll;  //multi casting delegate
            calSum = new CalculateNaturalNuber(Calculator.Sum);
             calProduct= new CalculateNaturalNuber(Calculator.Product);
            calModulus = new CalculateNaturalNuber(Calculator.Modulus);
            calAll = calSum + calProduct + calModulus;

            calAll(7,21);

            DisplayMessage print = delegate (string name)
            {                                                //anonymous delegate
                Console.WriteLine("Welcome {0}", name);
            };

            print("Jayesh"); 

            ReflectionDemo refDemo = new ReflectionDemo();
            refDemo.GetType(); //reflection example
        }
    }
}
