class Program
{
    static void Main(string[] args)
    {
        DataManager dataManager = new DataManager();

        // Example: Adding a new medicine
        Medicine newMedicine = new Medicine
        {
            Id = 1,
            Name = "Aspirin",
            Indication = "Pain relief",
            Ingredients = "Acetylsalicylic acid",
            Description = "Common painkiller",
            Quantity = 100
        };

        dataManager.AddMedicine(newMedicine);

        // Example: Adding a new sale
        Sale newSale = new Sale
        {
            Id = 1,
            Patient = "John Doe",
            Doctor = "Dr. Smith",
            Time = DateTime.Now,
            Medicines = new List<Medicine> { newMedicine },
        };

        dataManager.AddSale(newSale);

        // Implement console UI for user interaction and menu options
        // For example, display options for adding/updating/deleting medicines and sales
        // Display options for generating reports

        Console.WriteLine("Application started...");
        // Add your console UI logic here

        // Example: Displaying the current state of medicines
        Console.WriteLine("Medicines in Store:");
        foreach (var medicine in dataManager.Medicines)
        {
            Console.WriteLine($"{medicine.Id} - {medicine.Name} - Quantity: {medicine.Quantity}");
        }

        // Example: Displaying all sales
        Console.WriteLine("All Sales:");
        foreach (var sale in dataManager.Sales)
        {
            Console.WriteLine($"{sale.Id} - {sale.Patient} - Doctor: {sale.Doctor} - Time: {sale.Time}");
        }

        // Add more functionality and user interaction as needed

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
