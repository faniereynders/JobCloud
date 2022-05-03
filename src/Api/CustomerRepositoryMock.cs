using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCloud.Api
{
    internal class CustomerRepositoryMock : ICustomerRepository
    {
        public Task<Customer> CreateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetCustomersAsync(int top = 10, int skip = 0)
        {
            var random = new Random(100000);
            var items = new List<Customer>();
            
            for (int i = 1; i < 11; i++)
            {
                var rndInt = random.Next();
                if (rndInt % 2 == 0)
                {
                    items.Add(new IndividualCustomer
                    {
                        AccountNumber = i.ToString(),
                        Id = i.ToString(),
                        IdentificationNumber = random.Next().ToString(),
                        EMail = $"customer{i}@email.com",
                        Name = $"Customer{i}",
                        Telephone1 = random.Next().ToString(),
                        Telephone2 = random.Next().ToString(),
                        Mobile = random.Next().ToString()
                    });
                }
                else
                {
                    items.Add(new CompanyCustomer
                    {
                        AccountNumber = i.ToString(),
                        Id = i.ToString(),
                        RegistrationNumber = random.Next().ToString(),
                        VATRegistrationNumber = random.Next().ToString(),
                        EMail = $"customer{i}@email.com",
                        Name = $"Customer{i}",
                        Telephone1 = random.Next().ToString(),
                        Telephone2 = random.Next().ToString(),
                        Mobile = random.Next().ToString(),
                        ManagerName = $"Manager{i}"
                    });
                }

                
                
            }
            return Task.FromResult(items.AsEnumerable());

        }

        public Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
