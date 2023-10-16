using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Text.Json.Serialization;
using System.Text.Json;
using Rsk.Customers.API.Resources;

var serviceCollection =new ServiceCollection();
var options = new JsonSerializerOptions();
options.AddContext<CustomersJsonSourceGenerationContext>();
serviceCollection.AddRefitClient<ICustomersAPI>(new RefitSettings
{
        ContentSerializer = new SystemTextJsonContentSerializer(options)
})
    .ConfigureHttpClient(c =>c.BaseAddress =new Uri("http://localhost:5111"));
    

var serviceProvider = serviceCollection.BuildServiceProvider();
var customersAPI =serviceProvider.GetRequiredService<ICustomersAPI>();
var customer =await customersAPI.GetCustomer(1);
Console.ReadKey();