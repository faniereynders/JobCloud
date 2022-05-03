using System.Collections.Generic;

namespace JobCloud.Api
{
    public class CompanyCustomer : Customer
    {
        public string RegistrationNumber { get; set; }
        public string VATRegistrationNumber { get; set; }
        public Dictionary<string,string> Directors { get; set; }
        public string ManagerName { get; set; }
    }
}