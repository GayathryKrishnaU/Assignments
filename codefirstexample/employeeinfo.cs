using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codefirstexample
{
    //POCO classes
    //plain old clr objects
    class employeeinfo
    {
        [Key]
        public int empid { get; set; }
        [Required]//not null in table
        public string name { get; set; }
        [Required]
        public string dept { get; set; }
        [Required]
        [Range(minimum:10000,maximum:50000,ErrorMessage ="salary between 10000&50000")]
        public double salary { get; set; }

    }
}
