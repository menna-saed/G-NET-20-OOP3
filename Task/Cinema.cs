namespace AssignmentOOP1;

public class Cinema
{
   

    /*  private Ticket[] Ticket = new Ticket[20];

     public Ticket? this[int index]
     {
          get
          {
              if (index < 0 || index >= Ticket.Length)
                  return null;
                 
             
              return Ticket[index];
          }

          set
          {   
              if (index >= 0 && index < Ticket.Length)
                  Ticket[index] = value;
               
          }
     }

     public Ticket? GetTicketByMovie(string movieName)
     {
         foreach (var item in Ticket)
         {
             return item;
         }
         return null;
     }

     public bool AddTicket(Ticket t)
     {

         int index = 0;
         foreach (var item in Ticket)
         {
             if (item == null)
             {
                 Ticket[index] = t;
                 return true;
             }

             index++;
         }

         return false;
     }*/

   public string  cinemaName  { get; set; }
   public Projector projector { get; set; }

   private Ticket[] _tickets = new Ticket[20];
   private int counter = 0;

   public Cinema(string cinemaName  ,string name)
   {
       this.cinemaName = cinemaName;
       projector = new Projector(name); 
   }

   public void AddTicket(Ticket ticket)
   {
       if (counter < 20 )
       {
           _tickets[counter] = ticket;
           counter++;
          
       }
       else
       {
           Console.WriteLine("Cinema is full. Cannot add more tickets.");

       }
   }

   public void PrintAllTickets()
   {
       foreach (var  ticket in _tickets)
       {
           if (ticket != null)
           {
               ticket.PrintTicket();
           }
       }
   }

   public static void ProcessTicket(Ticket ticket)
   {
       
       ticket.PrintTicket();
   }
   
}