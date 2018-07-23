using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstexample
{
    class Program
    {
        static void Main(string[] args)
        {

            employeeinfo e1 = new employeeinfo { name = "deepa", dept = "training", salary = 45000 };
            CodeDBEntities db = new CodeDBEntities();
            db.EmployeeInfos.Add(e1);
            var res = db.SaveChanges();
            if (res > 0)
                Console.WriteLine("data inserted");
        }
    }
}
