using System;
class StringManupulationFunctions
{
    public void CloneString(string inputString) //clone() example
    {
        string stringClone = (string)inputString.Clone();
        Console.WriteLine("Inputted string is: {0}\nClone String is: {1}\n", inputString, stringClone);
    }

    public void CompareString(string inputStringOne, string inputStringTwo)
    {
        int isSame = string.Compare(inputStringOne, inputStringTwo);
        if (isSame == 1)
            Console.WriteLine("{0} and {1} are same", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} are different", inputStringOne, inputStringTwo);
    }

    public void CompareOrdinalString(string inputStringOne, int inputIndexOne, string inputStringTwo, int inputIndexTwo, int length)
    {
        int isSame = string.CompareOrdinal(inputStringOne, inputIndexOne, inputStringTwo, inputIndexTwo, length);
        if (isSame == 1)
            Console.WriteLine("{0} and {1} have some part in common", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} dont have some part in common", inputStringOne, inputStringTwo);
    }

    public void CompareToString(string inputStringOne, string inputStringTwo)
    {
        int isSame = inputStringOne.CompareTo(inputStringTwo);
        if (isSame == 1)
            Console.WriteLine("{0} and {1} are same", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} are different", inputStringOne, inputStringTwo);
    }

    public void ConcatString(string inputStringOne, string inputStringTwo)
    {
        string concatedString = string.Concat(inputStringOne, inputStringTwo);
        Console.WriteLine("after concating {0} and {1} we get: {2}", inputStringOne, inputStringTwo, concatedString);
    }

    public void ContainsString(string inputStringOne, string inputStringTwo)
    {
        bool isContains = inputStringOne.Contains(inputStringTwo);
        if (isContains)
            Console.WriteLine("{0} contains {1}", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} does not contains {1} ", inputStringOne, inputStringTwo);
    }

    public void CopyString(string inputStringOne)
    {
        string stringCopy = string.Copy(inputStringOne);
        Console.WriteLine("original sytring: {0} \ncopy string: {1}", inputStringOne, stringCopy);
    }

    public void CopyToString(int startIndex, string inputStringOne, int totalIndex)
    {
        char[] stringCopy = new char[totalIndex];
        inputStringOne.CopyTo(startIndex, stringCopy, 0, totalIndex);
        Console.WriteLine("original sytring: {0} \ncopy string:", inputStringOne);
        foreach (char viewChar in stringCopy)
        {
            Console.Write(viewChar);
        }
    }

    public void EndsWithString(string inputStringOne, string inputStringTwo)
    {
        bool isEndsWith = inputStringOne.EndsWith(inputStringTwo);
        if (isEndsWith)
            Console.WriteLine("{0} ends with {1}", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} does not ends with {1} ", inputStringOne, inputStringTwo);
    }

    public void EqualsString(string inputStringOne, string inputStringTwo)
    {
        bool isEquals = Equals(inputStringTwo, inputStringOne);
        if (isEquals)
            Console.WriteLine("{0} and {1} are equal", inputStringOne, inputStringTwo);
        else
            Console.WriteLine("{0} and {1} are not equal", inputStringOne, inputStringTwo);
    }

    public void FormatString(string inputStringOne)
    {
        string formatString;
        formatString = string.Format("example of {0} method", inputStringOne);
        Console.WriteLine(formatString);
    }

    public void GetEnumeratorString()
    {
        //ask
    }

    public void GetHashCodeInt(int inputNumber)
    {
        int hasgCode = inputNumber.GetHashCode();
        Console.WriteLine("hash code of {0} is: {1}", inputNumber, hasgCode);
    }

    public void GetTypeDataType(string inputData)
    {
        Console.WriteLine(inputData.GetType());
    }

    public void GetTypeCodeString(string inputData)
    {
        Console.WriteLine(inputData.GetTypeCode());
    }

    public void IndexOfString(string inputString, char searcChar)
    {
        int indexOfElement = inputString.IndexOf(searcChar);
    }

    public void InsertString(string inputString)
    {
        Console.WriteLine("Inserted : {0}", inputString.Insert(4, "SB"));
    }
    public void InternString(string inputString)
    {
        string internString = string.Intern(inputString);
        string isInternedString = string.IsInterned(inputString);

        Console.WriteLine("Intern : {0}", internString);
        Console.WriteLine("IsInterned : {0}", isInternedString);
    }

