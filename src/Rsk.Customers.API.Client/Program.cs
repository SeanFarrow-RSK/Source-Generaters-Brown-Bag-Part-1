using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Text.Json.Serialization;
using System.Text.Json;
using Rsk.Customers.API.Resources;

var serviceCollection =new ServiceCollection();
serviceCollection.AddRefitClient<ICustomersAPI>()
    .ConfigureHttpClient(c =>c.BaseAddress =new Uri("http://localhost:5111"));
    

var serviceProvider = serviceCollection.BuildServiceProvider();
var customersAPI =serviceProvider.GetRequiredService<ICustomersAPI>();
var customer =await customersAPI.GetCustomer(1);
if (customer is null)
{
    Console.WriteLine("No customer found.");
}
else
{
    Console.WriteLine($"A customer with id {customer.Id} has been found.");
}