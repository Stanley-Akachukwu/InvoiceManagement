using AutoMapper;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models;
using TakeHome.Models.InvoiceViewModels;
using TakeHome.WebAPI.Data.Entities;
using TakeHomeTask.InvoiceManager.Data;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Pages
{
    public class EditInvoiceBase: ComponentBase
    {

        [Inject]
        public IInvoiceService InvoiceService { get; set; }

        public string ViewTitle { get; set; }

        private Invoice Invoice { get; set; } = new Invoice();

        public InvoiceViewModel InvoiceViewModel { get; set; } =
            new InvoiceViewModel();

        [Inject]
        public IVatService VatService { get; set; }
        [Inject]
        public ICurrencyService CurrencyService { get; set; }
        [Inject]
        public IExchangeRateService ExchangeRateService { get; set; }
        [Inject]
        public IClientService ClientService { get; set; }
        public List<Vat> Vats { get; set; } =
            new List<Vat>();
        public List<Currency> Currencies { get; set; } =
            new List<Currency>();
        public List<ExchangeRate> ExchangeRates { get; set; } =
            new List<ExchangeRate>();
        public List<Client> Clients { get; set; } =
            new List<Client>();

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (Id != null)
            {
                Guid invoiceNumber = new Guid(Id);
                ViewTitle = "Edit Invoice";
                Invoice = await InvoiceService.GetInvoice(invoiceNumber);
            }
            else
            {
                ViewTitle = "New Invoice";
                Invoice = new Invoice 
                { 
                    DeliveryDate=DateTime.Now,
                    SettleDate = DateTime.Now,
                    InvoiceDate = DateTime.Now,
                    InvoiceVat="",
                    Client ="",
                    Currency = "",
                    ExchangeRate=""
                };
                 
            }

            Vats = (await VatService.GetVats()).ToList();
            Currencies = (await CurrencyService.GetCurrencies()).ToList();
            ExchangeRates = (await ExchangeRateService.GetExchangeRates()).ToList();
            Clients = (await ClientService.GetClients()).ToList();
            Mapper.Map(Invoice, InvoiceViewModel);
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(InvoiceViewModel, Invoice);

            InvoiceServiceResponse response = null;

            if (Invoice.InvoiceNumber != new Guid())
            {
                Invoice result = null;
                result = await InvoiceService.UpdateInvoice(Invoice);
                ToastService.ShowSuccess(Invoice.Description + " was updated successfully");
                NavigationManager.NavigateTo("/");

            }
            else
            {
                response = await InvoiceService.CreateInvoice(Invoice);
                if (response.ResponseCode == StatusCodes.Status422UnprocessableEntity || response.ResponseCode == StatusCodes.Status409Conflict)
                {
                    ToastService.ShowError(response.ResponseMessage);
                }
                if (response.ResponseCode == StatusCodes.Status201Created)
                {
                    ToastService.ShowSuccess(response.ResponseMessage);
                    NavigationManager.NavigateTo("/");
                }
            }
        }

        protected TakeHomeTask.InvoiceManager.Shared.Components.ConfirmBase DeleteConfirmation { get; set; }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }
        protected void Cancel_Click()
        {
            NavigationManager.NavigateTo("/Invoices");
        }
        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await InvoiceService.DeleteInvoice(Invoice.InvoiceNumber);
                ToastService.ShowSuccess(Invoice.InvoiceNumber + " was removed successfully");
                NavigationManager.NavigateTo("/Invoices");
            }
        }
    }
}
