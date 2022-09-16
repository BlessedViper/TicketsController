using Newtonsoft.Json;
using System;

namespace TicketsController.Domain.Entities
{
    public class Actions
    {
        [JsonProperty("actions.id")]
        public int Id { get; set; }

        [JsonProperty("actions.timeAppointments.workTime")]
        public TimeSpan WorkTime { get; set; }
    }
}