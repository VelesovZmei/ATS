using System;
using System.Collections.Generic;
using System.Text;

namespace ATS
{
    public class ATS
    {
        public List<Tariff> Tariffs { get; set; }
        public List<Client> Clients { get; set; }
        public List<Call> Calls { get; set; }
        public List<Account> Accounts { get; set; }

        public void AddTariff(Tariff tariff)
        {
            Tariffs ??= new List<Tariff>();
            Tariffs.Add(tariff);
        }
        
        public void DeleteTariff(Tariff tariff)
       {
            
            if (!(Tariffs?.Count > 0)) // список не чуществует или пуст
            {
                return;
            }
            
            Tariffs.Remove(tariff);
        }
        //public void UpdateTariff(Tariff tariff)
            // найти по Id в списке - обновить нужные поля - вернуть в список
        
            public void AddClient(Client client)
        {
            Clients ??= new List<Client>();
            Clients.Add(client);
        }
        public void DeleteClient(Client client)
        {
            if (!(Clients?.Count > 0))
            {
                return;
            }
            Clients.Remove(client);
        }
        //public List<Client> UpdateClient();
        public void VerifyState()


    }
}
