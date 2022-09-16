using System;
using System.Collections.Generic;
using System.Linq;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Repository.Put
{
    public class SaveDataList
    {
        private Service _getService;
        private SaveData _data;
        private List<Services> _listaService;
        
        public SaveDataList(Service service, List<Services> list, SaveData data)
        {
            _getService = service;
            _data = data;
            _listaService = list;
        }
        
        public int Saved { get; private set; }

        public long DataSaveList(List<Ticket> lista, History hist)
        {
            _listaService = _getService.GetServices();
            foreach (var obj in lista)
            {
                var it = 0;
                var list1 = obj.ServiceFull;
                if (_listaService.Count == 0 && obj.ServiceFull.Length != 0)
                {
                    _data.Data<Services>(obj.Service);
                    _listaService.AddRange(_getService.GetServices());
                }
                foreach (var objBanco in _listaService)
                {
                    it++;
                    var list2 = objBanco.ServiceFull;

                    if (list1.SequenceEqual(list2))
                    {
                        obj.IdService = objBanco.Id;
                        obj.Service = objBanco;
                        break;
                    }
                    else if (obj.Service.Id == 0 && it == _listaService.Count)
                    {
                        _data.Data<Services>(obj.Service);
                        _listaService.Add(_getService.GetServiceLast());
                        break;
                    }
                    else
                        continue;
                }
                
                Saved++;
                _data.Data<Ticket>(obj);
            }
            hist.QuantidadeImportada = Convert.ToInt32(Saved);
            _data.Data<History>(hist);
            return Saved;
        }
    }
}
