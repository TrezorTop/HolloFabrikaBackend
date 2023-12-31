namespace HolloFabrika.Api.Contracts.Response;

public class CategoryResponse
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required ICollection<AttributeResponse> Attributes { get; set; }
}