using System;
using System.Collections.Generic;
using System.Text;

namespace ATS
{
    public class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CostOfMinute { get; set; }
        public List<Client> Clients { get; set; }
        

        public Tariff(String name, int cost)
        {
            Name = name;
            CostOfMinute = cost;
        }
    }
}
