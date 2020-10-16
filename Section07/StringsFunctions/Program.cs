using System;

namespace StringsFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string original, s1, s2, s3, s4, s5, s6, s7;
            int n1, n2;
            bool b1, b2;


            Console.WriteLine("INSERT AN EXPRESSION:");
            //expression = Console.ReadLine();
            original = "abcde FGHIJ ABC abc DEFG";
            //STRING
            Console.WriteLine("s1 = original.ToUpper();");
            s1 = original.ToUpper();
            Console.WriteLine(s1);
            Console.WriteLine("s2 = original.ToLower();");
            s2 = original.ToLower();
            Console.WriteLine(s2);
            Console.WriteLine("s3 = original.Trim();");
            s3 = original.Trim();
            Console.WriteLine(s3);
            Console.WriteLine("s4 = original.Substring(3);");
            s4 = original.Substring(3);
            Console.WriteLine(s4);
            Console.WriteLine("s5 = original.Substring(3, 5);");
            s5 = original.Substring(3, 5);
            Console.WriteLine(s5);
            Console.WriteLine("s6 = original.Replace('a', 'x');");
            s6 = original.Replace('a', 'x');
            Console.WriteLine(s6);
            Console.WriteLine("s7 = original.Replace('abc', 'xy'); DOUBLE COMMA IS THE CORRECT FORM");
            s7 = original.Replace("abc", "xy");
            Console.WriteLine(s7);
            //INTEGERS
            n1 = original.IndexOf("bc");
            Console.WriteLine(n1);
            n2 = original.LastIndexOf("bc");
            Console.WriteLine(n2);
            // BOOL
            Console.WriteLine("b1 = String.IsNullOrEmpty(original);");
            b1 = String.IsNullOrEmpty(original);
            Console.WriteLine(b1);
            Console.WriteLine("b2 = String.IsNullOrWhiteSpace(original);");
            b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine(b2);








        }
    }
}
