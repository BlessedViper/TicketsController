using System;
using System.Collections.Generic;
using TicketsController.Domain.Entities;
using TicketsController.Infra.Repository;
using TicketsController.Infra.Repository.Get;
using TicketsController.Infra.Repository.Put;

namespace TicketsController.Infra.DatabaseRepository
{
    public class DataController
    {
        private List<History> History { get; set; }
        private Service _service;
        private SaveData _saveData;
        private SaveDataList _saveList;
        private Tickets _listTicket;
        private PutTicketValidation _validation;
        private List<Ticket> _list { get; set; }

        public List<History> ListHistory()
        {
            using BaseContext _context = new();
            History = new();
            var objHistory = new HistoryGet(_context);
            var listHistory = objHistory.ListHistory();
            if (listHistory.Count != 0)
            {
                History.AddRange(listHistory);
            }
            return History;
        }

        public long SaveListAsync(List<Ticket> tickets, History hist)
        {
            using BaseContext _context = new();
            var listService = new List<Services>();
            _validation = new(_context);
            _service = new Service(_context);
            _saveData = new SaveData(_context, _validation);
            _saveList = new SaveDataList(_service, listService, _saveData);

            _saveList.DataSaveList(tickets, hist);
            return _saveList.Saved;
        }
        public void SaveData(Object obj)
        {
            using BaseContext _context = new();
            _validation = new(_context);
            _saveData = new SaveData(_context, _validation);
            _saveData.Data<Object>(obj);
        }

        public List<Ticket> ListObject()
        {
            using BaseContext _context = new();
            _listTicket = new(_context);
            var tickets = _listTicket.ListTicket();
            return tickets;
        }

        public List<Ticket> ListTicketWithDate(DateTime initialDate, DateTime finalDate)
        {
            _list = new();
            using BaseContext _context = new();
            _listTicket = new(_context);
            _list = _listTicket.ListTicketDate(initialDate, finalDate);

            return _list;
        }
    }
}
