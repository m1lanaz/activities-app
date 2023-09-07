namespace Domain
{
    public class Activities
    {
        public Guid Id { get; set; } //needs to be called id so entity framework recognises this is Id

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string City { get; set; }

        public string Venue { get; set; }
    }
}