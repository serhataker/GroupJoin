using GroupJoin;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize lists
       var studentList = new List<Student>
        {
            new Student(1, "Ali", 1),
            new Student(2, "Ayşe", 2),
            new Student(3, "Mehmet", 1),
            new Student(4, "Fatma", 3),
            new Student(5, "Ahmet", 2)
        };

        var classRooms = new List<ClassRoom>
        {
            new ClassRoom(1, "Matematik"),
            new ClassRoom(2, "Türkçe"),
            new ClassRoom(3, "Kimya")
        };

        var valueResult = classRooms.GroupJoin(
            studentList,
            classroom => classroom.ClassId, 
            student => student.ClassId,     
            (classroom, students) => new     
            {
                ClassName = classroom.ClassName,
                Students = students.ToList()
            }
        );

        foreach (var group in valueResult)
        {
            Console.WriteLine($"Class: {group.ClassName}");
            foreach (var student in group.Students)
            {
                Console.WriteLine($"  Student: {student.FirstName}");
            }

        }
    }
}
