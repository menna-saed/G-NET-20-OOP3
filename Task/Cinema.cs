namespace AssignmentOOP1;

public class Cinema
{

     private Ticket[] Ticket = new Ticket[20];

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
     }

}