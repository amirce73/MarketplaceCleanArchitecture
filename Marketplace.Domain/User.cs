using System.ComponentModel.DataAnnotations;


public class User
{
    
    [Key]
    public int UserId { get; set; }
    public string Username { set; get; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsAdmin { get; set; }
    public List<Item> Items { get; set; } = new();
    
        public void UpdateInfo(string email)
    {
        Email = email;
    }

    public bool CheckPassword(string password) => Password == password;

}