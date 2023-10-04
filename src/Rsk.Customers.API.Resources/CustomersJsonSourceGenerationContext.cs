using System.Text.Json.Serialization;

namespace Rsk.Customers.API.Resources;

[JsonSerializable(typeof(Customer))]
public partial class CustomersJsonSourceGenerationContext : JsonSerializerContext
{
}