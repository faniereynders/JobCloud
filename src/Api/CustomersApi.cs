using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using JobCloud.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace JobCloud.Api
{

    public class Customers
    {
        private readonly ILogger<Customers> _logger;
        private readonly ICustomerRepository _customerRepository;

        public Customers(ILogger<Customers> log, ICustomerRepository customerRepository)
        {
            _logger = log;
            _customerRepository = customerRepository;
        }


        [FunctionName(nameof(GetCustomers))]
        [OpenApiOperation(operationId: "Run", tags: new[] { "name" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiParameter(name: "name", In = ParameterLocation.Query, Required = true, Type = typeof(string), Description = "The **Name** parameter")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public async Task<IActionResult> GetCustomers(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "customers")] HttpRequest req)
        {
            var customers = await _customerRepository.GetCustomersAsync();

            var result = new CustomerListDto
            {
                Items = customers.Select(c => new CustomerListItemDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Type = (CustomerType)Enum.Parse(typeof(CustomerType), c.GetType().Name),
                    AccountNumber = c.AccountNumber,
                    Telephone1 = c.Telephone1,
                    Telephone2 = c.Telephone2,
                    Mobile = c.Mobile,
                    EMail = c.EMail
                }).ToList()
            };


            return new OkObjectResult(result);
        }
    }
}

