using System;

namespace CrudExample
{
    class Program
    {
        static void Main()
        {
            var customerCrud = new CurdTest<Customer>();
            var studentCrud = new CurdTest<Student>();
            var productCrud = new CurdTest<Product>();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display Items");
                Console.WriteLine("3. Update Item");
                Console.WriteLine("4. Delete Item");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choose type: 1. Customer, 2. Student, 3. Product");
                        int typeChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter data:");
                        switch (typeChoice)
                        {
                            case 1:
                                customerCrud.AddItem(new Customer { Id = 12334, Name = Console.ReadLine() });
                                break;
                            case 2:
                                studentCrud.AddItem(new Student { Id = 10239, StudentName = Console.ReadLine() });
                                break;
                            case 3:
                                productCrud.AddItem(new Product { Id = 532301, ProductName = Console.ReadLine() });
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Choose type: 1. Customer, 2. Student, 3. Product");
                        int displayChoice = int.Parse(Console.ReadLine());
                        switch (displayChoice)
                        {
                            case 1:
                                customerCrud.DisplayItems();
                                break;
                            case 2:
                                studentCrud.DisplayItems();
                                break;
                            case 3:
                                productCrud.DisplayItems();
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Choose type: 1. Customer, 2. Student, 3. Product");
                        int updateChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter index to update:");
                        int updateIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter updated data:");
                        switch (updateChoice)
                        {
                            case 1:
                                customerCrud.UpdateItem(updateIndex, new Customer { Id = 1, Name = Console.ReadLine() });
                                break;
                            case 2:
                                studentCrud.UpdateItem(updateIndex, new Student { Id = 101, StudentName = Console.ReadLine() });
                                break;
                            case 3:
                                productCrud.UpdateItem(updateIndex, new Product { Id = 501, ProductName = Console.ReadLine() });
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Choose type: 1. Customer, 2. Student, 3. Product");
                        int deleteChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter index to delete:");
                        int deleteIndex = int.Parse(Console.ReadLine());
                        switch (deleteChoice)
                        {
                            case 1:
                                customerCrud.DeleteItem(deleteIndex);
                                break;
                            case 2:
                                studentCrud.DeleteItem(deleteIndex);
                                break;
                            case 3:
                                productCrud.DeleteItem(deleteIndex);
                                break;
                        }
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}