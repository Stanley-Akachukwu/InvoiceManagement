using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Services.Concrete
{
    public class ExchangeRateService : IExchangeRateService
    {
        
        public async Task<IEnumerable<ExchangeRate>> GetExchangeRates() => await GetAllRates();
        public async Task<List<ExchangeRate>> GetAllRates()
        {
            return new List<ExchangeRate> {
           new ExchangeRate{Id=1,Rate= 65.07,RateMap="Ghana vs Nigeria"},
            new ExchangeRate{Id=2,Rate= 25.10,RateMap="South-Africa vs Nigeria"},
              new ExchangeRate{Id=3,Rate= 24.34,RateMap="Egypt vs Nigeria"},
              new ExchangeRate{Id=4,Rate= 380.66,RateMap="US vs Nigeria"},
            };
        }
    }
}
