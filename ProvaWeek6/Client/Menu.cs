using ProvaWeek6.Core.Models;
using ProvaWeek6.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.Client
{
    class Menu
    {

        private static MainBL mainBL = new MainBL(new EFClienteRepository(), new EFPolizzaRepository());

        internal static void Start()
        {
            Console.WriteLine("Benvenuto!");

            char choice;

            do
            {
                Console.WriteLine("Premi 1 per inserire un nuovo cliente");
                Console.WriteLine("Premi 2 per inserire una polizza per un cliente già esistente");
                Console.WriteLine("Premi 3 per visualizzare le polizze di un cliente");
                Console.WriteLine("Premi 4 per posticipare la data di scadenza di una polizza");
                Console.WriteLine("Premi 5 per visualizzare i clienti che hanno una polizza vita");
                Console.WriteLine("Premi 0 per uscire");

                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                       
                        AddNewCliente();
                        Console.WriteLine();
                        break;
                    case '2':

                        AddNewPolizza();
                        Console.WriteLine();
                        break;
                    case '3':
                       
                        ShowPolizze();
                        Console.WriteLine();
                        break;
                    case '4':
                        //aggiornadata scadenza polizza
                        UpdateDataScadenzaPolizza();
                        Console.WriteLine();
                        break;
                    case '5':
                        //visualizzare le polizze di un cliente
                        FetchClientiPolizzaVita();
                        Console.WriteLine();
                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile");
                        break;
                }
            }
            while (!(choice == 'Q'));
        }




        private static void FetchClientiPolizzaVita()
        {
            throw new NotImplementedException();
        }

        private static void UpdateDataScadenzaPolizza()
        {
            DateTime dataScadenzaPolizza;

            Console.WriteLine("Digita la polizza che vuoi modificare ");
            ShowPolizze();
            
            
            


            var polizzaToUpdate = GetPolizzaByTipo(tipo);

            if (polizzaToUpdate != null)
            {
                Console.Write("Inserire la data: ");

                while (!DateTime.TryParse(Console.ReadLine(), out dataScadenzaPolizza) || dataScadenzaPolizza < DateTime.Now)
                {
                    Console.WriteLine("Devi inserire una data, posteriore o uguale a oggi!");
                }

                polizzaToUpdate. = dataScadenzaPolizza;
                mainBL.UpdatePolizza(polizzaToUpdate);
            }
            else
            {
                Console.WriteLine("Non c'è una polizza di questo tipo");
            }



        }

        

        private static object GetPolizzaByTipo(_Tipo tipo)
        {
            throw new NotImplementedException();
        }

        private static void ShowPolizze()
        {
           
        }

        private static void AddNewPolizza()
        {
            /*
            int numeroPolizza;
            DateTime dataScadenza = new DateTime();
            decimal rataMensile;
            _Tipo tipo;

           
            do
            {
                //inserimento data
                Console.Write("Inserire la data di scadenza: ");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out dataScadenza) || dataScadenza < DateTime.Now)
            {
                Console.WriteLine("Devi inserire una data, posteriore o uguale a oggi!");
            }


            //inserimento rata mensile
            do {
                Console.Write("Inserire la rata mensile: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out rataMensile) || rataMensile < 0)
            {
                Console.WriteLine("Devi inserire un importo valido!");
            }


                Polizza newPolizza = new Polizza
                {
                    NumeroPolizza = numeroPolizza,
                    DataScadenza = dataScadenza,
                    RataMensile = rataMensile,
                    Tipo = tipo,
                    Cliente = cliente,
                    
                };

                mainBL.AddPolizza(newPolizza);

               
           
            else
            {
                Console.WriteLine("Il cliente possiede già questo tipo di polizza");
            }*/
        }


        private static void AddNewCliente()
        {
            string codiceFiscale, nome, cognome;
           
            do
            {
                Console.Write("Inserisci il codice fiscale del cliente:");
                codiceFiscale = Console.ReadLine();
            }
            while (codiceFiscale.Length == 0 || codiceFiscale.Length > 16);

            do
            {
                Console.Write("Inserisci il nome del cliente:");
                nome = Console.ReadLine();
            }
            while (nome.Length == 0 || nome.Length >30);

            do
            {
                Console.Write("Inserisci il cognome del cliente:");
                cognome = Console.ReadLine();
            }
            while (nome.Length == 0 || nome.Length > 20);



            Polizza polizza  = null;
            do
            {
                Console.WriteLine("Scegli la polizza da aggiungere al cliente");
                polizza = ChoosePolizza();
            }
            while (polizza == null);


            Cliente nuovoCliente = new Cliente
            {
                CodiceFiscale = codiceFiscale,
                Nome= nome,
                Cognome= cognome,
               // Polizza= polizza,
               
                
            };
            mainBL.AddCliente(newCliente);




        }

        private static Polizza ChoosePolizza()
        {
            throw new NotImplementedException();
        }

        private static object GetClienteByCF(string codiceFiscale)
        {
            var cliente = mainBL.GetByCF(codiceFiscale);

            return cliente;
        }
    }
}
