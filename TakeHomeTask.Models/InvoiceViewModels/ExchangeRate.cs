using System;
using System.Collections.Generic;
using System.Text;

namespace TakeHome.Models.InvoiceViewModels
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        public double Rate { get; set; }
        public string RateMap { get; set; }

    }
}
