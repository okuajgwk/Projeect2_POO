namespace StartV2.Useers;

public class Client : User
{
    public Client(string userLastName, string userFirstName, string email, string password, string userType) : base(userLastName, userFirstName, email, password, userType)
    {
    }
}