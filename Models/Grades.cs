using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Grades
    {
        public int Id { get; set; }
        public string Object { get; set; }
        public int Grade { get; set; }

        public IList<StudentGrades> StudentGrades { get; set; }
    }
}
