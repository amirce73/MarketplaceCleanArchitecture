using System;

namespace Service;

public class UserService : IUserService
{
    private User _user;

    public UserService()
    {
        _user = new User();
    }

    // ورود
    public bool Login(string username, string password)
    {
        if (_user.Username == username && _user.Password == password)
            return true;

        return false;
    }

    // ثبت‌نام با تمام اطلاعات
    public bool SignUp(
        string username,
        string password,
        string confirmPassword,
        string email,
        string phone,
        string address,
        string firstname,
        string fullname)
    {
        if (password != confirmPassword) return false;

        _user.Username = username;
        _user.Password = password;
        _user.Email = email;
        _user.Phone = phone;
        _user.Address = address;
        _user.Firstname = firstname;
        _user.Fullname = fullname;

        return true;
    }

    // تغییر اطلاعات کاربر
    public bool ChangeInfo(
        string username,
        string password,
        string email,
        string phone,
        string address,
        string firstname,
        string fullname)
    {
        if (IsChange(username)) _user.Username = username;
        if (IsChange(password)) _user.Password = password;
        if (IsChange(email)) _user.Email = email;
        if (IsChange(phone)) _user.Phone = phone;
        if (IsChange(address)) _user.Address = address;
        if (IsChange(firstname)) _user.Firstname = firstname;
        if (IsChange(fullname)) _user.Fullname = fullname;

        return true;
    }

    // دسترسی به کاربر فعلی
    public User GetUser()
    {
        return _user;
    }

    
    // متد کمکی برای بررسی تغییر
    private bool IsChange(string info)
    {
        return !string.IsNullOrEmpty(info);
    }
}
