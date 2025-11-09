namespace MarketplaceCleanArchitecture.Domain.Entities;

public class Electronic : Item
{
    public string Brand { get; set; } = string.Empty;
    public int WarrantyMonths { get; set; }
}
