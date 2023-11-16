namespace RivkiToledano02._11
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public static int Count { get; set; } = 1;
        public Event()
        {
            Count++;
        }

    }
}
