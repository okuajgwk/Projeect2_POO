namespace StartV2;

public class MeniuPrincipal
{
    public void Cont(int opt1, int opt2)
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
    
    public void MeniuAdmin(int opt2)
    {
        Console.WriteLine("-----Meniu Administrator-----");
        Console.WriteLine("1. Adaugare ruta");
        Console.WriteLine("2. Modificare ruta");
        Console.WriteLine("3. Stergere ruta");
        Console.WriteLine("4. Gestionare trenuri");
        Console.WriteLine("5. Semnalare intarziere");
        Console.WriteLine("Alegeți o opțiune: ");
        
        
    }
    
    public void MeniuUser(int opt2)
    {
        Console.WriteLine("-----Meniu Utilizator-----");
        Console.WriteLine("1. Cautare ruta");
        Console.WriteLine("2. Cumparati bilet");
        Console.WriteLine("3. Iesire");
        Console.WriteLine("Alegeți o opțiune: ");
        
    }
    
    

}