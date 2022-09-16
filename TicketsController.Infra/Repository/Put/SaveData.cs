using Microsoft.EntityFrameworkCore;
using System;
using TicketsController.Domain.Entities;
using TicketsController.Infra.Repository.Get;

namespace TicketsController.Infra.Repository.Put
{
    public class SaveData
    {
        private BaseContext _context;
        private PutTicketValidation _validation;

        public SaveData(BaseContext context, PutTicketValidation validation)
        {
            _context = context;
            _validation = validation;
        }

        public void Data<T>(Object obj)
        {
            if (obj.GetType() == typeof(Ticket))
            {
                var test = _validation.ValidaTicket((Ticket)obj);
                if (test.Equals(true))
                {
                    _context.Entry(obj).State = EntityState.Modified;
                    _context.SaveChanges();
                    _context.DeatchAllEntities();
                    return;
                }
                _context.Add(obj);
                _context.SaveChanges();
                _context.DeatchAllEntities();
                return;
            }
            
            _context.Add(obj);
            _context.SaveChanges();
            _context.DeatchAllEntities();
        }

        public void DataRange<T>(Object obj)
    {
            _context.AddRange(obj);
            _context.ChangeTracker.AcceptAllChanges();
        }
        public void SaveChangesRange()
        {
            _context.SaveChanges();
        }
    }
}
