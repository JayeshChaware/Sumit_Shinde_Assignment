using System;
using System.Text;

namespace StringBuilderFuncton
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilderMethods stringBuilderMethod = new StringBuilderMethods();
            StringBuilder inputString=new StringBuilder("jayesh");
            stringBuilderMethod.AppendStringBuilder(inputString);
            stringBuilderMethod.AppendFormatStringBuilder(inputString);
            stringBuilderMethod.InsertStringBuilder(inputString);
            stringBuilderMethod.RemoveStringBuilder(inputString);
            stringBuilderMethod.ReplaceStringBuilder(inputString);

        }
    }
}
