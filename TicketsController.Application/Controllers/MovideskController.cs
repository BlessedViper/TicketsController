using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsController.Domain.Entities;
using TicketsController.Domain.Services;
using TicketsController.Infra.Repository;

namespace TicketsController.Application.Services
{
    public class MovideskController
    {
        private readonly MovideskService _movideskService = new();
        private readonly HttpRepository _httpRepository = new();
        public async Task<List<Ticket>> SearchTickets(DateTime initialDate, DateTime finalDate, int? skip)
        {
            var ticketsBase = new List<Ticket>();
            var tickets = new List<Ticket>();
            try
            {
                var address = _movideskService.GetUrlTickets(_movideskService.GetSelectTicket(), _movideskService.GetFilter(initialDate, finalDate), skip ?? 0);
                var response = await _httpRepository.GetRequest(address);

                if (!response.Equals("[]") && !string.IsNullOrEmpty(response))
                {
                    var ticketsRound = TicketsController.Shared.Functions.ParseJson.JsonToObject<Ticket>(response);
                    ticketsBase.AddRange(ticketsRound);

                    while (ticketsRound.Count > 0)
                    {
                        skip += 1000;

                        address = _movideskService.GetUrlTickets(_movideskService.GetSelectTicket(), _movideskService.GetFilter(initialDate, finalDate), skip ?? 0);
                        response = await _httpRepository.GetRequest(address);

                        ticketsRound = TicketsController.Shared.Functions.ParseJson.JsonToObject<Ticket>(response);
                        ticketsBase.AddRange(ticketsRound);
                    }


                    foreach (var item in ticketsBase)
                    {
                        if (item.ServiceFull.Length >= 1)
                        {
                            item.Service.Service1 = item.ServiceFull[0].ToString();
                        }
                        if (item.ServiceFull.Length >= 2)
                        {
                            item.Service.Service2 = item.ServiceFull[1].ToString();
                        }
                        if (item.ServiceFull.Length >= 3)
                        {
                            item.Service.Service3 = item.ServiceFull[2].ToString();
                        }
                        if (item.ServiceFull.Length >= 4)
                        {
                            item.Service.Service4 = item.ServiceFull[3].ToString();
                        }
                        if (item.ServiceFull.Length >= 5)
                        {
                            item.Service.Service5 = item.ServiceFull[4].ToString();
                        }

                        tickets.Add(item);
                    }
                }
                else
                {
                    throw new Exception("Nenhum ticket encontrado na busca!\rVerifique a data preenchida e realize a busca novamente!");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals(System.Net.HttpStatusCode.InternalServerError.ToString()))
                {
                    await SearchTickets(initialDate, finalDate, skip);
                }
                else if (ex.Message.Equals("429"))
                {
                    await Task.Delay(60000);
                    await SearchTickets(initialDate, finalDate, skip);
                }
                else
                {
                    throw new Exception(ex.Message) { Source = ex.Source };
                }
            }

            return tickets;
        }
    }
}
