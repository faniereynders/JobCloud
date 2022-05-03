namespace JobCloud.Shared.Models
{
    public class CustomerListItemDto
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public CustomerType Type { get; set; }
        
        public string Name { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
    }
}
