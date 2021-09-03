using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaWeek6.Core.Models
{
    class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(10), MinLength(10)]
        public string CodiceFiscale { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Cognome { get; set; }

        //lista di polizze che possiede il cliente, relazione 1 a molti
        public List<Polizza> Polizze { get; set; } = new List<Polizza>();


    } 
}
 