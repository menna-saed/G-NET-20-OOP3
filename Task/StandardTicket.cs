namespace AssignmentOOP1;

public class StandardTicket : Ticket 
{
    public string SeatNumber { get; set; }

    public StandardTicket(string movieName , decimal Price , string seatNumber)
    :base( movieName , Price)
    {
        SeatNumber = seatNumber;
    }


    public override string ToString()
    {
        return base.ToString() + " "  +$"seatNumber: {SeatNumber}";
    }
}