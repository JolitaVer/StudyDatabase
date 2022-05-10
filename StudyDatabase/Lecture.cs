using System;
using System.Collections.Generic;

namespace StudyDatabase
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public string LectureTitle { get; set; }
        public List<Departament> Departaments { get; set; } = new List<Departament>();
    }
}