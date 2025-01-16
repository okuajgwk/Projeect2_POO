namespace StartV2.Trenuuri;

public class Reservation
{
    public Route Route { get; set; }
    public List<string> SeatNr { get; set; }=new List<string>();
    public DateTime ReservationTime { get; set; }

    public Reservation(Route route, List<string> seatNr)
    {
        Route = route;
        SeatNr = seatNr;
        ReservationTime = DateTime.Now;//folosesc datetime.now ca sa setez momentul rezervarii
    }

  /*  public bool CancelReservation()
    {
        return (Route.Station[0].DepartureTime - DateTime.Now).TotalHours >= 24;
        //prin linia asta verific daca ora de plecare a trenului din prima statie este >= 24h mai tarziu decat momentul curent 
        
    }*/
}
