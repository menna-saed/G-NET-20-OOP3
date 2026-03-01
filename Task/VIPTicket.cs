namespace AssignmentOOP1;

public class VIPTicket : Ticket
{
    public bool LoungeAccess  { get; set; }
    public decimal ServiceFee { get; set; }

    public VIPTicket(string movieName , decimal Price , bool loungeAccess , decimal serviceFee)
    : base(movieName , Price+50m)
    {
        LoungeAccess = loungeAccess;
        ServiceFee = serviceFee;
    }


    override public string ToString()
    {
        return base.ToString() + $" Lounge Access: {LoungeAccess}, Service Fee: {ServiceFee}"; 
    }
}