using System;
using System.Collections.Generic;
using System.Text;

namespace TakeHome.Models.InvoiceViewModels
{
  public class InvoiceServiceResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public InvoiceViewModel Invoice { get; set; }

    }
}
