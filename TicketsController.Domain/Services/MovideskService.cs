using System;

namespace TicketsController.Domain.Services
{
    public class MovideskService
    {
        private readonly string _baseUrl = "url_api";
        private readonly string _tokenMovidesk = "token";

        public string GetSelectTicket()
        {
            return "id, category, createdDate, subject, urgency, status, slaSolutionDate, lastActionDate, serviceFull, ownerTeam, actionCount";
        } 

        public string GetFilter(DateTime startDate, DateTime endDate)
        {
            return $"createdDate ge {startDate:yyyy-MM-dd} and createdDate le {endDate:yyyy-MM-ddThh:mm:ssZ}";
        }

        public string GetUrlTickets(string select, string filter, int skip)
        {
            return $"{_baseUrl}tickets?token={_tokenMovidesk}&$select={select}&$filter= {filter}&$top=1000&$skip={skip}";
        }
    }
}
