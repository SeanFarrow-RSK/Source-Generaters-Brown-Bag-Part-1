namespace Rsk.Customers.API.Resources;

public class Customer
{
    public int Id { get; }
    public string Forename { get; }
    public string Surname { get; }
    public string AccountNumber { get; }

    public Customer(int id, string forename, string surname, string accountNumber)
    {
        Id = id;
        Forename = forename;
        Surname = surname;
        AccountNumber = accountNumber;
    }
}