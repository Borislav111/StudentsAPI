using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.StudentsContext;

namespace WebApi.Services
{
    public class StudentManager
    {
        public List<Students> getAll()
        {
            using (StudentsDBContext context = new StudentsDBContext())
            {
                List<Students> all = context.Students.ToList();
                return all;
            }
        }
        public void Add(Students model)
        {
            using (StudentsDBContext context = new StudentsDBContext())
            {
                context.Students.Add(model);
                context.SaveChanges();
            }
        }
        public Students Get(long id)
        {
            using (StudentsDBContext context = new StudentsDBContext())
                return context.Students.FirstOrDefault(s => s.StudentId == id);
        }
        public void Delete(Students student)
        {
            using(StudentsDBContext context = new StudentsDBContext())
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
