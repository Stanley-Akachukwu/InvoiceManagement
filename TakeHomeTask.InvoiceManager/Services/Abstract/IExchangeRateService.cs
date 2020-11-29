using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;

namespace TakeHomeTask.InvoiceManager.Services.Abstract
{
   public interface IExchangeRateService
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRates();
    }
}
