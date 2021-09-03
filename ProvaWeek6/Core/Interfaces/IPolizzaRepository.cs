using ProvaWeek6.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.Core.Interfaces
{
    interface IPolizzaRepository : IRepository<Polizza>
    {  //aggiornamento data dopo rinnovo
        Polizza UpdateDataScadenza(string DataScadenza);

        // 
        _Tipo SceltaTipoPolizza(_Tipo Tipo);

    }
}
