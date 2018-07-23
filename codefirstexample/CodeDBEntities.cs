using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codefirstexample
{
    class CodeDBEntities:DbContext
    {
        public DbSet<employeeinfo> EmployeeInfos { get; set; }
        public CodeDBEntities():base("MyDB")
        {
        }
    }
}
