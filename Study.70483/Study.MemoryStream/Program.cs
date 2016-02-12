using System;
using System.Runtime.Serialization;
using System.Xml;

namespace Study.MemoryStream {
    class Program {
        static void Main(string[] args) {
            var response = WriteName("Something");
            Console.WriteLine(response);
            Console.ReadKey();
        }

        static System.IO.MemoryStream WriteName(string name) {
            var ms = new System.IO.MemoryStream();
            var binary = XmlDictionaryWriter.CreateBinaryWriter(ms);
            var ser = new DataContractSerializer(typeof(string));
            ser.WriteObject(binary, name);
            binary.WriteEndDocument();
            return ms;
        }
    }
}
