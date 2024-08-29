using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoin
{
    public class Student 
    {


        public int StudentId { get; set; }
        public string FirstName { get; set; }
      
        public int ClassId { get; set; }
        public Student(int studentId,string firstname,int classId)
        {
            StudentId = studentId;
            FirstName = firstname;
            ClassId = classId;
        }
    }
}
