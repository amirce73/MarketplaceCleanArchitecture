using System.ComponentModel.DataAnnotations;


public class User
{
    
    [Key]
    public int UserId { get; set; }
    public string Username { set; get; }

    public List<Item> Items { get; set; } = new();
    

}