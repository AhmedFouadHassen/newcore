using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace newcore.Models
{
    public class datastudent : Istudents
    {
        List<Student> Students = new List<Student>();
        public IEnumerable<Student> students
        {
            get
            {
                return new List<Student>
                {
                    new Student{StudId=1,studentname="احمد فؤاد",studentage="14",country=new Country{ countryId=1} },
                     new Student{StudId=1,studentname="محمد رجب",studentage="14",country=new Country{ countryId=2} },
                      new Student{StudId=1,studentname="علاء محمود",studentage="14",country=new Country{ countryId=1} }
                };
            }
        }

        public void addstudent(Student student)
        {
            Students.Add(student);
        }

        public Student getallstudent(int id)
        {
          var stud= Students.SingleOrDefault(p=>p.StudId==id);
            return stud;
           
        }

        public void updatestudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
