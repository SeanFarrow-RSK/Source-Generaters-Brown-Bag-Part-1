using Microsoft.AspNetCore.Mvc;
using Rsk.Customers.API.Resources;

namespace Rsk.Customers.API.Controllers;

[ApiController]
[Route("[controller]")]
public partial class CustomersController : ControllerBase
{
    private readonly ILogger<CustomersController> logger;
    private readonly HashSet<Customer> customers = new(new [] {new Customer(1, "Sean", "Farrow", "17594")});
    
    public CustomersController(ILogger<CustomersController> logger)
    {
        this.logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get(int id)
    {
        LogCustomerRetrievalAttempt(id);
        var customer = customers.FirstOrDefault(x =>x.Id ==id);
        if (customer == null)
        {
LogCustomerRetrievalFailure(id);
            return NotFound(id);
        }

        return Ok(customer);
    }

    [LoggerMessage(0, LogLevel.Debug, "Attempting to retrieve a customer with id {customerID}.")]
    partial void LogCustomerRetrievalAttempt(int customerID);

    [LoggerMessage(1, LogLevel.Debug, "A customer with id {customerID} was not found.")]
    partial void LogCustomerRetrievalFailure(int customerID);
}

