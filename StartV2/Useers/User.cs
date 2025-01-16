using System.Security.AccessControl;

namespace StartV2.Useers;

public class User
{
    private string UserLastName;
    private string UserFirstName;
    private string Email;
    private string Password;
    private string UserType;

    public User(string userLastName, string userFirstName, string email, string password, string userType)
    {
        UserLastName = userLastName;
        UserFirstName = userFirstName;
        Email = email;
        Password = password;
        UserType = userType;
    }

    public string userLastName
    {
        get => UserLastName; 
        set => UserLastName = value;
    }

    public string userFirstName
    {
        get => UserFirstName;
        set => UserFirstName = value;
    }

    public string email
    {
        get => Email;
        set => Email = value;
    }

    public string password
    {
        get => Password;
        set => Password = value;
    }

    public string userType
    {
        get => UserType;
        set => UserType = value;
    }
    
}