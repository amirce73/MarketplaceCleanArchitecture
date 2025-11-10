namespace Service.Interfaces.Repsitoreis;

public interface IUserRepository
{
    public bool AddUserToDataBase(User user);

    public User GetUser();
    public bool UpdateUser(User user);
}