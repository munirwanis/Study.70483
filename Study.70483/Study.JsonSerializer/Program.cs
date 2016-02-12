using System;
using System.Linq;
using System.Web.Script.Serialization;

namespace Study.JsonSerializer {
    class Program {
        static void Main(string[] args) {
            string json = "{\"FirstName\": \"David\", \"LastName\": \"Jones\", \"Values\": [0, 1, 2]}";
            var response = ConvertToName(json);
            Console.WriteLine($"{response.FirstName} {response.LastName}\n" +
                              $"Values: {string.Concat(from item in response.Values select response.Values[item] + " ")}");
            Console.ReadKey();
        }

        public static Name ConvertToName(string json) {
            var ser = new JavaScriptSerializer();
            return ser.Deserialize<Name>(json);
        }
    }

    public class Name {
        public int[] Values { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
