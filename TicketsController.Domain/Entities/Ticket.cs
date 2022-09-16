using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsController.Domain.Entities
{
    public class Ticket
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [JsonProperty("category")]
        public string Categoria { get; set; }

        [JsonProperty("createdDate")]
        public DateTime DataCriacao { get; set; }

        [JsonProperty("subject")]
        public string Titulo { get; set; }

        [JsonProperty("urgency")]
        public string Urgencia { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("lastActionDate")]
        public DateTime UltimaAcao { get; set; }

        [JsonProperty("ownerTeam")]
        public string TimeAtendimento { get; set; }

        [JsonProperty("actionCount")]
        public int NumAcoes { get; set; }

        [JsonProperty("serviceFull")]
        public string[] ServiceFull { get; set; }

        public virtual Services Service { get; set; } = new();

        [ForeignKey("IdService")]
        public int IdService { get; set; }
    }
}
