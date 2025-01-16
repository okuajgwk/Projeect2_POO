namespace StartV2;

public class MeniuPrincipal
{
    public void Cont()
    {
        Console.WriteLine("1. Creare cont");
        Console.WriteLine("2. Log in");
        Console.WriteLine("Alegeți o opțiune: ");

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
                    Console.WriteLine("Opțiune invalidă. Încercați din nou.");
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
        Console.WriteLine("Alegeți o opțiune: ");

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
                    Console.WriteLine("Opțiune invalidă. Încercați din nou.");
                    break;
            }
        }

        static void MeniuUser()
        {
            Console.WriteLine("-----Meniu Utilizator-----");
            Console.WriteLine("1. Cautare ruta");
            Console.WriteLine("2. Cumparati bilet");
            Console.WriteLine("3. Iesire");
            Console.WriteLine("Alegeți o opțiune: ");

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
                        Console.WriteLine("Opțiune invalidă. Încercați din nou.");
                        break;
                }
            }
        }
    }
}