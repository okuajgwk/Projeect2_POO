namespace StartV2.Trenuuri;

public class Route
{
    private string NameRoute { get; set; }
    private List<string> StationList { get; set; } = new List<string>();
    private int ScheduleStation { get; set; }
    private Tren TrenRoute { get; set; }
    private decimal BasePrice { get; set; }
    public object Station { get; set; }

    public Route(string nameRoute, decimal basePrice, Tren trenRoute)
    {
        NameRoute = nameRoute;
        BasePrice = basePrice;
        TrenRoute = trenRoute;
    }

    public void AddStation(Station station)
    {
        StationList.Add(station.Name);
        
    }
    
}

