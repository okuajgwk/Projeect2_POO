namespace StartV2.Trenuuri;

public class Regio : Tren
{
    public Regio(string id, int number, int capacity) : base(id, number, capacity)
    {
    }

    public override double CalculatePrice(double basePrice)
    {
        return basePrice * 0.8; 
    }
}