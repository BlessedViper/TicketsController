using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsController.Domain.Entities
{
    public class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataImportacao { get; set; }
        public int QuantidadeImportada { get; set; }
    }
}
