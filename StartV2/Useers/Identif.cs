using System.Text.Json; 
using System.IO;

namespace StartV2.Useers;

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

 
    public void LoadUsers()
    {
        Console.WriteLine("Încercăm să încărcăm utilizatorii din fișier...");
        try
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                Console.WriteLine($"JSON citit: {json}");
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();

                // Validare și eliminare utilizatori incorecți sau incompleți
                users = users.Where(u => u != null && 
                                         !string.IsNullOrEmpty(u.email) && 
                                         !string.IsNullOrEmpty(u.userFirstName) &&
                                         !string.IsNullOrEmpty(u.userLastName) && 
                                         !string.IsNullOrEmpty(u.password))
                    .ToList();

                Console.WriteLine("Utilizatorii au fost încărcați și validați cu succes.");
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

    public void SaveUsersToFile()
    {
        try
        {
            // Verifică și creează directorul dacă lipsește
            string? directoryPath = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrWhiteSpace(directoryPath) && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Scrie lista utilizatorilor în fișierul JSON
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Utilizatorii au fost salvați cu succes în fișier.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la salvarea utilizatorilor: {ex.Message}");
        }
    }

    public void AddUser(string userLastName, string userFirstName, string email, string password)
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

        if (users.Exists(u => u != null && u.email != null && u.email.Equals(email, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"Un utilizator cu email-ul {email} există deja în sistem.");
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

        users.Add(new User(userLastName, userFirstName, email, password, userType)); // Corecție în ordinea parametrilor
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
            Console.WriteLine(
                $"Email: {user.email}, Tip: {user.userType}, Nume: {user.userFirstName} {user.userLastName}");
        }
    }
    
    public bool ValidateUser(string email, string password)
    {
        return users.Any(user => user.email.Equals(email, StringComparison.OrdinalIgnoreCase) && user.password == password);
    }

    public bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}