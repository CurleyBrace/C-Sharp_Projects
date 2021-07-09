using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstConsoleApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }

        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
