using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDATAMODELLINGCars.Models
{
    public class paymentDate
    {
        private DateTime paymentdate;
        private decimal paymentamount;

        public DateTime Paymentdate { get => paymentdate; set => paymentdate = value; }
        public decimal Paymentamount { get => paymentamount; set => paymentamount = value; }
    }
}