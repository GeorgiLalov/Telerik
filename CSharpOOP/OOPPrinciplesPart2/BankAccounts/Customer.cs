namespace BankAccounts
{
    public class Customer
    {
        public string Name { get; private set; }
        public CustomerType Type { get; private set; }

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{this.Name}\t{this.Type}";
        }
    }
}
