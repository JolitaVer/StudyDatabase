using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDatabase
{
    public class Departament
    {
        public Guid Id { get; set; }
        public string DepName { get; set; }
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
