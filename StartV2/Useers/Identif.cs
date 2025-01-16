using System.Text.Json; 
using System.IO;
using StartV2.Useers;

namespace StartV2.Users;

public class Identif
{
    private const string FilePath = "users.json";
    private const string AdminDomain = "@admin.com"; 
    private List<User> users;
    
    public Identif()
    {
        users = new List<User>();
        LoadUsers();
    }
    
    private void LoadUsers()
    {
        Console.WriteLine("Încercăm să încărcăm utilizatorii din fișier...");
        try
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                Console.WriteLine($"JSON citit: {json}");
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
                Console.WriteLine("Utilizatorii au fost încărcați cu succes.");
            }
            else
            {
                Console.WriteLine("Fișierul nu există. Lista de utilizatori este goală.");
                users = new List<User>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la încărcare: {ex.Message}");
            users = new List<User>();
        }
    }
    
    private void SaveUsersToFile()
    {
        try
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Utilizatorii au fost salvați cu succes în fișier.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la salvarea utilizatorilor: {ex.Message}");
        }
    }
    
    public void AddUser(string email, string password, string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
        {
            Console.WriteLine("Emailul este gol sau nu are un format valid.");
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Parola nu poate fi goală.");
            return;
        }

        if (users.Exists(u => u.email.Equals(email, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"Un utilizator cu email-ul {email} există deja în sistem.");
            return;
        }

        
        string userType = email.EndsWith(AdminDomain, StringComparison.OrdinalIgnoreCase) ? "admin" : "user";

        if (userType == "admin")
        {
            Console.WriteLine($"Email-ul {email} aparține domeniului {AdminDomain}. Este adăugat ca 'admin'.");
        }
        else
        {
            Console.WriteLine($"Email-ul {email} nu aparține domeniului {AdminDomain}. Este adăugat ca 'user'.");
        }

       
        users.Add(new User(email, password, firstName, lastName, userType));
        SaveUsersToFile();
        Console.WriteLine($"Utilizatorul cu email-ul {email} a fost adăugat cu succes.");
    }

   
    public void ListUsers()
    {
        if (users.Count == 0)
        {
            Console.WriteLine("Nu există utilizatori în sistem.");
            return;
        }

        Console.WriteLine("Lista utilizatorilor:");
        foreach (var user in users)
        {
            Console.WriteLine($"Email: {user.email}, Tip: {user.userType}, Nume: {user.userFirstName} {user.userLastName}");
        }
    }

  
    private bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}
