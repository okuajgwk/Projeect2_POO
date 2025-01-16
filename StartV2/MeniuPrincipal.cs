using StartV2.Useers;

namespace StartV2;

public class MeniuPrincipal
{
    private Identif identif = new Identif();
    public void Cont()
    {
        Console.WriteLine("1. Creare cont");
        Console.WriteLine("2. Log in");
        Console.WriteLine("Alegeti o optiune: ");

        MeniuPrincipal meniuprincipal = new MeniuPrincipal();
        string opt1 = Console.ReadLine();
        bool running = true;
        while (running)
        {
            switch (opt1)
            {
                case "1":
                    Console.WriteLine("1. Creare cont");
                    break;
                case "2":
                    Console.WriteLine("2. Log in");
                    break;
                case "3":
                    Console.WriteLine("Iesire");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incercati din nou.");
                    break;
            }
        }
    }

    public void CreareCont(string args)
    {
        Console.WriteLine("-----Sistem de gestionare utilizatori-----");
        bool running = true;
        while (running)
        {

            Console.WriteLine("1. Adaugare utilizator");
            Console.WriteLine("2. Listare utilizatori");
            Console.WriteLine("Iesire");
            Console.WriteLine("Alegeti o optiune: ");
            
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adaugare utilizator:");
                    Console.Write("Email: "); 
                    string email = Console.ReadLine();
                    Console.Write("Parolă: ");
                    string password = Console.ReadLine();
                    Console.Write("Prenume: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Nume: ");
                    string lastName = Console.ReadLine();

                    Identif.AddUser(lastName, firstName, email, password);
                    break;

                case "2":
                    Identif.ListUsers();
                    break;

                case "3":
                    running = false;
                    Console.WriteLine("La revedere!");
                    break;

                default:
                    Console.WriteLine("Opțiune invalida.");
                    break;
            }
        }
    }

    public void MeniuAdmin()
    {
        Console.WriteLine("-----Meniu Administrator-----");
        Console.WriteLine("1. Adaugare ruta");
        Console.WriteLine("2. Modificare ruta");
        Console.WriteLine("3. Stergere ruta");
        Console.WriteLine("4. Gestionare trenuri");
        Console.WriteLine("5. Semnalare intarziere");
        Console.WriteLine("6. Iesire");
        Console.WriteLine("Alegeti o optiune: ");

        string opt2 = Console.ReadLine();
        bool running = true;
        while (running)
        {
            switch (opt2)
            {
                case "1":
                    Console.WriteLine("1. Adaugare ruta");
                    break;
                case "2":
                    Console.WriteLine("2. Modificare ruta");
                    break;
                case "3":
                    Console.WriteLine("3. Stergere ruta");
                    break;
                case "4":
                    Console.WriteLine("4. Gestionare trenuri");
                    break;
                case "5":
                    Console.WriteLine("5. Semnalare intarziere");
                    break;
                case "6":
                    Console.WriteLine("Iesire");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incercati din nou.");
                    break;
            }
        }

        static void MeniuUser()
        {
            Console.WriteLine("-----Meniu Utilizator-----");
            Console.WriteLine("1. Cautare ruta");
            Console.WriteLine("2. Cumparati bilet");
            Console.WriteLine("3. Iesire");
            Console.WriteLine("Alegeti o optiune: ");

            string opt2 = Console.ReadLine();
            bool running = true;
            while (running)
            {
                switch (opt2)
                {
                    case "1":
                        Console.WriteLine("1. Cautare ruta");
                        break;
                    case "2":
                        Console.WriteLine("2. Cumparati bilet");
                        break;
                    case "3":
                        Console.WriteLine("3. Iesire");
                        break;
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida. Incercati din nou.");
                        break;
                }
            }
        }
    }
}