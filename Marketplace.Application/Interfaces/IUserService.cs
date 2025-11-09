
namespace Service;

public interface IUserService
{
    public bool Login(string username, string password);
    
    public bool SignUp(string username, string password);
}