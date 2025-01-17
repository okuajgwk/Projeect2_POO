using StartV2.Useers;

namespace StartV2;

public class MeniuPrincipal
{
    private Identif identif = new Identif(); // Instanță pentru gestionarea utilizatorilor.

    public void Cont()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("--- Meniu Principal ---");
            Console.WriteLine("1. Creare cont");
            Console.WriteLine("2. Log in");
            Console.WriteLine("3. Iesire");
            Console.WriteLine("Alegeti o optiune: ");
            
            string opt1 = Console.ReadLine();

            switch (opt1)
            {
                case "1":
                    CreareCont();
                    break;
                case "2":
                    LogIn();
                    break;
                case "3":
                    Console.WriteLine("Iesire... La revedere!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incercati din nou!");
                    break;
            }
        }
    }

    public void CreareCont()
    {
        Console.WriteLine("----- Creare Cont -----");
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Parolă: ");
        string password = Console.ReadLine();

        Console.Write("Prenume: ");
        string firstName = Console.ReadLine();

        Console.Write("Nume: ");
        string lastName = Console.ReadLine();

        identif.AddUser(lastName, firstName, email, password);
        Console.WriteLine("Cont creat cu succes!");
    }

    public void LogIn()
    {
        Console.WriteLine("----- Log In -----");
        Console.Write("Introduceți email-ul: ");
        string email = Console.ReadLine();

        Console.Write("Introduceți parola: ");
        string password = Console.ReadLine();

        if (identif.ValidateUser(email, password))
        {
            Console.WriteLine("Autentificare reușită!");
            if (email.EndsWith("@admin.com", StringComparison.OrdinalIgnoreCase))
            {
                MeniuAdmin();
            }
            else
            {
                MeniuUser();
            }
        }
        else
        {
            Console.WriteLine("Autentificare eșuată. Email sau parolă incorecte.");
        }
    }

    public void MeniuAdmin()
    {
        bool adminRunning = true;

        while (adminRunning)
        {
            Console.WriteLine("----- Meniu Administrator -----");
            Console.WriteLine("1. Adaugare ruta");
            Console.WriteLine("2. Modificare ruta");
            Console.WriteLine("3. Stergere ruta");
            Console.WriteLine("4. Gestionare trenuri");
            Console.WriteLine("5. Semnalare intarziere");
            Console.WriteLine("6. Iesire");
            Console.WriteLine("Alegeti o optiune: ");

            string opt2 = Console.ReadLine();

            switch (opt2)
            {
                case "1":
                    Console.WriteLine("Adaugare ruta...");
                    break;
                case "2":
                    Console.WriteLine("Modificare ruta...");
                    break;
                case "3":
                    Console.WriteLine("Stergere ruta...");
                    break;
                case "4":
                    Console.WriteLine("Gestionare trenuri...");
                    break;
                case "5":
                    Console.WriteLine("Semnalare intarziere...");
                    break;
                case "6":
                    Console.WriteLine("Iesire din Meniu Administrator.");
                    adminRunning = false;
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incercati din nou.");
                    break;
            }
        }
    }

    public void MeniuUser()
    {
        bool userRunning = true;

        while (userRunning)
        {
            Console.WriteLine("----- Meniu Utilizator -----");
            Console.WriteLine("1. Cautare ruta");
            Console.WriteLine("2. Cumparati bilet");
            Console.WriteLine("3. Iesire");
            Console.WriteLine("Alegeti o optiune: ");

            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Console.WriteLine("Cautare ruta...");
                    break;
                case "2":
                    Console.WriteLine("Cumparati bilet...");
                    break;
                case "3":
                    Console.WriteLine("Iesire din Meniu Utilizator.");
                    userRunning = false;
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incercati din nou.");
                    break;
            }
        }
    }
}