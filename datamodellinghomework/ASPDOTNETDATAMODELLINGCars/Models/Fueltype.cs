using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class Fueltype
    {
        private string petrol;
        private string diesel;

        public string Petrol { get => petrol; set => petrol = value; }
        public string Diesel { get => diesel; set => diesel = value; }
    }
}