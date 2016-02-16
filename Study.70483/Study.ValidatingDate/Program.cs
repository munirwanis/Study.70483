using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.ValidatingDate {
    class Program {
        static void Main(string[] args) {
            DateTime utcDate;
            string localTime = DateTime.Now.ToString("u");
            ConvertDateToUtc(localTime, out utcDate);

            Console.WriteLine($"Local Time: {localTime}\n" +
                              $"UTC Time  : {utcDate.ToString("u")}");
            Console.ReadKey();
        }

        static bool ConvertDateToUtc(string inputDate, out DateTime validatedDate) {
            bool validDate = DateTime.TryParse(inputDate, CultureInfo.CurrentCulture,
                DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out validatedDate);
            return validDate;
        }
    }
}
