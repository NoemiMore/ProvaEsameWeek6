using ProvaWeek6.Core.Interfaces;
using ProvaWeek6.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6
{
    class MainBL
    {
        private IClienteRepository _clienteRepo;
        private IPolizzaRepository _polizzaRepo;
        public MainBL(IClienteRepository clienteRepository, IPolizzaRepository polizzaRepository)
        {
            _clienteRepo = clienteRepository;
            _polizzaRepo = polizzaRepository;
        }


        internal bool AddCliente(Cliente newcliente)
        {
            //validazione
            if (newcliente == null) throw new ArgumentNullException();

            bool isAdded = _clienteRepo.Add(newcliente);
            return isAdded;

            
        }


        internal bool AddPolizza(Polizza polizza)
        {
           
            if (polizza == null) throw new ArgumentNullException();

            bool isAdded = _polizzaRepo.Add(polizza);
            return isAdded;
        }


        internal List<Cliente> FetchClienti()
        {

            {
                var clienti = _clienteRepo.Fetch();
                return clienti;
            }
        }

        internal List<Cliente> FetchClientiPolizza()
        {
            var clienti = _clienteRepo.Fetch();
            try
            {
                return clienti;
            }
            catch
            {
                return null;
            }
        }


        internal List<Polizza> FetchPolizze()
        {
           
            {
                var polizze = _polizzaRepo.Fetch();
                return polizze;
            }
        }

        internal object GetByCF(string codiceFiscale)
        {
            if (string.IsNullOrEmpty(codiceFiscale)) throw new ArgumentNullException();

            var book = _clienteRepo.GetByCF(codiceFiscale);
            return book;
        }

        internal void AddCliente(object newCliente)
        {
            throw new NotImplementedException();
        }

        internal void UpdatePolizza(object polizzaToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
