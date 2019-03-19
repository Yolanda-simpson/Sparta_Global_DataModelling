using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class CarSize
    {
        private string smallCar;
        private string mediumCar;
        private string largeCar;

        public string SmallCar { get => smallCar; set => smallCar = value; }
        public string MediumCar { get => mediumCar; set => mediumCar = value; }
        public string LargeCar { get => largeCar; set => largeCar = value; }
    }
}