using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDatabase
{
    public class DepartamentServices
    {
        private readonly StudyDbContext _context;

        public DepartamentServices(StudyDbContext context)
        {
            _context = context;
        }

        public void CreateDepatament(string depName)
        {
            var departament = new Departament() { DepName = depName };
            _context.Departaments.Add(departament);
            _context.SaveChanges();
        }
    }
}
