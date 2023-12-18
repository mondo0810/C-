using System;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    private static List<Student> students = new List<Student>();

    public static void Create(Student student)
    {
        students.Add(student);
    }

    public static List<Student> Read()
    {
        return students;
    }

    public static void Update(int id, Student newStudent)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                student.Name = newStudent.Name;
                student.Password = newStudent.Password;
                break;
            }
        }
    }

    public static void Delete(int id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                students.Remove(student);
                break;
            }
        }
    }

    public static Student Find(int id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }
        return null;
    }

    public static bool Login(string name, string password)
    {
        foreach (var student in students)
        {
            if (student.Name == name && student.Password == password)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Read Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Find Student");
            Console.WriteLine("6. Login");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter student ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter student password: ");
                    string password = Console.ReadLine();
                    Student.Create(new Student { Id = id, Name = name, Password = password });
                    Console.WriteLine("Student created successfully.");
                    break;
                case "2":
                    var students = Student.Read();
                    Console.WriteLine("Students:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Password: {student.Password}");
                    }
                    break;
                case "3":
                    Console.Write("Enter student ID to update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    var existingStudent = Student.Find(updateId);
                    if (existingStudent != null)
                    {
                        Console.Write("Enter new student name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new student password: ");
                        string newPassword = Console.ReadLine();
                        Student.Update(updateId, new Student { Name = newName, Password = newPassword });
                        Console.WriteLine("Student updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case "4":
                    Console.Write("Enter student ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    var studentToDelete = Student.Find(deleteId);
                    if (studentToDelete != null)
                    {
                        Student.Delete(deleteId);
                        Console.WriteLine("Student deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case "5":
                    Console.Write("Enter student ID to find: ");
                    int findId = int.Parse(Console.ReadLine());
                    var foundStudent = Student.Find(findId);
                    if (foundStudent != null)
                    {
                        Console.WriteLine($"ID: {foundStudent.Id}, Name: {foundStudent.Name}, Password: {foundStudent.Password}");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case "6":
                    Console.Write("Enter student name: ");
                    string loginName = Console.ReadLine();
                    Console.Write("Enter student password: ");
                    string loginPassword = Console.ReadLine();
                    bool isLoggedIn = Student.Login(loginName, loginPassword);
                    if (isLoggedIn)
                    {
                        Console.WriteLine("Login successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid.");
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}