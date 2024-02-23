using System;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MysqlEx
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                // Add a new student
                var student = new Student
                {
                    Name = "Nguyen Van A",
                    Address = "Ha Noi"
                };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Done");

                // Read all students
                var students = context.Students.ToList();
                Console.WriteLine("Students list:");
                foreach (var s in students)
                {
                    Console.WriteLine($"- {s.Name} - {s.Address}");
                }

                // Update a student
                var studentToUpdate = context.Students.FirstOrDefault();
                if (studentToUpdate != null)
                {
                    studentToUpdate.Name = "Nguyen Van B";
                    context.SaveChanges();
                    Console.WriteLine("Student updated");
                }


                // // Delete a student
                // var studentToDelete = context.Students.FirstOrDefault();
                // if (studentToDelete != null)
                // {
                //     context.Students.Remove(studentToDelete);
                //     context.SaveChanges();
                //     Console.WriteLine("Student deleted");
                // }

            }
        }
    }
}
