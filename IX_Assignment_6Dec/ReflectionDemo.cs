using System;
using System.Reflection;

class ReflectionDemo 
{
    public void GetType()
    {
        int intValue = 10;
        Type type = intValue.GetType();
        Console.WriteLine("type of {0} is :{1}", intValue, type);
        Assembly info = typeof(int).Assembly;
        Console.WriteLine("{0} belongs to :{1}", intValue, info);
    }
}