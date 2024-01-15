public class Sale
{
    public int Id { get; set; }
    public string Patient { get; set; }
    public string Doctor { get; set; }
    public DateTime Time { get; set; }
    public List<Medicine> Medicines { get; set; } = new List<Medicine>();
}