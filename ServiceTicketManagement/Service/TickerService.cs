using ServiceTicketManagement.Models;

namespace ServiceTicketManagement.Services
{
    public class TicketService
    {
        private readonly List<Ticket> _tickets = new();
        private int _nextId = 1;

        public void CreateTicket(string title, string description)
        {
            var ticket = new Ticket(_nextId++, title, description);
            _tickets.Add(ticket);
            Console.WriteLine("Ticket created successfully.");
        }

        public void ViewTickets()
        {
            if (_tickets.Count == 0)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            foreach (var ticket in _tickets)
            {
                Console.WriteLine(
                    $"ID: {ticket.Id} | {ticket.Title} | {ticket.Status} | Assigned: {ticket.AssignedTo}"
                );
            }
        }

        public void UpdateStatus(int id, TicketStatus status)
        {
            var ticket = _tickets.FirstOrDefault(t => t.Id == id);
            if (ticket == null)
            {
                Console.WriteLine("Ticket not found.");
                return;
            }

            ticket.Status = status;
            Console.WriteLine("Ticket status updated.");
        }

        public void AssignTicket(int id, string engineer)
        {
            var ticket = _tickets.FirstOrDefault(t => t.Id == id);
            if (ticket == null)
            {
                Console.WriteLine("Ticket not found.");
                return;
            }

            ticket.AssignedTo = engineer;
            Console.WriteLine("Ticket assigned successfully.");
        }
    }
}
