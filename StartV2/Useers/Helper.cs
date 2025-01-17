namespace StartV2.Useers;

public class Helper
{
    public static string GetFileName(string email)
    {
        string sanitizedEmail = email.Replace("@", "_").Replace(".", "_");
        return Path.Combine("TravelHistory", $"istoric_{sanitizedEmail}.txt");
    }
}