using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class Transmission
    {
        private string automatic;
        private string manual;

        public string Automatic { get => automatic; set => automatic = value; }
        public string Manual { get => manual; set => manual = value; }
    }
}