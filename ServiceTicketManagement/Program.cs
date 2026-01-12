using ServiceTicketManagement.Services;
using ServiceTicketManagement.Models;

var ticketService = new TicketService();

while (true)
{
    Console.WriteLine("\nService Ticket Management System");
    Console.WriteLine("1. Create Ticket");
    Console.WriteLine("2. View Tickets");
    Console.WriteLine("3. Update Ticket Status");
    Console.WriteLine("4. Assign Ticket");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Title: ");
            var title = Console.ReadLine();
            Console.Write("Description: ");
            var description = Console.ReadLine();
            ticketService.CreateTicket(title, description);
            break;

        case "2":
            ticketService.ViewTickets();
            break;

        case "3":
            Console.Write("Ticket ID: ");
            int statusId = int.Parse(Console.ReadLine());
            Console.Write("Status (Open, InProgress, Resolved): ");
            var status = Enum.Parse<TicketStatus>(Console.ReadLine());
            ticketService.UpdateStatus(statusId, status);
            break;

        case "4":
            Console.Write("Ticket ID: ");
            int assignId = int.Parse(Console.ReadLine());
            Console.Write("Engineer name: ");
            var engineer = Console.ReadLine();
            ticketService.AssignTicket(assignId, engineer);
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
