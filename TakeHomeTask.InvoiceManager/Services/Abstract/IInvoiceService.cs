using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHome.WebAPI.Data.Entities;

namespace TakeHomeTask.InvoiceManager.Services.Abstract
{
   public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetInvoices();
        Task<Invoice> GetInvoice(Guid id);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task<InvoiceServiceResponse> CreateInvoice(Invoice invoice);
        Task DeleteInvoice(Guid id);
    }
}
