namespace StartV2.Trenuuri;

public class Reservation
{
    public string IDReservation { get; set; }
    public string User { get; set; }
    public Route ReservedRoute { get; set; }
    public string SeatType { get; set; }
    public int SeatNumber { get; set; }
    public DateTime ReservationDate { get; set; }

    public Reservation(string iDReservation, string user, Route reservedRoute, string seatType, int seatNumber,
        DateTime reservationDate)
    {
        IDReservation = iDReservation;
        User = user;
        ReservedRoute = reservedRoute;
        SeatType = seatType;
        SeatNumber = seatNumber;
        ReservationDate = reservationDate;
    }

    public void ShowReservationDetails()
    {
        Console.WriteLine($"Detalii rezervare(ID: {IDReservation}): ");
        Console.WriteLine($"Utilizator : {User}");
        Console.WriteLine($"Ruta : {ReservedRoute.nameRoute}");
        Console.WriteLine($"Tip de loc: {SeatType}, Numar locuri: {SeatNumber}");
        Console.WriteLine($"Data Rezervarii: {ReservationDate}");
    }

    public string ConfirmationMessage()
    {
        return $"Rezervarea a fost realizata cu succes!ID Rezervare: {IDReservation}";
        
    }

    public string CancelMessage()
    {
        return $"Rezervarea cu ID {IDReservation} a fost anulata.";
    }
}
