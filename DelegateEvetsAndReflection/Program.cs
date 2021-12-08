using System;

namespace DelegateEvetsAndReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*What is a Delegate in C#? 
              Why do we need delegates in C#?
              What are the benefits of delegates ?
              What are types of delegates in C#?
              How to define a delegates in C#? and write a syntax/definition for delegates
              What is a Singlecast delegate in C#? and write a program for singlecast delegate
              What is a Multicast delegate in C#? and write a program for muliticast delegates
              What are Anonymous Delegates in C#? and write a program for anonymous delegates
              How to Use Events and Delegates in C#? and write a sample program using events
              What is reflection ? and write a program to use reflection.*/

            /* What is a Delegate in C#?
            * C# delegates are similar to pointers to functions, in C or C++.
            * A delegate is a reference type variable that holds the reference to a method. 
            * The reference can be changed at runtime.
            * Delegates are especially used for implementing events and the call-back methods. 
            * All delegates are implicitly derived from the System.Delegate class.
            * To create a delegate we need to use create delegate keyword and later syntex is as same as function declearation.
            * to invoke a certain function the signature of a delegate should have teh same signature as the funcyion.
            * syntax: public delegate int MyDelegate (string s);
            */

            /* Why do we need delegates in C#?
             * Delegates allow methods to be passed as parameters.
             * Delegates allow methods to be passed as parameters.
             * Delegates can be used to define callback methods.
             * Delegates can be chained together; for example, multiple methods can be called on a single event.
             * Methods don't have to match the delegate type exactly. For more information, see Using Variance in Delegates.
             * Lambda expressions are a more concise way of writing inline code blocks. Lambda expressions (in certain contexts) are compiled to delegate types.
             * For more information about lambda expressions, see Lambda expressions.
             */



            /*What are the benefits of delegates ?
             *
             */


            /*How to define a delegates in C#? and write a syntax/definition for delegates
             * To define we need to use delegate keyword
             * syntax is access modifire delegate keyword return type delegate name and parameters  
             * example: public delegate int Calculate (int value1, int value2);
             * the signature of delegate and method that it is refering.
             * 
             */


        }
    }
}
