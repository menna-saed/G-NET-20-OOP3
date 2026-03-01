using System.Diagnostics.Metrics;

namespace AssignmentOOP1;

public class Ticket 
{
 

    /*
    public string MovieName { get; set; }
    public TicketType Type { get; set; }
    public Seat Seat { get; set; }
    public double Price { get; set; }
    private double total { get; set; } 
    private static int ticketCounter = 0; 
    public int TicketId { get; private set; } 
    
    
    public string CheckName
    {
        get
        {
            
            return MovieName;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                MovieName = value;
        }
    }

    
    public double CheckPrice
    {
        get
        {
            return Price;
        }
        set
        {
            if (value > 0)
                Price = value;
        }
    }
    public double PriceAfterTax => Price * 1.14; 
    
    public Ticket(string movieName, TicketType type, Seat seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
        this.total = total;
        TicketId = ticketCounter;
        ticketCounter++;    
    }
    
    public Ticket (string movieName) : this(movieName, TicketType.Standard, new Seat('A', 1), 10.0)
    {
        
    }

    public double CalcTotal(double taxPercent)
    {

        this.total = Price + (Price * taxPercent / 100); 
        return total;
    }
    public void ApplyDiscount( double discountAmount )
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price -= discountAmount;
            discountAmount = 0;
        }
        
    }

    public void PrintTicket()
    {
       
        Console.WriteLine("Movie: " + MovieName);
        Console.WriteLine("Type: " + Type);
        Console.WriteLine("Seat: " + Seat.Row + Seat.Number);
        Console.WriteLine("Price: " + Price);

    }
    
    public static int GetTotalTicketsSold()
    {
        return ticketCounter;
    }
    */

    public string  movieName { get; set; }
    public Decimal  Price  { get; private set; }
   public readonly int  TicketID ;
   private static int counter = 0;


    public Decimal CheckPrice
    {
        get
        {
            return Price;
        }
        set
        {
            if (value > 0)
            {
                Price = value;

            }
        }
        
    }
    public Ticket(string movieName, decimal price)
    {
        this.movieName = movieName;
        Price = price;

        counter++;
        TicketID = counter; 
    }

    public decimal PriceAfterTax() => Price * 14 / 100;

    public override string ToString()
    {
        return $"movieName : {movieName} , price :{Price} ,  ticketID :{TicketID}";
    }

    public static int GetTotalTickets() => counter;
}