using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.WebAPI.Data.Entities;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Pages
{
    public class InvoiceListBase: ComponentBase
    {
        [Inject]
        public IInvoiceService InvoiceService { get; set; }

        public IEnumerable<Invoice> Invoices { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Invoices = (await InvoiceService.GetInvoices()).ToList();
        }

        protected async Task InvoiceDeleted()
        {
            Invoices = (await InvoiceService.GetInvoices()).ToList();
        }

        protected int SelectedInvoicesCount { get; set; } = 0;

        
    }
}
