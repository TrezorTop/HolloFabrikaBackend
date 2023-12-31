namespace HolloFabrika.Feature.Entities;

public class Category
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();
}

public static class CategoryConstants
{
    public const int NameMaxLength = 128;
}