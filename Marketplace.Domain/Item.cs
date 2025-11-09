using System.ComponentModel.DataAnnotations;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    public string Name { get; set; }
    
    public List<User> Users { get; set; } = new();
}