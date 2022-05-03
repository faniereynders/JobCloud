using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobCloud.Api
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync(int top = 10, int skip = 0);
        Task<Customer> GetCustomerAsync(string customerId);
        Task<Customer> CreateCustomerAsync(Customer customer);
        Task<Customer> UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(string customerId);
    }
}

