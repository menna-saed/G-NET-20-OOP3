namespace AssignmentOOP1;

public class IMAXTicket : Ticket
{
    public bool Is3D  { get; set; }




    public IMAXTicket(string movieName , decimal Price , bool is3D )
        :base(movieName ,  is3D ? Price + 30m : Price )

    {
        Is3D = is3D;
    }
    
    public override string ToString()
    {
        return base.ToString() +
               $", Type: IMAX, 3D: {Is3D}";
    }
}

