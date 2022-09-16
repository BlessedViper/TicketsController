using System.Collections.Generic;
using System.Linq;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Repository.Get
{
    public class HistoryGet
    {
        private BaseContext _context;

        public HistoryGet(BaseContext context)
        {
            _context = context;
        }
        
        public List<History> ListHistory()
        {
            return _context.History.ToList();
        }
    }
}
