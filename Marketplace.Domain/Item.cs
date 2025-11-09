using System.ComponentModel.DataAnnotations;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public List<User> Users { get; set; } = new();

    public virtual void Buy(int quantity)
    {
        if (Stock < quantity)
            throw new InvalidOperationException("Not enough stock.");
        Stock -= quantity;
    }
}