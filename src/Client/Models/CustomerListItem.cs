using System.Text.Json.Serialization;

using System.Collections.Generic;
using JobCloud.Shared.Models;

namespace JobCloud.Client.Models
{
    public class CustomerListItem
    {
        public CustomerType Type { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
    }
}