    public void IsNormalizedString(string inputString)
    {
        Console.WriteLine("IsNormalized : {0}", inputString.IsNormalized());
    }
    public void IsNullOrEmptyString(string inputString)
    {
        Console.WriteLine("IsNullOrEmpty : {0}", string.IsNullOrEmpty(inputString));
    }
    public void JoinString()
    {
        object[] objectArray = { "Jayesh", "Chaware" };
        string joinString = string.Join(" ", objectArray);
        Console.WriteLine("value after join: {0}", joinString);
    }
    public void IsNullOrWhiteSpaceString()
    {
        string[] demoValueString = { null, "100", " ", " ", new string(' ', 10), "jayesh" };
        foreach (string element in demoValueString)
            Console.WriteLine(string.IsNullOrWhiteSpace(element));
    }
    public void LastIndexOfString(string inputString)
    {
        Console.WriteLine(inputString.LastIndexOf('h'));
    }
    public void LastIndexOfAnyString(string inputString)
    {
        char[] ch = { 'h', 'e' };
        Console.WriteLine(inputString.LastIndexOfAny(ch));
    }
    public void NormalizeString(string inputString)
    {
        Console.WriteLine("Normalize : {0} ", inputString.Normalize());
    }
    public void PadLeftString(string inputString)
    {
        Console.WriteLine("Pad Left : {0} ", inputString.PadLeft(5));
    }
    public void PadRightString(string inputString)
    {
        Console.WriteLine("Pad Right : {0} ", inputString.PadRight(6));
    }
    public void RemoveString(string inputString)
    {
        Console.WriteLine("Remove : {0} ", inputString.Remove(3));
    }
    public void ReplaceString(string inputString)
    {
        Console.WriteLine("Replaced : {0} ", inputString.Replace('e', 'z'));
    }
    public void SplitSpaceString(string inputString)
    {
        string[] splittedString = inputString.Split(' ');
        Console.WriteLine("Split using whitespace : ");
        foreach (string individualString in splittedString)
        {
            Console.WriteLine(individualString);
        }
    }
    public void SplitCommaString(string inputString)
    {
        string[] splittedString = inputString.Split(',');
        Console.WriteLine("Split using comma : ");
        foreach (string individualString in splittedString)
        {
            Console.WriteLine(individualString);
        }
    }

    public void SplitCharString(string inputString)
    {
        string[] splittedString = inputString.Split('a');
        Console.WriteLine("Split using character : ");
        foreach (string individualString in splittedString)
        {
            Console.WriteLine(individualString);
        }
    }
    public void StartsWithString(string inputString)
    {
        Console.WriteLine("StartsWith : {0} ", inputString.StartsWith("S"));
    }
    public void SubstringString(string inputString)
    {
        Console.WriteLine("Substring : {0} ", inputString.Substring(3));
    }
    public void ToCharArrayString(string inputString)
    {
        char[] stringToChar = inputString.ToCharArray();

        Console.WriteLine("String: " + inputString);
        Console.Write("Character array :");
        foreach (char i in stringToChar)
        {
            Console.Write("{0} ", i);
        }
    }

    public void ToLowerString(string inputString)
    {
        Console.WriteLine("{0} to lower {1}",inputString,inputString.ToLower());
    }
    public void ToLowerInvariantString(string inputString)
    {
        Console.WriteLine("{0} to lower invariant {1}", inputString, inputString.ToLowerInvariant());
    }
    public void ToStringString(int inputNumber)
    {
        Console.WriteLine("to string demo: {0}",inputNumber.ToString());
    }
    public void ToUpperString(string inputString)
    {
        Console.WriteLine("{0} to upper {1}", inputString, inputString.ToUpper());
    }
    public void TrimString(string inputString)
    {

        Console.WriteLine("{0} after trim {1}", inputString, inputString.Trim('j'));
    }
    public void TrimEndString(string inputString)
    {
        Console.WriteLine("{0} after trim start{1}", inputString, inputString.TrimStart('a'));
    }
    public void TrimStartString(string inputString)
    {
        Console.WriteLine("{0} after trim end {1}", inputString, inputString.TrimEnd('y'));
    }


}