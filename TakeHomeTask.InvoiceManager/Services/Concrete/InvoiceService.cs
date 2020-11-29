using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHome.WebAPI.Data.Entities;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Services.Concrete
{
    public class InvoiceService : IInvoiceService
    {
        private readonly HttpClient httpClient;

        public InvoiceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<InvoiceServiceResponse> CreateInvoice(Invoice invoice)
        {
            return await httpClient.PostJsonAsync<InvoiceServiceResponse>("api/invoices", invoice);
        }

        public async Task DeleteInvoice(Guid id)
        {
            await httpClient.DeleteAsync($"api/invoices/{id}");
        }

        public async Task<Invoice> GetInvoice(Guid id)
        {
            return await httpClient.GetJsonAsync<Invoice>($"api/invoices/{id}");
        }
        public async Task<Invoice> UpdateInvoice(Invoice invoice)
        {
            return await httpClient.PutJsonAsync<Invoice>("api/invoices", invoice);
        }

        public async Task<IEnumerable<Invoice>> GetInvoices() =>  await httpClient.GetJsonAsync<Invoice[]>("api/invoices");
        
    }
}
