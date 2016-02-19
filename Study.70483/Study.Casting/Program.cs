using System;

namespace Study.Casting {
    class Program {
        static void Main(string[] args) {
            try {
                Calculate(1.23f);
                Console.ReadKey();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
        }

        static void Calculate(float amount) {
            object amountRef = amount;
            int balance = (int)(float)amountRef;
            Console.WriteLine(balance);
        }
    }
}
