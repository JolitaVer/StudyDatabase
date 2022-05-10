using System;

namespace StudyDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new StudyDbContext();
            var departamentServices = new DepartamentServices(context);
            var lectureServices = new LectureServices(context);
            var studentServices = new StudentServices(context);

            //**********************
            //ADD New Departaments
            //**********************
            departamentServices.CreateDepatament("DepartamentA");
            departamentServices.CreateDepatament("DepartamentB");

            //**********************
            //ADD New Lectures
            //**********************    
            lectureServices.CreateLecture("Lecture1");
            lectureServices.CreateLecture("Lecture2");
            lectureServices.CreateLecture("Lecture3");
            lectureServices.CreateLecture("Lecture4");
            lectureServices.CreateLecture("Lecture5");
            lectureServices.CreateLecture("Lecture6");

            //**********************
            //ADD New Students
            //**********************            
            studentServices.CreateStudent("StudentA");
            studentServices.CreateStudent("StudentB");
            studentServices.CreateStudent("StudentC");
            studentServices.CreateStudent("StudentD");

            var lecture7 = new Lecture() { LectureTitle = "Lecture7" };
            

            


        }
    }
}
