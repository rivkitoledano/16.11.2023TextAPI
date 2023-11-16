namespace RivkiToledano02._11
{
    public class DataContext
    {
        public List<Event> Events { get; set; }
        
         public DataContext()
        {
            Events = new List<Event>{
            new Event { Id = Event.Count, Title = "yael", Start=new DateTime() },
            new Event { Id = Event.Count, Title = "rut",  Start=new DateTime(2023,11,26) },
            new Event { Id = Event.Count, Title = "dvora",Start=new DateTime(2023,11,22) }
        };
        }
    }
}
