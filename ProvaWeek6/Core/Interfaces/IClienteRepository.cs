using ProvaWeek6.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.Core.Interfaces
{
    interface IClienteRepository: IRepository<Cliente>
    {
        Cliente GetByCF(string isbn);
        List<Cliente> FetchByPolizzaCode(string code);
    }
}
