namespace StartV2.Claase;

public abstract class Tren
{
    private string ID { get; set; }
    private int Number { get; set; }
    private int Capacity { get; set; }
    private List<string> Wagons { get; set; } = new List<string>();

    protected Tren(string id, int number, int capacity)
    {
        ID = id;
        Number = number;
        Capacity = capacity;
    }

    public abstract int CalculatePrice();
 
}