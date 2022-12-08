using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class GarageUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime CarRecieved { get; set; }
        public int CarNumber { get; set; }
        public string Catagory { get; set; }
        public string ClientInsurance { get; set; }
        public string ClientAgent { get; set; }
        public bool Admin { get; set; }

    }
}