using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.WebAPI.Data.Entities;

namespace TakeHome.WebAPI.Data.Abstract
{
   public interface IInvoiceRepository
    {
       
        Task<IEnumerable<Invoice>> GetInvoices();
        Task<Invoice> GetInvoice(Guid invoiceNumber);
        Task<Invoice> AddInvoice(Invoice invoice);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task<Invoice> DeleteInvoice(Guid invoiceNumber);
        Task<Invoice> GetInvoiceByOrderNuber(string orderNumber);


    }
}
 