using JobCloud.Shared.Models;

namespace JobCloud.Client.Models
{
    public class CustomerForm
    {
        public string Id { get; set; }
        public CustomerType Type { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string PostalAddress { get; set; }
        public string ResidentualAddress { get; set; }
        public List<KeyValuePair<string, string>> ContactDetails => new();
        public string Email { get; set; }
        public string IndividualIDNumber { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string CompanyVATNumber { get; set; }
        public string CompanyManagerName { get; set; }
        public List<KeyValuePair<string, string>> CompanyDirectors => new();

        public CustomerForm()
        {
            
                    
        }

    }
}
