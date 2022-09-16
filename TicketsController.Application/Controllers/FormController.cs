using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicketsController.Application.Services;
using TicketsController.Application.Views;
using TicketsController.Domain.Entities;
using TicketsController.Infra.DatabaseRepository;

namespace TicketsController.Application.Controllers
{
    public class FormController
    {
        private FrmHome _home;
        private FrmTicketsList _ticketsListForm;
        private FrmHistoryList _historyListForm = new();
        private DataController _repo = new();
        private MovideskController _movideskController = new();
        private FrmExport _export;
        private DataController _data = new();
        private History _history = new();
        private int _generated = 0;
        private List<Ticket> _list = new();
        public void OpenHome()
        {
            _ticketsListForm = new(_home, this, _data, _history);
            _home = new(_repo, _movideskController, this);
            System.Windows.Forms.Application.Run(_home);
        }
        public void OpenTicketList(List<Ticket> tickets, FrmHome home)
        {
            _ticketsListForm = new(home, this, _data, _history);
            _ticketsListForm.FeedGrid(tickets);
            _ticketsListForm.ShowDialog();
        }
        public void OpenHistoryList(IEnumerable<History> list)
        {
            if (!list.Equals(null))
            {
                _historyListForm.FeedGrid(list);
                _historyListForm.ShowDialog();
            }
            else
                MessageBox.Show("Não há nenhum dado a ser exibido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void OpenExport()
        {
            _export = new(_data, _generated, _history, _movideskController);
            _generated++;
            _export.ShowDialog();
        }
    }
}
