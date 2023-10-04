using Microsoft.AspNetCore.Mvc;
using Rsk.Customers.API.Resources;

namespace Rsk.Customers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
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
        logger.LogDebug("Attempting to retrieve a customer with id {customerID}", id);
        var customer = customers.FirstOrDefault(x =>x.Id ==id);
        if (customer == null)
        {
            logger.LogDebug("A customer with id {customerID} was not found.", id);
            return NotFound(id);
        }

        return Ok(customer);
    }
}

