using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Services.Concrete
{
    public class CurrencyService : ICurrencyService
    {
       
        public async Task<IEnumerable<Currency>> GetCurrencies() => await GetAllCurrencies();
        public async Task<List<Currency>> GetAllCurrencies()
        {
            return new List<Currency> {
           new Currency{Id=1,Country="Nigeria",Symbol="₦"},
            new Currency{Id=2,Country="Ghana",Symbol="GH₵"},
             new Currency{Id=3,Country="South Africa",Symbol="R"},
              new Currency{Id=4,Country="Egypt",Symbol="E£"}
            };
        }
    }
}
