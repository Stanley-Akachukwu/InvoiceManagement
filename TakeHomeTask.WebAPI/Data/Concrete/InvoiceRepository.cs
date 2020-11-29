using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.WebAPI.Data.Abstract;
using TakeHome.WebAPI.Data.Entities;

namespace TakeHome.WebAPI.Data.Concrete
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly TakeHomeDbContext _context;
        private readonly IMapper _mapper;

        public InvoiceRepository(TakeHomeDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
       
        public async Task<Invoice> AddInvoice(Invoice invoice)
        {
            invoice.InvoiceNumber = Guid.NewGuid();
            var result = await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        

       public async Task<IEnumerable<Invoice>> GetInvoices()
        {
            return await _context.Invoices.OrderByDescending(i=>i.InvoiceDate).ToListAsync();
        }

        public async  Task<Invoice> GetInvoice(Guid invoiceNumber)
        {
            return await _context.Invoices.FirstOrDefaultAsync(i => i.InvoiceNumber == invoiceNumber);
        }
 
       public async Task<Invoice> UpdateInvoice(Invoice invoice)
        {
            try
            {
                var dbInvoice = await _context.Invoices
                      .FirstOrDefaultAsync(i => i.InvoiceNumber == invoice.InvoiceNumber);

                if (dbInvoice != null)
                {
                    dbInvoice.Description = invoice.Description;
                    dbInvoice.Amount = invoice.Amount;
                    dbInvoice.InvoiceDate = invoice.InvoiceDate;
                    dbInvoice.DeliveryDate = invoice.DeliveryDate;
                    dbInvoice.InvoiceVat = invoice.InvoiceVat;
                    dbInvoice.Currency = invoice.Currency;
                    dbInvoice.ExchangeRate = invoice.ExchangeRate;
                    dbInvoice.OrderNumber = invoice.OrderNumber;
                    dbInvoice.SalesAgent = invoice.SalesAgent;
                    dbInvoice.Client = invoice.Client;
                    await _context.SaveChangesAsync();
                    return dbInvoice;
                }
            }
            catch (Exception exp)
            {

                throw;
            }

            return null;
        }

        public async Task<Invoice> DeleteInvoice(Guid invoiceIdNumber)
        {
            var dbInvoice = await _context.Invoices
                 .FirstOrDefaultAsync(i => i.InvoiceNumber == invoiceIdNumber);
            if (dbInvoice != null)
            {
                _context.Invoices.Remove(dbInvoice);
                await _context.SaveChangesAsync();
                return dbInvoice;
            }

            return null;
        }

        public async Task<Invoice> GetInvoiceByOrderNuber(string orderNumber)
        {
            return await _context.Invoices.FirstOrDefaultAsync(i => i.OrderNumber== orderNumber);
        }
    }
}
