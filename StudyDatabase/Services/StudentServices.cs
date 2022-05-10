using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDatabase
{
    public class StudentServices
    {
        private readonly StudyDbContext _context;

        public StudentServices(StudyDbContext context)
        {
            _context = context;
        }

        public void CreateStudent(string name)
        {
            var newstudent = new Student() { Name = name };
            _context.Students.Add(newstudent);
            _context.SaveChanges();
        }
        
    }
}
