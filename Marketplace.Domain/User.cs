using System.ComponentModel.DataAnnotations;


public class User
{
    
    [Key]
    public int UserId { get; set; }
    public string Username { set; get; } = string.Empty;
    public string Password { set; get; } = string.Empty;
    public string Email { set; get; } = string.Empty;

    public string Phone { set; get; } = string.Empty;

    public string Address { set; get; } = string.Empty;

    public string Firstname { set; get; } = string.Empty;

    public string Fullname { set; get; } = string.Empty;

    public List<Item> Items { get; set; } = new();
    

}