using System;
using System.Data.Entity;

namespace CodeFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student()
                {
                    FirstName = "Tommy",
                    LastName = "Curley"
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }

            Console.WriteLine("Student Added.");
            Console.ReadLine();
        }
    }

    public class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
