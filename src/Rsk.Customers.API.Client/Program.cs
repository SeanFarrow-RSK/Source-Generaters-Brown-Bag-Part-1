using Microsoft.Extensions.DependencyInjection;

var serviceCollection =new ServiceCollection();
serviceCollection.AddHttpClient<ICustomerService, CustomerService>();
var serviceProvider = serviceCollection.BuildServiceProvider();
var customerService =serviceProvider.GetRequiredService<ICustomerService>();
var customer =await customerService.GetCustomer(1);
Console.ReadKey();