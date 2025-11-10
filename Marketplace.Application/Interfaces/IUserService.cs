
namespace Service;

public interface IUserService
{


    public bool Login(string username, string password);

    public bool SignUp(
        string username,
        string password,
        string confirmPassword,
        string email,
        string phone,
        string address,
        string firstname,
        string fullname
        );

    public bool ChangeInfo(
        string username,
        string password,
        string email,
        string phone,
        string address,
        string firstname,
        string fullname
    );

    public User GetUser();

}