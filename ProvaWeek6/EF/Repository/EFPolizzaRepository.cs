using Microsoft.EntityFrameworkCore;
using ProvaWeek6.Core.Interfaces;
using ProvaWeek6.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.EF.Repository
{
    class EFPolizzaRepository : IPolizzaRepository
    {
        private readonly PolizzaContext polizzaCtx;

        public EFPolizzaRepository()
        {
            polizzaCtx = new PolizzaContext();
        }





        public bool Add(Polizza newPolizza)
        {
            if (newPolizza == null)
                return false;

            try
            {
                
                var cliente = polizzaCtx.Clienti
               .FirstOrDefault(c => c.ClienteId == newPolizza.Cliente.ClienteId);

                polizzaCtx.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       

        public List<Polizza> Fetch()
        {
            try
            {
                var polizze = polizzaCtx.Polizze.Include(p => p.Cliente)
                    .ToList();
                return polizze;
            }
            catch (Exception)
            {
                return new List<Polizza>();
            }
        }

        public Polizza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public _Tipo SceltaTipoPolizza(_Tipo Tipo)
        {
            throw new NotImplementedException();
        }

        public bool Update(Polizza item)
        {
            throw new NotImplementedException();
        }

        public Polizza UpdateDataScadenza(string DataScadenza)
        {
            throw new NotImplementedException();
        }
    }
}
