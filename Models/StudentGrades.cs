using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class StudentGrades
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Students Students { get; set; }

        public int GradesId { get; set; }
        public Grades Grades { get; set; }

        
    }
}
