using System.Text.Json.Serialization;

using System.Collections.Generic;
namespace JobCloud.Client.Models
{
    public class CustomerListItem
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
    }
}



