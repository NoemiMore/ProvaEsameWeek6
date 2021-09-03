using ProvaWeek6.Core.Interfaces;
using ProvaWeek6.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.EF.Repository
{
    class EFClienteRepository : IClienteRepository
    {
        private readonly PolizzaContext ctx;

        public EFClienteRepository()
        {
            ctx = new PolizzaContext();
        }



        public bool Add(Cliente item)
        {
            throw new NotImplementedException();
        }

        

        public List<Cliente> Fetch()
        {
            return ctx.Clienti.ToList();
        }

        public List<Cliente> FetchByPolizzaCode(string code)
        {
            throw new NotImplementedException();
        }

        public Cliente GetByCF(string codiceFiscale)
        {
            if (string.IsNullOrEmpty(codiceFiscale))
                return null;

            var Cliente = ctx.Clienti.Where(c => c.CodiceFiscale == codiceFiscale).FirstOrDefault();
            return Cliente;
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente item)
        {
            throw new NotImplementedException();
        }
    }
}
