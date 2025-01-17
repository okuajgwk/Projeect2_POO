namespace StartV2.Trenuuri;

public class Express : Tren
{
    public Express(string id, int number, int capacity) : base(id, number, capacity)
    {
    }
    public override double CalculatePrice(double basePrice)
    {
        // trb facuta optiunea pentru restaurant
        return basePrice * 1.5; 
    }
    
}