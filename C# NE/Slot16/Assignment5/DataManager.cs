public class DataManager
{
    public List<Medicine> Medicines { get; set; } = new List<Medicine>();
    public List<Sale> Sales { get; set; } = new List<Sale>();

    // Implement methods for adding, updating, and deleting medicines and sales
    // You can also implement methods for generating reports

    // Example method for adding a new medicine
    public void AddMedicine(Medicine medicine)
    {
        // Add your logic to check for duplicate medicines or other validation
        Medicines.Add(medicine);
    }

    // Example method for adding a new sale
    public void AddSale(Sale sale)
    {
        // Add your logic to validate and process the sale
        Sales.Add(sale);
    }

    // Additional methods for updating and deleting medicines and sales can be added
}
