namespace StartV2.Trenuuri;

public class Wagon
{
    public string WagonType { get; set; }//daca e clasa 1 sau 2 sau restaurant
    public int SeatsNumber { get; set; }

    public Wagon(string wagonType, int seatsNumber)
    {
        WagonType = wagonType;
        SeatsNumber = seatsNumber;
    }

    public override string ToString()
    {
        return $"Tip Vagon:{WagonType},Locuri Disponibile: {SeatsNumber}";
    }
}