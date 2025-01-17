
namespace StartV2.Trenuuri;

public class Route
{
    private string NameRoute;
    public List<Station> Stations { get; set; }
    public TimeSpan Duration { get; set; }
    public Dictionary<string, decimal> Prices { get; set; } //preturi pt categorii de locuri gen clasa 1 sau clasa 2

    public string nameRoute
    {
        get => NameRoute;
        set=>NameRoute = value;
    }
    public Route(string nameRoute, List<Station> stations, TimeSpan duration, Dictionary<string, decimal> prices)
    {
        NameRoute = nameRoute;
        Stations = stations;
        Duration = duration;
        Prices = prices;
    }

    public void StopTime(TimeSpan Delay)
    {
        foreach (var station in Stations)
        {
            station.ArrivalTime=station.ArrivalTime.Add(Delay);
            station.DepartureTime=station.DepartureTime.Add(Delay);
        }
    }

    public void ShowRouteDetails()
    {
        Console.WriteLine($"Detalii : {NameRoute}");
        Console.WriteLine($"Statii: ");
        foreach (var station in Stations)
        {
            Console.WriteLine(station);
        }

        Console.WriteLine($"Durata totala a calatoriei este: {Duration}");
        Console.WriteLine("Preturi: ");
        foreach (var price in Prices)
        {
            Console.WriteLine($"{price.Key}: {price.Value} lei ");
        }
    }
}