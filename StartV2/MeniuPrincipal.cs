namespace StartV2;

public class MeniuPrincipal
{
    public void Cont(int opt)
    {
        Console.WriteLine("Creare cont administrator");
        Console.WriteLine("Logare administrator");
        Console.WriteLine("Creare cont utilizator");
        Console.WriteLine("Logare utilizator");
        Console.WriteLine("Alegeți o opțiune: ");
    }
    
    public void MeniuAdmin(int opt)
    {
        Console.WriteLine("-----Meniu Administrator-----");
        Console.WriteLine("1. Adaugare ruta");
        Console.WriteLine("2. Modificare ruta");
        Console.WriteLine("3. Stergere ruta");
        Console.WriteLine("4. Gestionare trenuri");
        Console.WriteLine("5. Semnalare intarziere");
        Console.Write("Alegeți o opțiune: ");

    }
    
    public void MeniuUser(int opt)
    {
        Console.WriteLine("-----Meniu Utilizator-----");
        Console.WriteLine("1. Cautare ruta");
        Console.WriteLine("2. Cumparati bilet");
        Console.WriteLine("3. Iesire");
        Console.Write("Alegeți o opțiune: ");
        
    }
    
}