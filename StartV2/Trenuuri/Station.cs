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

    public TimeSpan GetStopDuration()
    {
        return DepartureTime-ArrivalTime;//momentul in care trenul pleaca din statie-cand trenul ajunge in statie;Timespan da ca rezultat exact intervalul de timp in care sta trenul opritt
        //TimeSpan= tip de date care reprez o perioada de timp, diferenta dintre doua mom de timp
    }
}