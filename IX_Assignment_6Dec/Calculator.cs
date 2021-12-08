using System;

public static class Calculator 
{

    public static void Sum(int number1, int number2)
    {
        Console.WriteLine("Sum = {0}", number1 + number2);
    }

    public static void Product(int number1, int number2)
    {
        Console.WriteLine("Product = {0}", number1 * number2);
    }

    public static void Modulus(int number1, int number2)
    {
        Console.WriteLine("Mod = {0}", number1 % number2);
    }
}