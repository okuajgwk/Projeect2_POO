namespace StartV2.Useers;

public class User
{
    private string UserLastName { get; set; }
    private string UserFirstName { get; set; }
    private string Email { get; set; }
    private string Password { get; set; }
    public string UserType { get; set; }

    public User(string userLastName, string userFirstName, string email, string password, string userType)
    {
        UserLastName = userLastName;
        UserFirstName = userFirstName;
        Email = email;
        Password = password;
        UserType = userType;
    }
    
    
}