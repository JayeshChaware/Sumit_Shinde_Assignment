using System;
using System.Collections.Generic;
using System.Text;
class StringManupulationFunctions
{
    private void CloneString(string inputString) //clone() example
    {
        string stringClone = (string)inputString.Clone();
        Console.WriteLine("Inputted string is: {0}\nClone String is: {1}\n", inputString, stringClone);
    }

    private void CompareString(string inputStringOne, string inputStringTwo)
    {
        int isSame = string.Compare(inputStringOne, inputStringTwo);
        if (isSame == 1)
            Console.WriteLine("{0} and {1} are same", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} are different", inputStringOne, inputStringTwo);
    }

    private void CompareOrdinalString(string inputStringOne, int inputIndexOne, string inputStringTwo, int inputIndexTwo, int length)
    {
        int isSame = string.CompareOrdinal(inputStringOne, inputIndexOne, inputStringTwo, inputIndexTwo, length);
        if (isSame == 1)
            Console.WriteLine("{0} and {1} have some part in common", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} dont have some part in common", inputStringOne, inputStringTwo);
    }

    private void CompareToString(string inputStringOne, string inputStringTwo)
    {
        int isSame = inputStringOne.CompareTo(inputStringTwo);
        if (isSame == 1)
            Console.WriteLine("{0} and {1} are same", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} are different", inputStringOne, inputStringTwo);
    }

    private void ConcatString(string inputStringOne, string inputStringTwo)
    {
        string concatedString = string.Concat(inputStringOne, inputStringTwo);
        Console.WriteLine("after concating {0} and {1} we get: {2}", inputStringOne, inputStringTwo, concatedString);
    }

    private void ContainsString(string inputStringOne, string inputStringTwo)
    {
        bool isContains = inputStringOne.Contains(inputStringTwo);
        if (isContains)
            Console.WriteLine("{0} contains {1}", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} does not contains {1} ", inputStringOne, inputStringTwo);
    }

    private void CopyString(string inputStringOne)
    {
        string stringCopy = string.Copy(inputStringOne);
        Console.WriteLine("original sytring: {0} \ncopy string: {1}", inputStringOne, stringCopy);
    }

    private void CopyToString(int startIndex, string inputStringOne, int totalIndex)
    {
        char[] stringCopy = new char[totalIndex];
        inputStringOne.CopyTo(startIndex, stringCopy, 0, totalIndex);
        Console.WriteLine("original sytring: {0} \ncopy string:", inputStringOne);
        foreach (char viewChar in stringCopy)
        {
            Console.Write(viewChar);
        }
    }

    private void EndsWithString(string inputStringOne, string inputStringTwo)
    {
        bool isEndsWith = inputStringOne.EndsWith(inputStringTwo);
        if (isEndsWith)
            Console.WriteLine("{0} ends with {1}", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} does not ends with {1} ", inputStringOne, inputStringTwo);
    }

    private void EqualsString (string inputStringOne, string inputStringTwo)
    {
        bool isEquals = Equals(inputStringTwo, inputStringOne);
        if (isEquals)
            Console.WriteLine("{0} and {1} are equal", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} are not equal", inputStringOne, inputStringTwo);
    }

    private void FormatString(string inputStringOne)
    {
        string formatString;
        formatString = string.Format("example of {0} method",inputStringOne);
        Console.WriteLine(formatString);
    }

    private void GetEnumeratorString()
    {
        //ask
    }

    private void GetHashCodeInt(int inputNumber)
    {
        int hasgCode=inputNumber.GetHashCode();
        Console.WriteLine("hash code of {0} is: {1}",inputNumber,hasgCode);
    }

    private void GetTypeDataType(string inputData)
    {
        Console.WriteLine(inputData.GetType());
    }

    private void GetTypeCodeString(string inputData)
    {
        Console.WriteLine(inputData.GetTypeCode());
    }

    private void IndexOfString(string inputString, char searcChar)
    {
        int indexOfElement = inputString.IndexOf(searcChar);
    }

    private void InsertString(string inputString)
    {
        Console.WriteLine("Inserted : {0}", inputString.Insert(4, "SB"));
    }
    private void InternString(string inputString)
    {
        string internString = string.Intern(inputString);
        string isInternedString = string.IsInterned(inputString);

        Console.WriteLine("Intern : {0}", internString);
        Console.WriteLine("IsInterned : {0}", isInternedString);
    }

    private void IsNormalizedString(string inputString)
    {
        Console.WriteLine("IsNormalized : {0}", inputString.IsNormalized());
    }
    private void IsNullOrEmptyString(string inputString)
    {
        Console.WriteLine("IsNullOrEmpty : {0}", string.IsNullOrEmpty(inputString));
    }
    private void JoinString()
    {
        object[] objectArray = { "Jayesh","Chaware"};
        string joinString = string.Join(" ",objectArray);
        Console.WriteLine("value after join: {0}",joinString);
    }
    private void IsNullOrWhiteSpaceString()
    {
        string[] demoValueString = { null, "100", " ", " ", new string(' ',10), "jayesh"};
        foreach (string element in demoValueString)
            Console.WriteLine(string.IsNullOrWhiteSpace(element));
    }
    private void LastIndexOfString(string inputString)
    {
        Console.WriteLine(inputString.LastIndexOf)
    }
    private void LastIndexOfAnyString()
    {

    }
    private void NormalizeString()
    {

    }
    private void PadLeftString()
    {

    }
    private void PadRightString()
    {

    }
    private void RemoveString()
    {

    }
    private void ReplaceString()
    {

    }
    private void SplitString()
    {

    }
    private void StartsWithString()
    {

    }
    private void SubstringString()
    {

    }
    private void ToCharArrayString()
    {

    }
    private void String()
    {

    }
    private void ToLowerString()
    {

    }
    private void ToLowerInvariantString()
    {

    }
    private void ToStringString()
    {

    }
    private void ToUpperString()
    {

    }
    private void TrimString()
    {

    }
    private void TrimEndString()
    {

    }
    private void TrimStartString()
    {

    }
  

}