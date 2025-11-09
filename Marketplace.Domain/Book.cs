namespace MarketplaceCleanArchitecture.Domain.Entities;

public class Book : Item
{
    public string Author { get; set; } = string.Empty;
    public int Pages { get; set; }
}
