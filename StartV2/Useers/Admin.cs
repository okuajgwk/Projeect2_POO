namespace StartV2.Useers;

public class Admin : User
{
    public Admin(string userLastName, string userFirstName, string email, string password, string userType) : base(userLastName, userFirstName, email, password, userType)
    {
    }
}

