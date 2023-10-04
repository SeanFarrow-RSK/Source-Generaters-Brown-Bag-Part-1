using Rsk.Customers.API.Resources;

public interface ICustomerService
{
    Task<Customer> GetCustomer(int id);
}