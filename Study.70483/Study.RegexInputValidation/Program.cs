using System;
using System.Text.RegularExpressions;

namespace Study.RegexInputValidation {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ContainsHyperlink("<a href=\"http://www.w3schools.com/html/\">Visit our HTML tutorial</a>"));
            Console.ReadKey();
        }

        static bool ContainsHyperlink(string inputData) {
            string regExpattern = "href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))";
            var evaluator = new Regex(regExpattern, RegexOptions.Compiled);
            return evaluator.IsMatch(inputData);
        }
    }
}
