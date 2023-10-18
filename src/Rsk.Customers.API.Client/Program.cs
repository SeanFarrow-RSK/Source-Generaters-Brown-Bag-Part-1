using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var serviceCollection =new ServiceCollection();
serviceCollection.AddHttpClient<ICustomerService, CustomerService>();
var serviceProvider = serviceCollection.BuildServiceProvider();
var customerService =serviceProvider.GetRequiredService<ICustomerService>();
var customer =await customerService.GetCustomer(1);
if (customer is null)
{
    Console.WriteLine("No customer found.");
}
else
{
        Console.WriteLine($"A customer with id {customer.Id} has been found.");
}