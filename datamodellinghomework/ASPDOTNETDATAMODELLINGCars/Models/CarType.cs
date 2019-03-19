using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class CarType
    {
        private string ecoCar;
        private string luxuryCar;
        private string familyCar;
        private string suv;

        public string EcoCar { get => ecoCar; set => ecoCar = value; }
        public string LuxuryCar { get => luxuryCar; set => luxuryCar = value; }
        public string FamilyCar { get => familyCar; set => familyCar = value; }
        public string Suv { get => suv; set => suv = value; }
    }
}