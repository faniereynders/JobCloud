using JobCloud.Shared.Models;

namespace JobCloud.Client.Models
{
    public class CustomerSearchEntry
    {
        public CustomerType Type { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
    }
}
