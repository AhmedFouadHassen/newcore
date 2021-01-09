using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newcore.Models
{
  public  interface Istudents
    {
        IEnumerable<Student> students { get; }

        void addstudent(Student student);
        Student getallstudent(int id);

        void updatestudent(Student student);

    }
}
