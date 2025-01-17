namespace StartV2.Trenuuri;

public abstract class Tren
{
    private string ID { get; set; }
    private int Number { get; set; }
    private int Capacity { get; set; }
    private List<Wagon> Wagons { get;  set; } 

    protected Tren(string id, int number, int capacity)
    {
        ID = id;
        Number = number;
        Capacity = capacity;
        Wagons = new List<Wagon>();
    }
    
    public void AddWagon(Wagon wagon)
    {
        Wagons.Add(wagon);
    }
    
    private int CalculateCapacity()
    {
        int totalCapacity = 0;
        foreach (var wagon in Wagons)
        {
            totalCapacity += wagon.SeatsNumber;
        }
        return totalCapacity;
    }

    public abstract double CalculatePrice(double basePrice);
 
}