namespace StartV2.Trenuuri;

public class Station
{
    public string Name { get; set; }
    public DateTime ArrivalTime { get; set; }
    public DateTime DepartureTime { get; set; }//tipul de data DateTime ma ajuta sa stochez data si ora (an luna zi ora minute sec)

    public Station(string name, DateTime arrivalTime, DateTime departureTime)
    {
        Name = name;
        ArrivalTime = arrivalTime;
        DepartureTime = departureTime;
    }
}