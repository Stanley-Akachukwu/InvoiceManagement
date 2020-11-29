using System;
using System.Collections.Generic;
using System.Text;

namespace TakeHome.Models.InvoiceViewModels
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
