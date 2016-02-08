using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.LambdaExpression {
    class Program {
        static void Main(string[] args) {
            List<string> departments = new List<string>
            {
                "Accounting", "Marketing", "Sales", "Manufacturing", "Information Systems", "Training"
            };


        }

        private static bool GetMatches(List<string> departments, string searchTerm) {
            // Original:
            //var findDepartment = departments.Exists((delegate (string deptName) {
            //    return deptName.Equals(searchTerm);
            //}));

            // Response
            var findDepartment = departments.Exists((deptName => deptName.Equals(searchTerm)));
            return findDepartment;
        }
    }
}
