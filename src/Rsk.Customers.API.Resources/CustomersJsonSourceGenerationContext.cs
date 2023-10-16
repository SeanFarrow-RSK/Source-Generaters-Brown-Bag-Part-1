using System.Text.Json.Serialization;

namespace Rsk.Customers.API.Resources;
#if (!IsClient)
[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata)]
#endif
[JsonSerializable(typeof(Customer))]
public partial class CustomersJsonSourceGenerationContext : JsonSerializerContext
{
}