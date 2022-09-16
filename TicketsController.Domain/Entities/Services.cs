using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsController.Domain.Entities
{
    public class Services
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public string Service4 { get; set; }
        public string Service5 { get; set; }
        public List<string> ServiceFull { get; set; }
        public virtual List<Ticket> Ticket { get; set; }
    }
}
