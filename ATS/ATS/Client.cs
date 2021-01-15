using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ATS
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int NumberOfContract { get; set; }        
        public bool Port { get; set; } = true;
        public Tariff Tariff { get; set; }
        public DateTime TariffUpdate { get; set; }
        public List<Call> MyCalls { get; set; }
        public bool State { get; set; }

        public Client(string name, int phoneNumber, int agreement, bool port, Tariff tariff)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            NumberOfContract = agreement;
            Port = port;
            Tariff = tariff;
        }

        public void PortConnected();//событие открыть порт

        public void PotrDisconnected()
        {
            if (Port)
            {
                Port = false;
            }
        }
        

        public void ToCall()
        {
            if (!Port)
            {
                Console.WriteLine("Порт закрыт");
                return;
            }
            //инициировать событие вызова

        }

        public void ToAnswer();//событие ответа

        public void Detailisation(DateTime beginTime, DateTime endTime, ATS ats)
        {
            MyCalls = ats.Calls.Where(c => c.Caller == this && c.TimeOfStartCall >= beginTime && c.TimeOfFinishCall <= endTime).ToList();
        }

        public void ChangeTariff(Tariff tariff)
        {
            if ((DateTime.Now - TariffUpdate).TotalDays >= 30)
            {
                Tariff = tariff;
                TariffUpdate = DateTime.Now;
            }
        }


       // public bool Status();




    }
}
