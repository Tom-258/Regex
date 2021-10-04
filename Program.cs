using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Problem1("99"));
            Console.WriteLine(Problem2_6("abb", @"^ab*"));//problem2
            Console.WriteLine(Problem2_6("ab", @"^ab+"));//problem3
            Console.WriteLine(Problem2_6("ab", @"^ab?$"));//problem4
            Console.WriteLine(Problem2_6("abbb", @"^ab{3}?$"));//problem5
            Console.WriteLine(Problem2_6("abbb", @"^abbb?$"));//problem6
            Console.WriteLine(Problem7_9("abcd_d_abbbbs", @"^([a-zA-Z]+_)+"));//problem7
            Console.WriteLine(Problem7_9("Abcddabbbb", @"^([A-Z][a-z]*)"));//problem8
            Console.WriteLine(Problem7_9("abcddabbbb", @"^(a[a-zA-Z]*b$)"));//problem9
            

        }

        static bool Problem1(string myString)
        {
            const string pattern = @"^[\dA-Za-z]*$";
            var regex = new System.Text.RegularExpressions.Regex(pattern);
            return regex.IsMatch(myString);
        }
        static bool Problem2_6(string myString, string pattern)
        {
            var regex = new System.Text.RegularExpressions.Regex(pattern);
            return regex.IsMatch(myString);
        }

        static object Problem7_9(string myString, string pattern)
        {
            var matches = System.Text.RegularExpressions.Regex.Matches(myString, pattern);
            return matches.Cast<object>().FirstOrDefault();
        }


    }
}
