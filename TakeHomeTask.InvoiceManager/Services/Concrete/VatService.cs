using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Services.Concrete
{
    public class VatService : IVatService
    {

        public async Task<IEnumerable<Vat>> GetVats() => await GetAllVats();
        public async Task<List<Vat>> GetAllVats()
        {
            return new List<Vat>
            {
                new Vat { Id = 1, Percentage = 7.5 },
                new Vat { Id = 2, Percentage = 5.0 },
                new Vat { Id = 3, Percentage = 0.9 },
                new Vat { Id = 4, Percentage = 0 }
            };
        }
    }
}
