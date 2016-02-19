using System;

namespace Study.FormatStrings {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(FormatCoins("Munir", 10));
            Console.ReadKey();
        }

        static string FormatCoins(string name, int coins) {
            return String.Format("Player {0}, collected {1} coins.", name, coins.ToString("###0"));
        }
    }
}
