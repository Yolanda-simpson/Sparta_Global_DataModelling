using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class Customer
    {
        private string firstname;
        private string lasname;
        private int age;
        private Address address;
       

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lasname { get => lasname; set => lasname = value; }
        public int Age { get => age; set => age = value; }
        public Address Address { get => address; set => address = value; }
       
    }
}