namespace StartV2.Trenuuri;

public class IstoricCalatorii
{
    private const string FolderIstoric = "IstoricCalatorii";

    public IstoricCalatorii()
    {
        if (!Directory.Exists(FolderIstoric))
        {
            Directory.CreateDirectory(FolderIstoric);
        }
    }
    
    private string GetFileNameFromHelper(string email)
    {
        return Helper.GetFileName(email);
    }
    
     public void AddToHistory(string email, string routeName, DateTime travelDate, decimal price, string seatType)
    {
        string fileName = GetFileName(email);
        string historyEntry = $"Data: {travelDate:yyyy-MM-dd HH:mm} | Ruta: {routeName} | Pret: {price} lei | Tip loc: {seatType}";

        using (StreamWriter writer = new StreamWriter(fileName, append: true))
        {
            writer.WriteLine(historyEntry);
        }

        Console.WriteLine("Calatoria a fost adăugata in istoricul utilizatorului.");
    }
    public void ViewHistory(string email)
    {
        string fileName = GetFileName(email);

        if (File.Exists(fileName))
        {
            Console.WriteLine($"----- Istoric Călătorii pentru {email} -----");
            string[] historyEntries = File.ReadAllLines(fileName);

            foreach (string entry in historyEntries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("Nu există istoric pentru acest utilizator.");
        }
    }
}