namespace JobCloud.Api
{
    public abstract class Customer
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string PostalAddress { get; set; }
        public string ResidentualAddress { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
    }
}