using TicketsController.Domain.Entities;
using System.Linq;
using System;

namespace TicketsController.Infra.Repository.Get
{
    public class PutTicketValidation
    {
        private BaseContext _context;
        public PutTicketValidation(BaseContext context)
        {
            _context = context;
        }
        public bool ValidaTicket(Ticket ticket)
        {
            Ticket ticketTest = new();
            var ticketId = ticket.Id;
            var query =
                (from t in _context.Ticket
                where t.Id == ticketId
                select t.Id).Count();


            if (!query.Equals(0))
            {
                return true;
            }
            return false;
        }
    }
}
