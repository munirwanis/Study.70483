using System;
using System.Dynamic;

namespace Study.DynamicAndObjectTypes {
    class Program {
        static void Main(string[] args) {
            var message = new { From = "Jim Morris", To = "Mary North", Content = "Hello World" };
            SendMessage(message);

            dynamic messageExpando = new ExpandoObject();
            messageExpando.From = "Expando Morris";
            messageExpando.To = "Expando North";
            messageExpando.Content = "Hello Expando";
            SendMessage(messageExpando);

            Console.ReadKey();
        }

        private static void SendMessage(dynamic msg) {
            Console.WriteLine(msg.From);
            Console.WriteLine(msg.To);
            Console.WriteLine(msg.Content);
        }
    }
}
