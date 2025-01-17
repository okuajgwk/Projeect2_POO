namespace StartV2.Trenuuri;

public class InterRegio: Tren
{
    public InterRegio(string id, int number, int capacity) : base(id, number, capacity)
    {
        
    }
    public override double CalculatePrice(double basePrice)
    {
        return basePrice; 
    }
    
}