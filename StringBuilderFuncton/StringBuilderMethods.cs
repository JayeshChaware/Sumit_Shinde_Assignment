using System.Text;
using System;
namespace StringBuilderFuncton
{
    public class StringBuilderMethods
    {
        public void AppendStringBuilder(StringBuilder inputStingBuilder)
        {
            Console.WriteLine("Append functoin: {0}", inputStingBuilder.Append(" Hello World!"));
        }

        public void AppendFormatStringBuilder(StringBuilder inputStringBuilder)
        {
            Console.WriteLine("AppendFormat function: {0}", inputStringBuilder.AppendFormat(" Hello World!"));
        }

        public void InsertStringBuilder(StringBuilder inputStringBuilder)
        {
            Console.WriteLine("Insert function: {0}", inputStringBuilder.Insert(6, " Hello World"));
        }

        public void RemoveStringBuilder(StringBuilder inputStringBuilder)
        {
            Console.WriteLine("Remove function: {0}", inputStringBuilder.Remove(6, 3));
        }

        public void ReplaceStringBuilder(StringBuilder inputStringBuilder)
        {
            Console.WriteLine("Replace function: {0}", inputStringBuilder.Replace("jay", "jayesh Chaware "));
        }
    }
}
