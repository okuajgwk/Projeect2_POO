namespace StartV2.Trenuuri;

public class Rute
{
    private string NameRoute { get; set; }
    private List<string> StationList { get; set; } = new List<string>();
    private int ScheduleStation { get; set; }

    public Rute(string nameRoute, int scheduleStation)
    {
        NameRoute = nameRoute;
        ScheduleStation = scheduleStation;
        
    }
    
}