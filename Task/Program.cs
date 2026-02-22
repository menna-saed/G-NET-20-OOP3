namespace AssignmentOOP1;

class Program
{
    static void Main(string[] args)
    {
        
        
        /*Console.WriteLine("Enter movie name:");
        string ? name = Console.ReadLine();
        
        Console.WriteLine("Enter ticket type (0 for Standard, 1 for Vip, 2 for Imax):");
        TicketType ticketType = (TicketType)int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter seat row: ");
        char row = char.Parse(Console.ReadLine()!);
        
        Console.Write("Enter seat number: ");
        int number = int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine()!);

  
        Console.Write("Enter tax percent: ");
        double tax = double.Parse(Console.ReadLine());

        Console.Write("Enter discount: ");
        double discount = double.Parse(Console.ReadLine());
        
        Seat seat = new Seat(row, number);
        Ticket ticket = new Ticket(name!, ticketType, seat, price);
        
        
        ticket.CalcTotal(tax);
        
        
        Console.WriteLine("\n--- Tickct info ---");
        ticket.PrintTicket();
        Console.WriteLine("Total (14% tax): " + ticket.CalcTotal(tax));
       
        ticket.ApplyDiscount(discount);
        
        Console.WriteLine("\n--- After discount---");
        Console.WriteLine("discount before " + discount);
        Console.WriteLine("discount After "+0);
        ticket.PrintTicket();
        Console.WriteLine("Total (14% tax): " + ticket.CalcTotal(tax));
        
        Console.WriteLine(Ticket.GetTotalTicketsSold());*/
        
      Cinema cinema = new Cinema();
     

        for (int i = 0; i< 3; i++)
        {
            Console.WriteLine("\n--- enter data for 3 tickets---");
            Console.WriteLine("Enter movie name:");
            string ? name = Console.ReadLine();
        
            Console.WriteLine("Enter ticket type (0 for Standard, 1 for Vip, 2 for Imax):");
            TicketType ticketType = (TicketType)int.Parse(Console.ReadLine()!);
        
            Console.Write("Enter seat row: ");
            char row = char.Parse(Console.ReadLine()!);
        
            Console.Write("Enter seat number: ");
            int number = int.Parse(Console.ReadLine()!);
        
            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine()!);
            
            Seat seat = new Seat(row, number);
            Ticket ticket = new Ticket(name, ticketType ,seat, price);
            cinema.AddTicket(ticket);
            Console.WriteLine("\n--- All Tickets ---");
            ticket.PrintTicket();
            
            
        }
        Console.WriteLine("Enter movie name to search:");
        string searchMovie = Console.ReadLine()!;

       var saerchInfo =  cinema.GetTicketByMovie(searchMovie);
       if (saerchInfo != null)
       {
           Console.WriteLine("Found Ticket:");
           Console.WriteLine(saerchInfo.MovieName);
           Console.WriteLine(saerchInfo.Price);
           Console.WriteLine(saerchInfo.Type);
           Console.WriteLine(saerchInfo.TicketId);
           Console.WriteLine(saerchInfo.Seat.Row + saerchInfo.Seat.Number);
       }
       else
       {
           Console.WriteLine("Movie not found.");
       }
       
       Console.WriteLine("\nTotal tickets sold: " + Ticket.GetTotalTicketsSold());
       Console.WriteLine("Booking Reference 1: "+ BookingHelper.GenerateBookingReference() );
       Console.WriteLine("Booking Reference 2: "+ BookingHelper.GenerateBookingReference() );
       
       double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
       Console.WriteLine("Total for 5 tickets with group discount: " + groupTotal);
    }      
    
}