namespace Eventbrite.Models
{
    public class Event
    {
        public  Guid Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string Location { get; set; }
         
        public int Capacity { get; set; }

        public int TicketAmount { get; set; }

        public DateTime Date { get; set; }

        //public int UserId { get; set; }

        //public User User { get; set; }
        public List<User> Users { get; set; }=new List<User>();
        
    }
}
