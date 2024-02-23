using System;
using System.Linq;

class Program{
    public static void Main(string[] args)
    {
        using(var context = new AppDbContext()){
            context.Database.EnsureCreated();
            //Add new Student
            var newStudent = new Student{Name ="Hai",Address="Ha Noi"};
            context.Add(newStudent);
            context.SaveChanges();//cap nhat tu Entity vao Db
            Console.WriteLine("Student Created");

            //Read student 
            var students = context.Students.ToList();
            Console.WriteLine("Students: ");
            foreach(var student in students){
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Address: {student.Address}");
            }
            //Update student 
            var studentToUpdate = context.Students.FirstOrDefault();
            if(studentToUpdate !=null){
                studentToUpdate.Address ="Vinh Phuc";
                context.SaveChanges();
                Console.WriteLine("Student updated");
            }
            //Delete student
            var studentToDelete = context.Students.FirstOrDefault();
            if(students !=null){
                context.Remove(studentToDelete);
                context.SaveChanges();
                Console.WriteLine("Student deleted");
            }
            //Read student to check update or delete 
            var studentss = context.Students.ToList();
            Console.WriteLine("Students: ");
            foreach(var student in studentss){
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Address: {student.Address}");
            }
        }
    }
}