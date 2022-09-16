using System.Collections.Generic;
using System.Linq;
using TicketsController.Domain.Entities;

namespace TicketsController.Infra.Repository
{
    public class Service
    {
        private BaseContext _context;
        private List<Services> _services;

        public Service(BaseContext conext)
        {
            _context = conext;
        }

        public List<Services> GetServices()
        {
            var enumerable = _context.Services.ToList();
            _services = new List<Services>();
            foreach (var obj in enumerable)
            {
                var service = obj;
                service.ServiceFull = new List<string>();

                if (obj.Service1 != null)
                {
                    service.ServiceFull.Add(obj.Service1);
                }
                if (obj.Service2 != null)
                {
                    service.ServiceFull.Add(obj.Service2);
                }
                if (obj.Service3 != null)
                {
                    service.ServiceFull.Add(obj.Service3);
                }
                if (obj.Service4 != null)
                {
                    service.ServiceFull.Add(obj.Service4);
                }
                if (obj.Service5 != null)
                {
                    service.ServiceFull.Add(obj.Service5);
                }
                _services.Add(service);
            }

            return _services;
        }
        public Services GetServiceLast()
        {
             var result = _context.Services.OrderByDescending(i => i.Id)
                                            .FirstOrDefault();

            result.ServiceFull = new List<string>();

            if (result.Service1 != null)
            {
                result.ServiceFull.Add(result.Service1);
            }
            if (result.Service2 != null)
            {
                result.ServiceFull.Add(result.Service2);
            }
            if (result.Service3 != null)
            {
                result.ServiceFull.Add(result.Service3);
            }
            if (result.Service4 != null)
            {
                result.ServiceFull.Add(result.Service4);
            }
            if (result.Service5 != null)
            {
                result.ServiceFull.Add(result.Service5);
            }

            return result;
        }
    }
}
