namespace AssignmentOOP1;

public static class BookingHelper
{

    public  static int counter  { get; set; }
    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double total = numberOfTickets * pricePerTicket; 
        if (numberOfTickets >= 5)
            return total *= 0.9;
        
        return pricePerTicket;

    }

    public static string GenerateBookingReference()
    {
        counter++;
        return "BK-" + counter; 
    }
}