namespace Slot09
{ 
    public class BankAccount 
    {
        public int id;
        public decimal balance;
        public int Id { get; set; } 
        public decimal Balance { get; set; }
        public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int. Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }
    }
}