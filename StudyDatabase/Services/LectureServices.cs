using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDatabase
{
    public class LectureServices
    {
        private readonly StudyDbContext _context;

        public LectureServices(StudyDbContext context)
        {
            _context = context;
        }

        public void CreateLecture(string lectureTitle)
        {
            var lecture = new Lecture() { LectureTitle = lectureTitle };
            _context.Lectures.Add(lecture);
            _context.SaveChanges();
        }
    }
}
