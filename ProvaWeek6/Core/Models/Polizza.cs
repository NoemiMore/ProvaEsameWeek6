using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.Core.Models
{
    class Polizza
    {
        [Key]
        public int PolizzaId { get; set; }

        [Required]
        public int NumeroPolizza { get; set; }

        public DateTime DataScadenza { get; set; }
        public decimal RataMensile { get; set; }
        public _Tipo Tipo { get; set; }

        //relazione molte polizze per 1 solo cliente
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }


    enum _Tipo 
    { 
        RcAuto,
        Furto,
        Vita
    }
}
