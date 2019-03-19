using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class Address
    {
        private string houseNumber;
        private string streetName;
        private string postCode;
        private string city;

        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public string City { get => city; set => city = value; }
    }
}