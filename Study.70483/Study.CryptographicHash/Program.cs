using System.IO;
using System.Security.Cryptography;

namespace Study.CryptographicHash {
    class Program {
        static void Main(string[] args) {
        }

        public static byte[] GenerateHash(string fileName, string hashAlgoritm) {
            var signatureAlgo = HashAlgorithm.Create(hashAlgoritm);
            var fileBuffer = File.ReadAllBytes(fileName);
            return signatureAlgo.ComputeHash(fileBuffer);
        }
    }
}
