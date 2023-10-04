using Rsk.Customers.API.Resources;
using System.Net.Http.Json;

public class CustomerService : ICustomerService
{
    private HttpClient client;

    public CustomerService(HttpClient client)
    {
        this.client = client;
    }

    public async Task<Customer> GetCustomer(int id)
    {
        var customerUri = $"http://localhost:5111/customers?id={id}";
        try
        {
            return await client.GetFromJsonAsync<Customer>(customerUri);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}