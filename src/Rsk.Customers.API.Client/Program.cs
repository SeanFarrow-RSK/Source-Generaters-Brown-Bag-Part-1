using Microsoft.Extensions.DependencyInjection;
using Refit;

var serviceCollection =new ServiceCollection();
serviceCollection.AddRefitClient<ICustomersAPI>()
    .ConfigureHttpClient(c =>c.BaseAddress =new Uri("http://localhost:5111"));

var serviceProvider = serviceCollection.BuildServiceProvider();
var customersAPI =serviceProvider.GetRequiredService<ICustomersAPI>();
var customer =await customersAPI.GetCustomer(1);
Console.ReadKey();