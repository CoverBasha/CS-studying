using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_studying
{
    public class Student : User
    {
        public List<Course> Courses { get; set; }
        public List<Certificate> Certificates { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
}
