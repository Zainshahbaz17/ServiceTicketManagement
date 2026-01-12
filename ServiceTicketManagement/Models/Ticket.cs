namespace ServiceTicketManagement.Models
{
    public enum TicketStatus
    {
        Open,
        InProgress,
        Resolved
    }

    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public TicketStatus Status { get; set; }

        public Ticket(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = TicketStatus.Open;
            AssignedTo = "Unassigned";
        }
    }
}
