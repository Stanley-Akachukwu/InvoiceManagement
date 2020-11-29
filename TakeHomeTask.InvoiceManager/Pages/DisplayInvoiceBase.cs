using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.WebAPI.Data.Entities;
using TakeHomeTask.InvoiceManager.Services.Abstract;
using TakeHomeTask.InvoiceManager.Shared.Components;

namespace TakeHomeTask.InvoiceManager.Pages
{
    public class DisplayInvoiceBase : ComponentBase
    {
        [Parameter]
        public Invoice Invoice { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        [Parameter]
        public EventCallback<bool> OnInvoiceSelection { get; set; }

        [Parameter]
        public EventCallback<Guid> OnInvoiceDeleted { get; set; }

        [Inject]
        public IInvoiceService InvoiceService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected ConfirmBase DeleteConfirmation { get; set; }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await InvoiceService.DeleteInvoice(Invoice.InvoiceNumber);
                await OnInvoiceDeleted.InvokeAsync(Invoice.InvoiceNumber);
            }
        }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            await OnInvoiceSelection.InvokeAsync((bool)e.Value);
        }
    }
}
