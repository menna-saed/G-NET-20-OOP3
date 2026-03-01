namespace AssignmentOOP1;

public class Projector
{
    public string Name { get; set; }  
    public Projector(string name)      // constructor
    {
        Name = name;
    }

    public void Start()
    {
        Console.WriteLine($"Cinema  is starting...");
    }

    public void Close()
    {
        Console.WriteLine($"Cinema   is closing....");
        
    }
}