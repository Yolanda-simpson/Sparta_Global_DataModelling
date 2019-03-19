using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class ReservedCar
    {
        private string city;
        private DateTime reservedDate;
        private string duration;

        public string City { get => city; set => city = value; }
        public DateTime ReservedDate { get => reservedDate; set => reservedDate = value; }
        public string Duration { get => duration; set => duration = value; }
    }
}