using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class ReturnedCar
    {
        private DateTime returnDate;
        private string condition;

        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public string Condition { get => condition; set => condition = value; }
    }
}