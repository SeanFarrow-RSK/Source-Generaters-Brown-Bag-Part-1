using Refit;
using Rsk.Customers.API.Resources;

public interface ICustomersAPI
{
    [Get("/customers")]
    Task<Customer> GetCustomer(int id);
}