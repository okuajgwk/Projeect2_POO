using StartV2.Useers;

namespace StartV2;

class Program
{
    static void Main(string[] args)
    {
       /* Identif identifService = new Identif();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Meniu Principal ===");
            Console.WriteLine("1. Adauga utilizator");
            Console.WriteLine("2. Listeaza utilizatori");
            Console.WriteLine("3. Verifica autentificare utilizator");
            Console.WriteLine("4. Iesire");
            Console.Write("Alege o optiune: ");

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddUserOption(identifService);
                    break;

                case "2":
                    identifService.ListUsers();
                    break;

                case "3":
                    ValidateUserOption(identifService);
                    break;

                case "4":
                    exit = true;
                    Console.WriteLine("La revedere!");
                    break;

                default:
                    Console.WriteLine("Opțiune invalida. Incearca din nou.");
                    break;
            }
        }
    }

    static void AddUserOption(Identif identifService)
    {
        Console.Write("Introdu nume: ");
        string? firstName = Console.ReadLine();
        
        Console.Write("Introdu prenume: ");
        string? lastName = Console.ReadLine();

        Console.Write("Introdu email: ");
        string? email = Console.ReadLine();

        Console.Write("Introdu parola: ");
        string? password = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(firstName) &&
            !string.IsNullOrWhiteSpace(lastName) &&
            !string.IsNullOrWhiteSpace(email) &&
            !string.IsNullOrWhiteSpace(password))
        {
            identifService.AddUser(lastName, firstName, email, password);
        }
        else
        {
            Console.WriteLine("Toate campurile trebuie completate.");
        }
    }

    static void ValidateUserOption(Identif identifService)
    {
        Console.Write("Introdu email: ");
        string? email = Console.ReadLine();

        Console.Write("Introdu parola: ");
        string? password = Console.ReadLine();

        if (identifService.ValidateUser(email, password))
        {
            Console.WriteLine("Autentificare reușita!");
        }
        else
        {
            Console.WriteLine("Autentificare eșuata. Email sau parola invalida.");
        }*/
    }
}