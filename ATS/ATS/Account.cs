using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATS
{
    public class Account
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public decimal Debut { get; set; }
        public decimal Credit { get; set; }
       // public decimal Accamulation { get; set; }

        public decimal UpdateCredit();
       // public decimal UpdateAccamulation()
        
            
        public void UpdateDebut(ATS ats)
        {
            var monthlydate= DateTime.Now.AddMonths(-1);
            var firstday = new DateTime(monthlydate.Year, monthlydate.Month, 1, 0, 0, 0);
            var lastday =firstday.AddMonths(1);
            decimal Accamulation = ats.Calls.Where(c => c.Caller == Client && c.TimeOfStartCall >= firstday && c.TimeOfFinishCall < lastday).ToList().Sum(x => x.DurationOfCall*Client.Tariff.CostOfMinute);
            
            Debut += Accamulation;
            Accamulation = 0;
        }
    }   
}
