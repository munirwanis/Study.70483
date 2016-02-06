using System;
using System.Net;

namespace Study._70483 {
    class Program {
        static void Main(string[] args) {
            try {
                WebClient client = new WebClient();
                client.DownloadFile("https://octodex.github.com/images/baracktocat.jpg", $@"C:\Users\{Environment.UserName}\Pictures\file1.jpg");
                client.Dispose();
                Console.WriteLine("File saved...");
                Console.ReadKey();
            } catch (Exception exception) {
                Console.WriteLine(exception);
                Console.ReadKey();
            }
        }
    }
}
