using System;

namespace Dec_7_Assignmet
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManupulationFunctions SMF = new StringManupulationFunctions();
            SMF.CloneString("jayesh");
            SMF.CompareString("jayesh","chaware");
            SMF.CompareOrdinalString("jayesh",3,"yesh",3,4);
            SMF.CompareToString("jayesh","JayeSh");
            SMF.ConcatString("jayesh ","chaware");
            SMF.ContainsString("jayesh", "jay");
            SMF.CopyString("jayesh");
            SMF.CopyToString(2,"jayesh",3);
            SMF.EndsWithString("jayesh","sh");
            SMF.EqualsString("jayesh","jAyesh");
            SMF.FormatString("jayesh");
            SMF.GetHashCodeInt(3);
            SMF.GetTypeCodeString("jayesh");
            SMF.IndexOfString("jayesh",'s');
            SMF.InsertString("jayesh");
            SMF.InternString("jayesh");
            SMF.IsNormalizedString("jayesh");
            SMF.IsNullOrEmptyString(" ");
            SMF.JoinString();
            SMF.IsNullOrWhiteSpaceString();
            SMF.LastIndexOfString("jayesh");
            SMF.LastIndexOfAnyString("jayesh");
            SMF.NormalizeString("jayesh");
            SMF.PadLeftString("jayesh");
            SMF.PadRightString("jayesh");
            SMF.RemoveString("jayesh");
            SMF.ReplaceString("jayesh");
            SMF.SplitSpaceString("jayesh chaware");
            SMF.SplitCommaString("jay,esh,chaw,are");
            SMF.SplitCharString("jau=yesh chaware");
            SMF.SubstringString("jayesh");
            SMF.ToCharArrayString("jayesh");
            SMF.ToLowerString("JayeSH");
            SMF.ToLowerInvariantString("jayESh");
            SMF.ToStringString(12363);
            SMF.ToUpperString("jayesh");
            SMF.TrimString("Jayesh");
            SMF.TrimEndString("jayesh");
            SMF.TrimStartString("jayesh");

        }
    }
}
