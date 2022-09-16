using System;
using System.Collections.Generic;
using System.Linq;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Repository.Get
{
    public class Tickets
    {
        private BaseContext _context;
        private List<Ticket> _list;
        public Tickets(BaseContext context)
        {
            _context = context;
        }

        public List<Ticket> ListTicket()
        {
            _list = new();
            var query = from t in _context.Ticket
                        join s in _context.Services on t.IdService equals s.Id
                        select new
                        {
                            NumTicket = t.Id,
                            Title = t.Titulo,
                            Categ = t.Categoria,
                            Statu = t.Status,
                            CreateDate = t.DataCriacao,
                            LastAction = t.UltimaAcao,
                            Service1 = s.Service1,
                            Service2 = s.Service2,
                            Service3 = s.Service3,
                            Service4 = s.Service4,
                            Service5 = s.Service5
                        };
            foreach (var result in query)
            {
                var ticket = new Ticket();
                ticket.Id = result.NumTicket;
                ticket.Titulo = result.Title;
                ticket.Categoria = result.Categ;
                ticket.Status = result.Statu;
                ticket.DataCriacao = result.CreateDate;
                ticket.UltimaAcao = result.LastAction;
                ticket.Service.Service1 = result.Service1;
                ticket.Service.Service2 = result.Service2;
                ticket.Service.Service3 = result.Service3;
                ticket.Service.Service4 = result.Service4;
                ticket.Service.Service5 = result.Service5;
                _list.Add(ticket);
            }

            return _list;
        }

        public List<Ticket> ListTicketDate(DateTime initialDate, DateTime finalDate)
        {
            _list = new();
            var query = from t in _context.Ticket
                        join s in _context.Services on t.IdService equals s.Id
                        where t.UltimaAcao >= initialDate && t.UltimaAcao <= finalDate
                        select new
                        {
                            NumTicket = t.Id,
                            Title = t.Titulo,
                            Categ = t.Categoria,
                            Statu = t.Status,
                            CreateDate = t.DataCriacao,
                            LastAction = t.UltimaAcao,
                            Service1 = s.Service1,
                            Service2 = s.Service2,
                            Service3 = s.Service3,
                            Service4 = s.Service4,
                            Service5 = s.Service5
                        };
            foreach (var result in query)
            {
                var ticket = new Ticket();
                ticket.Id = result.NumTicket;
                ticket.Titulo = result.Title;
                ticket.Categoria = result.Categ;
                ticket.Status = result.Statu;
                ticket.DataCriacao = result.CreateDate;
                ticket.UltimaAcao = result.LastAction;
                ticket.Service.Service1 = result.Service1;
                ticket.Service.Service2 = result.Service2;
                ticket.Service.Service3 = result.Service3;
                ticket.Service.Service4 = result.Service4;
                ticket.Service.Service5 = result.Service5;
                _list.Add(ticket);
            }
            return _list;
        }
    }
}
