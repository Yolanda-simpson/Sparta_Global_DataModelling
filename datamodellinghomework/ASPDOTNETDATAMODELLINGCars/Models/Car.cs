using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class Car
    {
        private string carMake;
        private int numberOfSeats;
        private string carColour;
        private string size;
        private string showroom;

        public string CarMake { get => carMake; set => carMake = value; }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
        public string CarColour { get => carColour; set => carColour = value; }
        public string Size { get => size; set => size = value; }
        public string Showroom { get => showroom; set => showroom = value; }
    }
}